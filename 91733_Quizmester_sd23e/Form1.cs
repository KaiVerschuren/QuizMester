using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _91733_Quizmester_sd23e
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=quiz;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        // dict to store login info
        Dictionary<string, string> loggedInUser = new Dictionary<string, string>();

        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private int currentCategoryId = 0;

        private int currentCorrectAnswer = 1;

        double timeLeft = 60.0;
        double questionTimeLeft = 5.0;

        Color defaultColor;
        bool flashToggle = false;
        int flashCounter = 0;

        int score = 0;
        bool joker = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            defaultColor = tbpQuizKver.BackColor;
            this.Text = "Quizmester";
        }

        #region Navigation
        private void toStart(object sender, EventArgs e)
        {
            tbcMainKver.SelectedTab = tbpStartKver;
        }

        private void toRegister(object sender, EventArgs e)
        {
            tbcMainKver.SelectedTab = tbpRegisterKver;
            btnToLoginKver.Hide();
        }

        private void toLogin(object sender, EventArgs e)
        {
            tbcMainKver.SelectedTab = tbpLoginKver;
        }

        private void toQuiz(object sender = null, EventArgs e = null)
        {
            tbcMainKver.SelectedTab = tbpQuizKver;
            startQuiz();
        }

        private void toLeaderBoard(object sender = null, EventArgs e = null)
        {
            tbcMainKver.SelectedTab = tbpLeaderBoardKver;
            handleLeaderboard();
        }
        #endregion

        #region Login & Register
        private void btnGuestKver_Click(object sender, EventArgs e)
        {
            loggedInUser["Name"] = "Guest";
            loggedInUser["Pass"] = "";
            toQuiz(null, EventArgs.Empty);
        }

        private void btnRegisterSubmitKver_Click(object sender, EventArgs e)
        {
            string username = txbRegisterNameKver.Text.Trim();
            string password = txbRegisterPasswordKver.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblRegisterResultKver.Text = "Please fill in all fields.";
                return;
            }

            if (password.Length < 4)
            {
                lblRegisterResultKver.Text = "Password must be at least 4 characters.";
                return;
            }

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                if (checkIfUserExists(username, sqlConnection))
                    return;
                registerUser(username, password, sqlConnection);
            }
        }

        private void registerUser(string username, string password, SqlConnection sqlConnection)
        {
            using (SqlCommand insertUser = new SqlCommand("INSERT INTO users (userName, userPass) VALUES (@username, @password)", sqlConnection))
            {
                insertUser.Parameters.AddWithValue("@username", username);
                insertUser.Parameters.AddWithValue("@password", password);

                insertUser.ExecuteNonQuery();
                lblRegisterResultKver.Text = "Registration successful!";
                btnToLoginKver.Location = btnRegisterSubmitKver.Location;
                btnToLoginKver.Show();
            }
        }

        private bool checkIfUserExists(string username, SqlConnection sqlConnection)
        {
            using (SqlCommand checkUser = new SqlCommand("SELECT COUNT(*) FROM users WHERE userName = @username", sqlConnection))
            {
                checkUser.Parameters.AddWithValue("@username", username);
                int exists = (int)checkUser.ExecuteScalar();
                if (exists > 0)
                {
                    lblRegisterResultKver.Text = "Username already exists.";
                    return true;
                }
                return false;
            }
        }

        private void btnLoginSubmitKver_Click(object sender, EventArgs e)
        {
            string username = txbLoginName.Text;
            string password = txbLoginPasswordKver.Text;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                checkForMatchingUser(username, password, sqlConnection);
            }
        }

        private void checkForMatchingUser(string username, string password, SqlConnection sqlConnection)
        {
            using (SqlCommand checkUser = new SqlCommand("SELECT COUNT(*) FROM users WHERE userName = @username AND userPass = @password", sqlConnection))
            {
                checkUser.Parameters.AddWithValue("@username", username);
                checkUser.Parameters.AddWithValue("@password", password);

                int userCount = (int)checkUser.ExecuteScalar();

                if (userCount > 0)
                {
                    loggedInUser["Name"] = username;
                    loggedInUser["Pass"] = password;

                    lblLoginResultKver.Text = "Login successful!" + "Logged in as: " + loggedInUser["Name"];
                    toQuiz();
                }
                else
                {
                    lblLoginResultKver.Text = "Username or password is wrong.";
                }
            }
        }
        #endregion

        #region Quiz Core
        private void startQuiz()
        {
            Button[] buttons = { btnAnswer1Kver, btnAnswer2Kver, btnAnswer3Kver, btnAnswer4Kver };
            foreach (Button answerBtn in buttons)
            {
                answerBtn.Enabled = true;
            }
            btnSkipKver.Enabled = true;

            int category = 2;
            questions = Question.FetchQuestions(category);
            currentCategoryId = category;

            showQuestion();

            timeLeft = questions.Count() * 3;
            tmrMainKver.Start();
        }

        private void showQuestion()
        {
            Question q = questions[currentQuestionIndex];

            lblQuestionKver.Text = q.QuestionText;

            questionTimeLeft = 5.0;
            tmrQuestionKver.Start();

            setButtons(
                new string[] { q.Answer1, q.Answer2, q.Answer3, q.Answer4 },
                q.CorrectAnswer
            );

            currentCorrectAnswer = q.CorrectAnswer;

            if (q.CategoryId == 1)
            {
                defaultColor = Color.Green;
                tbpQuizKver.BackColor = defaultColor;
            }
            else if (q.CategoryId == 2)
            {
                defaultColor = Color.Blue;
                tbpQuizKver.BackColor = defaultColor;
            }
        }

        private void setButtons(string[] answers, int correctAnswer)
        {
            var shuffled = answers
                .Select((text, index) => new { Text = text, Index = index + 1 })
                .OrderBy(x => Guid.NewGuid())
                .ToList();

            Button[] buttons = { btnAnswer1Kver, btnAnswer2Kver, btnAnswer3Kver, btnAnswer4Kver };

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = shuffled[i].Text;
                buttons[i].Tag = shuffled[i].Index;
            }

            Button correctBtn = buttons.First(b => (int)b.Tag == correctAnswer);
            Console.WriteLine("Correct answer: " + correctBtn.Text + " Tag: " + correctAnswer);
        }
        #endregion

        #region Answer Handling
        private async void answer_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Button[] buttons = { btnAnswer1Kver, btnAnswer2Kver, btnAnswer3Kver, btnAnswer4Kver };
            int chosenAnswer = (int)btn.Tag;

            Question q = questions[currentQuestionIndex];

            if (chosenAnswer == q.CorrectAnswer)
            {
                timeLeft += 3;
                int score = (int)Math.Round((questionTimeLeft / 5.0) * 100);
                changeScore(score, true);
            }
            else
            {
                timeLeft -= 3;
                int score = (int)Math.Round((questionTimeLeft / 5.0) * 100);
                changeScore(score, false);
            }

            tmrQuestionKver.Stop();
            await HandleButtonColors(q.CorrectAnswer);

            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Count)
            {
                showQuestion();
            }
            else
            {
                quizFinish("Finished!", true);
            }
        }

        private async Task HandleButtonColors(int correctTag)
        {
            Button[] buttons = { btnAnswer1Kver, btnAnswer2Kver, btnAnswer3Kver, btnAnswer4Kver };

            foreach (Button btn in buttons)
            {
                btn.BackColor = (int)btn.Tag == correctTag ? Color.Green : Color.Red;
                btn.Enabled = false;
            }

            btnSkipKver.Enabled = false;

            await Task.Delay(1000);

            foreach (Button btn in buttons)
            {
                btn.BackColor = SystemColors.Control;
                btn.Enabled = true;
            }

            btnSkipKver.Enabled = true;
        }

        private void ShowButtonColors(int correctTag)
        {
            Button[] buttons = { btnAnswer1Kver, btnAnswer2Kver, btnAnswer3Kver, btnAnswer4Kver };

            foreach (Button btn in buttons)
            {
                btn.BackColor = (int)btn.Tag == correctTag ? Color.Green : Color.Red;
                btn.Enabled = false;
            }

            btnSkipKver.Enabled = false;

            System.Windows.Forms.Timer colorTimer = new System.Windows.Forms.Timer();
            colorTimer.Interval = 1000;
            colorTimer.Tick += (s, e) =>
            {
                foreach (Button btn in buttons)
                {
                    btn.BackColor = SystemColors.Control;
                    btn.Enabled = true;
                }

                currentQuestionIndex++;
                showQuestion();
                btnSkipKver.Enabled = true;

                colorTimer.Stop();
                colorTimer.Dispose();
                tmrQuestionKver.Start();
                tmrMainKver.Start();
            };
            colorTimer.Start();
        }
        #endregion

        #region Timers
        private void tmrMainKver_Tick(object sender, EventArgs e)
        {
            if (timeLeft < 10)
            {
                flashCounter++;
                if (flashCounter >= 10)
                {
                    flashCounter = 0;
                    flashToggle = !flashToggle;
                    tbpQuizKver.BackColor = flashToggle ? Color.Red : defaultColor;
                }
            }

            if (timeLeft > 0)
            {
                timeLeft -= 0.1;
                lblTimeLeftKver.Text = timeLeft.ToString("0.0");
            }
            else
            {
                tmrMainKver.Stop();
                lblTimeLeftKver.Text = "0.0";
                tbpQuizKver.BackColor = defaultColor;
                quizFinish("Times up", false);
            }
        }

        private void tmrQuestionKver_Tick(object sender, EventArgs e)
        {
            questionTimeLeft -= 0.1;
            lblQuestionTimeKver.Text = questionTimeLeft.ToString("0.0");

            if (questionTimeLeft <= 0)
            {
                tmrQuestionKver.Stop();
                tmrMainKver.Stop();
                changeScore(100, false);

                ShowButtonColors(currentCorrectAnswer);
            }
        }
        #endregion

        #region Score & Finish
        private void changeScore(int change, bool op)
        {
            if (op)
                score += change;
            else
                score -= change;

            lblScoreKver.Text = score.ToString();
        }

        private void quizFinish(string message, bool win)
        {
            tmrMainKver.Stop();
            tmrQuestionKver.Stop();

            lblMessageKver.Text = message;
            lblEndScoreKver.Text = "Score: " + score.ToString();

            Button[] buttons = { btnAnswer1Kver, btnAnswer2Kver, btnAnswer3Kver, btnAnswer4Kver };
            foreach (Button btn in buttons)
            {
                btn.Enabled = false;
            }

            if (win)
            {
                addScoreToDB();
            }
            toLeaderBoard();
        }
        #endregion

        #region Leaderboard
        private void handleLeaderboard()
        {
            var leaderboard = getLeaderboard();

            tlpLeaderboardKver.Controls.Clear();
            tlpLeaderboardKver.RowStyles.Clear();

            int rows = leaderboard.GetLength(0);
            tlpLeaderboardKver.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                tlpLeaderboardKver.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / rows));

                tlpLeaderboardKver.Controls.Add(new Label
                {
                    Text = $"#{i + 1}",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                }, 0, i);

                tlpLeaderboardKver.Controls.Add(new Label
                {
                    Text = leaderboard[i, 0],
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                }, 1, i);

                tlpLeaderboardKver.Controls.Add(new Label
                {
                    Text = leaderboard[i, 1],
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                }, 2, i);

                tlpLeaderboardKver.Controls.Add(new Label
                {
                    Text = leaderboard[i, 2],
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                }, 3, i);
            }
        }

        private void addScoreToDB()
        {
            string userName = loggedInUser["Name"];
            int userScore = score;
            int category = currentCategoryId;

            string query = "INSERT INTO rankings (userName, score, categoryId) VALUES (@userName, @score, @categoryId)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@score", userScore);
                cmd.Parameters.AddWithValue("@categoryId", category);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private string[,] getLeaderboard()
        {
            string[,] leaderboard = new string[10, 3];

            string sql = "SELECT TOP 10 userName, score, categoryId FROM rankings ORDER BY score DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int i = 0;
                    while (reader.Read() && i < 10)
                    {
                        leaderboard[i, 0] = reader["userName"].ToString();
                        leaderboard[i, 1] = reader["score"].ToString();
                        leaderboard[i, 2] = reader["categoryId"].ToString();
                        i++;
                    }
                }
            }
            return leaderboard;
        }
        #endregion

        #region Joker
        private void useJoker(object sender = null, EventArgs e = null)
        {
            if (joker != true)
            {
                btnSkipKver.Enabled = false;
                return;
            }

            if (currentQuestionIndex < (questions.Count - 1))
            {
                joker = false;
                btnSkipKver.Enabled = false;

                tmrQuestionKver.Stop();
                tmrMainKver.Stop();
                ShowButtonColors(currentCorrectAnswer);

                currentQuestionIndex++;
                showQuestion();
            }
            else
            {
                quizFinish("You used your joker to win", true);
            }
        }
        #endregion
    }
}
