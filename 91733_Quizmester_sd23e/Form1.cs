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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbcMainKver.Appearance = TabAppearance.FlatButtons;
            tbcMainKver.ItemSize = new Size(0, 1);
            tbcMainKver.SizeMode = TabSizeMode.Fixed;

            defaultColor = tbpQuizKver.BackColor;

            this.Text = "Quizmester";

        }

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

        #region Login register

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

            // check if input fields are non empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblRegisterResultKver.Text = "Please fill in all fields.";

                // exit
                return;
            }

            // check if password is at least 4 chars
            if (password.Length < 4)
            {
                lblRegisterResultKver.Text = "Password must be at least 4 characters.";
                return;
            }

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                // check if username exists
                if (checkIfUserExists(username, sqlConnection))
                    return;

                // insert new user
                registerUser(username, password, sqlConnection);
            }
        }

        private void registerUser(string username, string password, SqlConnection sqlConnection)
        {
            // insert new user
            using (SqlCommand insertUser = new SqlCommand("INSERT INTO users (userName, userPass) VALUES (@username, @password)", sqlConnection))
            {
                insertUser.Parameters.AddWithValue("@username", username);
                // plain text, should probably hash sometime
                insertUser.Parameters.AddWithValue("@password", password);

                insertUser.ExecuteNonQuery();
                lblRegisterResultKver.Text = "Registration successful!";
                btnToLoginKver.Location = btnRegisterSubmitKver.Location;
                btnToLoginKver.Show();
            }
        }

        private bool checkIfUserExists(string username, SqlConnection sqlConnection)
        {
            // this retrieves any user matchin the text in the input field, then if the existing users are above 0, meaning
            // theres a user with the same name, it returns true.
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
            // get input fields:
            // name: txbLoginName
            // pass: txbLoginPasswordKver

            // sql to check for a user matching and a matching password

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
                    // store logged in user info
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

        private void startQuiz()
        {
            Button[] buttons = { btnAnswer1Kver, btnAnswer2Kver, btnAnswer3Kver, btnAnswer4Kver };
            foreach (Button answerBtn in buttons)
            {
                answerBtn.Enabled = true;
            }

            int category = 2;
            questions = Question.FetchQuestions(category);
            currentCategoryId = category;


            showQuestion();

            // times 3 foreach question
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
                .Select((text, index) => new { Text = text, Index = index + 1 }) // +1 so it's 1-4 instead of 0-3
                .OrderBy(x => Guid.NewGuid()) // random shuffle method thingy
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

            // show colors (true = show result)
            await HandleButtonColors(q.CorrectAnswer);

            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Count)
            {
                Console.WriteLine("current question: " + currentQuestionIndex + " current count: " + questions.Count);
                showQuestion();
            }
            else
            {
                quizFinish("Finished", true);
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

            await Task.Delay(1000);

            foreach (Button btn in buttons)
            {
                btn.BackColor = SystemColors.Control;
                btn.Enabled = true;
            }

        }

        private void ShowButtonColors(int correctTag)
        {
            Button[] buttons = { btnAnswer1Kver, btnAnswer2Kver, btnAnswer3Kver, btnAnswer4Kver };

            foreach (Button btn in buttons)
            {
                btn.BackColor = (int)btn.Tag == correctTag ? Color.Green : Color.Red;
                btn.Enabled = false;
            }

            // Use Forms Timer for 1-second delay
            System.Windows.Forms.Timer colorTimer = new System.Windows.Forms.Timer();
            colorTimer.Interval = 1000; // 1 second
            colorTimer.Tick += (s, e) =>
            {
                foreach (Button btn in buttons)
                {
                    btn.BackColor = SystemColors.Control;
                    btn.Enabled = true;
                }

                // Move to the next question AFTER the delay
                currentQuestionIndex++;
                showQuestion();

                colorTimer.Stop();
                colorTimer.Dispose();
                tmrQuestionKver.Start();
                tmrMainKver.Start();
            };
            colorTimer.Start();
        }

        private void tmrMainKver_Tick(object sender, EventArgs e)
        {
            if (timeLeft < 10)
            {
                flashCounter++;

                // every 10 ticks = 1 second (because Interval = 100ms)
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
                tbpQuizKver.BackColor = defaultColor; // reset color
                quizFinish("Times up", false);
            }
        }

        // op as in operator, true is add, false is subtract
        private void changeScore(int change, bool op)
        {
            if (op)
            {
                score += change;
            }
            else
            {
                score -= change;
            }

            lblScoreKver.Text = score.ToString();
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

        private void quizFinish(string message, bool win)
        {
            // quiz finished
            MessageBox.Show(message);
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

        private void handleLeaderboard()
        {

            // Get leaderboard from DB
            var leaderboard = getLeaderboard(); // string[,] array [10,2]

            tlpLeaderboardKver.Controls.Clear();
            tlpLeaderboardKver.RowStyles.Clear();

            int rows = leaderboard.GetLength(0); // usually 10
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
                    Text = leaderboard[i, 0], // username from DB
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                }, 1, i);

                tlpLeaderboardKver.Controls.Add(new Label
                {
                    Text = leaderboard[i, 1], // score from DB
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                }, 2, i);

                tlpLeaderboardKver.Controls.Add(new Label
                {
                    Text = leaderboard[i, 2], // categoryid from DB
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                }, 3, i);
            }
        }


        private void addScoreToDB()
        {
            // use
            // loggedInUser["Name"] = "";
            // to set the name, and get the score from the variable score

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
            string[,] leaderboard = new string[10, 3]; // [rank, name & score]

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
    }
}
