namespace _91733_Quizmester_sd23e
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbcMainKver = new System.Windows.Forms.TabControl();
            this.tbpStartKver = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuestKver = new System.Windows.Forms.Button();
            this.btnLoginKver = new System.Windows.Forms.Button();
            this.btnRegisterKver = new System.Windows.Forms.Button();
            this.tbpRegisterKver = new System.Windows.Forms.TabPage();
            this.lblRegisterResultKver = new System.Windows.Forms.Label();
            this.btnToLoginKver = new System.Windows.Forms.Button();
            this.btnRegisterSubmitKver = new System.Windows.Forms.Button();
            this.txbRegisterPasswordKver = new System.Windows.Forms.TextBox();
            this.txbRegisterNameKver = new System.Windows.Forms.TextBox();
            this.tbpLoginKver = new System.Windows.Forms.TabPage();
            this.lblLoginResultKver = new System.Windows.Forms.Label();
            this.btnLoginSubmitKver = new System.Windows.Forms.Button();
            this.txbLoginPasswordKver = new System.Windows.Forms.TextBox();
            this.txbLoginName = new System.Windows.Forms.TextBox();
            this.tbpQuizKver = new System.Windows.Forms.TabPage();
            this.lblQuestionTimeKver = new System.Windows.Forms.Label();
            this.lblScoreKver = new System.Windows.Forms.Label();
            this.lblTimeLeftKver = new System.Windows.Forms.Label();
            this.lblQuestionKver = new System.Windows.Forms.Label();
            this.btnAnswer1Kver = new System.Windows.Forms.Button();
            this.btnAnswer3Kver = new System.Windows.Forms.Button();
            this.btnSkipKver = new System.Windows.Forms.Button();
            this.btnAnswer4Kver = new System.Windows.Forms.Button();
            this.btnAnswer2Kver = new System.Windows.Forms.Button();
            this.tbpLeaderBoardKver = new System.Windows.Forms.TabPage();
            this.lblMessageKver = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tlpLeaderboardKver = new System.Windows.Forms.TableLayoutPanel();
            this.tmrMainKver = new System.Windows.Forms.Timer(this.components);
            this.tmrQuestionKver = new System.Windows.Forms.Timer(this.components);
            this.lblEndScoreKver = new System.Windows.Forms.Label();
            this.tbcMainKver.SuspendLayout();
            this.tbpStartKver.SuspendLayout();
            this.tbpRegisterKver.SuspendLayout();
            this.tbpLoginKver.SuspendLayout();
            this.tbpQuizKver.SuspendLayout();
            this.tbpLeaderBoardKver.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMainKver
            // 
            this.tbcMainKver.Controls.Add(this.tbpStartKver);
            this.tbcMainKver.Controls.Add(this.tbpRegisterKver);
            this.tbcMainKver.Controls.Add(this.tbpLoginKver);
            this.tbcMainKver.Controls.Add(this.tbpQuizKver);
            this.tbcMainKver.Controls.Add(this.tbpLeaderBoardKver);
            this.tbcMainKver.Location = new System.Drawing.Point(12, 12);
            this.tbcMainKver.Name = "tbcMainKver";
            this.tbcMainKver.SelectedIndex = 0;
            this.tbcMainKver.Size = new System.Drawing.Size(1101, 534);
            this.tbcMainKver.TabIndex = 0;
            // 
            // tbpStartKver
            // 
            this.tbpStartKver.Controls.Add(this.button1);
            this.tbpStartKver.Controls.Add(this.btnGuestKver);
            this.tbpStartKver.Controls.Add(this.btnLoginKver);
            this.tbpStartKver.Controls.Add(this.btnRegisterKver);
            this.tbpStartKver.Location = new System.Drawing.Point(4, 22);
            this.tbpStartKver.Name = "tbpStartKver";
            this.tbpStartKver.Padding = new System.Windows.Forms.Padding(3);
            this.tbpStartKver.Size = new System.Drawing.Size(1093, 508);
            this.tbpStartKver.TabIndex = 0;
            this.tbpStartKver.Text = "start";
            this.tbpStartKver.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Leaderboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.toLeaderBoard);
            // 
            // btnGuestKver
            // 
            this.btnGuestKver.Location = new System.Drawing.Point(168, 6);
            this.btnGuestKver.Name = "btnGuestKver";
            this.btnGuestKver.Size = new System.Drawing.Size(96, 23);
            this.btnGuestKver.TabIndex = 0;
            this.btnGuestKver.Text = "Log in as guest";
            this.btnGuestKver.UseVisualStyleBackColor = true;
            this.btnGuestKver.Click += new System.EventHandler(this.btnGuestKver_Click);
            // 
            // btnLoginKver
            // 
            this.btnLoginKver.Location = new System.Drawing.Point(87, 6);
            this.btnLoginKver.Name = "btnLoginKver";
            this.btnLoginKver.Size = new System.Drawing.Size(75, 23);
            this.btnLoginKver.TabIndex = 0;
            this.btnLoginKver.Text = "Login";
            this.btnLoginKver.UseVisualStyleBackColor = true;
            this.btnLoginKver.Click += new System.EventHandler(this.toLogin);
            // 
            // btnRegisterKver
            // 
            this.btnRegisterKver.Location = new System.Drawing.Point(6, 6);
            this.btnRegisterKver.Name = "btnRegisterKver";
            this.btnRegisterKver.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterKver.TabIndex = 0;
            this.btnRegisterKver.Text = "Register";
            this.btnRegisterKver.UseVisualStyleBackColor = true;
            this.btnRegisterKver.Click += new System.EventHandler(this.toRegister);
            // 
            // tbpRegisterKver
            // 
            this.tbpRegisterKver.Controls.Add(this.lblRegisterResultKver);
            this.tbpRegisterKver.Controls.Add(this.btnToLoginKver);
            this.tbpRegisterKver.Controls.Add(this.btnRegisterSubmitKver);
            this.tbpRegisterKver.Controls.Add(this.txbRegisterPasswordKver);
            this.tbpRegisterKver.Controls.Add(this.txbRegisterNameKver);
            this.tbpRegisterKver.Location = new System.Drawing.Point(4, 22);
            this.tbpRegisterKver.Name = "tbpRegisterKver";
            this.tbpRegisterKver.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegisterKver.Size = new System.Drawing.Size(1093, 508);
            this.tbpRegisterKver.TabIndex = 1;
            this.tbpRegisterKver.Text = "Register";
            this.tbpRegisterKver.UseVisualStyleBackColor = true;
            // 
            // lblRegisterResultKver
            // 
            this.lblRegisterResultKver.AutoSize = true;
            this.lblRegisterResultKver.Location = new System.Drawing.Point(14, 91);
            this.lblRegisterResultKver.Name = "lblRegisterResultKver";
            this.lblRegisterResultKver.Size = new System.Drawing.Size(10, 13);
            this.lblRegisterResultKver.TabIndex = 2;
            this.lblRegisterResultKver.Text = "-";
            // 
            // btnToLoginKver
            // 
            this.btnToLoginKver.Location = new System.Drawing.Point(84, 55);
            this.btnToLoginKver.Name = "btnToLoginKver";
            this.btnToLoginKver.Size = new System.Drawing.Size(75, 23);
            this.btnToLoginKver.TabIndex = 1;
            this.btnToLoginKver.Text = "To Login";
            this.btnToLoginKver.UseVisualStyleBackColor = true;
            this.btnToLoginKver.Click += new System.EventHandler(this.toLogin);
            // 
            // btnRegisterSubmitKver
            // 
            this.btnRegisterSubmitKver.Location = new System.Drawing.Point(3, 55);
            this.btnRegisterSubmitKver.Name = "btnRegisterSubmitKver";
            this.btnRegisterSubmitKver.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterSubmitKver.TabIndex = 1;
            this.btnRegisterSubmitKver.Text = "Submit";
            this.btnRegisterSubmitKver.UseVisualStyleBackColor = true;
            this.btnRegisterSubmitKver.Click += new System.EventHandler(this.btnRegisterSubmitKver_Click);
            // 
            // txbRegisterPasswordKver
            // 
            this.txbRegisterPasswordKver.Location = new System.Drawing.Point(3, 29);
            this.txbRegisterPasswordKver.Name = "txbRegisterPasswordKver";
            this.txbRegisterPasswordKver.Size = new System.Drawing.Size(100, 20);
            this.txbRegisterPasswordKver.TabIndex = 0;
            // 
            // txbRegisterNameKver
            // 
            this.txbRegisterNameKver.Location = new System.Drawing.Point(3, 3);
            this.txbRegisterNameKver.Name = "txbRegisterNameKver";
            this.txbRegisterNameKver.Size = new System.Drawing.Size(100, 20);
            this.txbRegisterNameKver.TabIndex = 0;
            // 
            // tbpLoginKver
            // 
            this.tbpLoginKver.Controls.Add(this.lblLoginResultKver);
            this.tbpLoginKver.Controls.Add(this.btnLoginSubmitKver);
            this.tbpLoginKver.Controls.Add(this.txbLoginPasswordKver);
            this.tbpLoginKver.Controls.Add(this.txbLoginName);
            this.tbpLoginKver.Location = new System.Drawing.Point(4, 22);
            this.tbpLoginKver.Name = "tbpLoginKver";
            this.tbpLoginKver.Size = new System.Drawing.Size(1093, 508);
            this.tbpLoginKver.TabIndex = 2;
            this.tbpLoginKver.Text = "Login";
            this.tbpLoginKver.UseVisualStyleBackColor = true;
            // 
            // lblLoginResultKver
            // 
            this.lblLoginResultKver.AutoSize = true;
            this.lblLoginResultKver.Location = new System.Drawing.Point(13, 91);
            this.lblLoginResultKver.Name = "lblLoginResultKver";
            this.lblLoginResultKver.Size = new System.Drawing.Size(10, 13);
            this.lblLoginResultKver.TabIndex = 5;
            this.lblLoginResultKver.Text = "-";
            // 
            // btnLoginSubmitKver
            // 
            this.btnLoginSubmitKver.Location = new System.Drawing.Point(3, 57);
            this.btnLoginSubmitKver.Name = "btnLoginSubmitKver";
            this.btnLoginSubmitKver.Size = new System.Drawing.Size(75, 23);
            this.btnLoginSubmitKver.TabIndex = 4;
            this.btnLoginSubmitKver.Text = "Submit";
            this.btnLoginSubmitKver.UseVisualStyleBackColor = true;
            this.btnLoginSubmitKver.Click += new System.EventHandler(this.btnLoginSubmitKver_Click);
            // 
            // txbLoginPasswordKver
            // 
            this.txbLoginPasswordKver.Location = new System.Drawing.Point(3, 31);
            this.txbLoginPasswordKver.Name = "txbLoginPasswordKver";
            this.txbLoginPasswordKver.Size = new System.Drawing.Size(100, 20);
            this.txbLoginPasswordKver.TabIndex = 2;
            // 
            // txbLoginName
            // 
            this.txbLoginName.Location = new System.Drawing.Point(3, 5);
            this.txbLoginName.Name = "txbLoginName";
            this.txbLoginName.Size = new System.Drawing.Size(100, 20);
            this.txbLoginName.TabIndex = 3;
            // 
            // tbpQuizKver
            // 
            this.tbpQuizKver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbpQuizKver.Controls.Add(this.lblQuestionTimeKver);
            this.tbpQuizKver.Controls.Add(this.lblScoreKver);
            this.tbpQuizKver.Controls.Add(this.lblTimeLeftKver);
            this.tbpQuizKver.Controls.Add(this.lblQuestionKver);
            this.tbpQuizKver.Controls.Add(this.btnAnswer1Kver);
            this.tbpQuizKver.Controls.Add(this.btnAnswer3Kver);
            this.tbpQuizKver.Controls.Add(this.btnSkipKver);
            this.tbpQuizKver.Controls.Add(this.btnAnswer4Kver);
            this.tbpQuizKver.Controls.Add(this.btnAnswer2Kver);
            this.tbpQuizKver.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpQuizKver.Location = new System.Drawing.Point(4, 22);
            this.tbpQuizKver.Name = "tbpQuizKver";
            this.tbpQuizKver.Size = new System.Drawing.Size(1093, 508);
            this.tbpQuizKver.TabIndex = 3;
            this.tbpQuizKver.Text = "Quiz";
            this.tbpQuizKver.UseVisualStyleBackColor = true;
            // 
            // lblQuestionTimeKver
            // 
            this.lblQuestionTimeKver.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionTimeKver.Location = new System.Drawing.Point(277, 15);
            this.lblQuestionTimeKver.Name = "lblQuestionTimeKver";
            this.lblQuestionTimeKver.Size = new System.Drawing.Size(196, 55);
            this.lblQuestionTimeKver.TabIndex = 1;
            this.lblQuestionTimeKver.Text = "---";
            this.lblQuestionTimeKver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreKver
            // 
            this.lblScoreKver.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreKver.Location = new System.Drawing.Point(897, 55);
            this.lblScoreKver.Name = "lblScoreKver";
            this.lblScoreKver.Size = new System.Drawing.Size(196, 55);
            this.lblScoreKver.TabIndex = 1;
            this.lblScoreKver.Text = "---";
            this.lblScoreKver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeLeftKver
            // 
            this.lblTimeLeftKver.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeftKver.Location = new System.Drawing.Point(897, 0);
            this.lblTimeLeftKver.Name = "lblTimeLeftKver";
            this.lblTimeLeftKver.Size = new System.Drawing.Size(196, 55);
            this.lblTimeLeftKver.TabIndex = 1;
            this.lblTimeLeftKver.Text = "---";
            this.lblTimeLeftKver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionKver
            // 
            this.lblQuestionKver.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionKver.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionKver.ForeColor = System.Drawing.Color.Black;
            this.lblQuestionKver.Location = new System.Drawing.Point(3, 70);
            this.lblQuestionKver.Name = "lblQuestionKver";
            this.lblQuestionKver.Size = new System.Drawing.Size(744, 95);
            this.lblQuestionKver.TabIndex = 1;
            this.lblQuestionKver.Text = "---";
            this.lblQuestionKver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnswer1Kver
            // 
            this.btnAnswer1Kver.Location = new System.Drawing.Point(3, 185);
            this.btnAnswer1Kver.Name = "btnAnswer1Kver";
            this.btnAnswer1Kver.Size = new System.Drawing.Size(369, 158);
            this.btnAnswer1Kver.TabIndex = 0;
            this.btnAnswer1Kver.Text = "Answer 1";
            this.btnAnswer1Kver.UseVisualStyleBackColor = true;
            this.btnAnswer1Kver.Click += new System.EventHandler(this.answer_click);
            // 
            // btnAnswer3Kver
            // 
            this.btnAnswer3Kver.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer3Kver.Location = new System.Drawing.Point(3, 349);
            this.btnAnswer3Kver.Name = "btnAnswer3Kver";
            this.btnAnswer3Kver.Size = new System.Drawing.Size(369, 158);
            this.btnAnswer3Kver.TabIndex = 0;
            this.btnAnswer3Kver.Text = "Answer 3";
            this.btnAnswer3Kver.UseVisualStyleBackColor = true;
            this.btnAnswer3Kver.Click += new System.EventHandler(this.answer_click);
            // 
            // btnSkipKver
            // 
            this.btnSkipKver.Location = new System.Drawing.Point(904, 459);
            this.btnSkipKver.Name = "btnSkipKver";
            this.btnSkipKver.Size = new System.Drawing.Size(186, 46);
            this.btnSkipKver.TabIndex = 0;
            this.btnSkipKver.Text = "Skip question";
            this.btnSkipKver.UseVisualStyleBackColor = true;
            this.btnSkipKver.Click += new System.EventHandler(this.useJoker);
            // 
            // btnAnswer4Kver
            // 
            this.btnAnswer4Kver.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer4Kver.Location = new System.Drawing.Point(378, 349);
            this.btnAnswer4Kver.Name = "btnAnswer4Kver";
            this.btnAnswer4Kver.Size = new System.Drawing.Size(369, 158);
            this.btnAnswer4Kver.TabIndex = 0;
            this.btnAnswer4Kver.Text = "Answer 4";
            this.btnAnswer4Kver.UseVisualStyleBackColor = true;
            this.btnAnswer4Kver.Click += new System.EventHandler(this.answer_click);
            // 
            // btnAnswer2Kver
            // 
            this.btnAnswer2Kver.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer2Kver.Location = new System.Drawing.Point(378, 185);
            this.btnAnswer2Kver.Name = "btnAnswer2Kver";
            this.btnAnswer2Kver.Size = new System.Drawing.Size(369, 158);
            this.btnAnswer2Kver.TabIndex = 0;
            this.btnAnswer2Kver.Text = "Answer 2";
            this.btnAnswer2Kver.UseVisualStyleBackColor = true;
            this.btnAnswer2Kver.Click += new System.EventHandler(this.answer_click);
            // 
            // tbpLeaderBoardKver
            // 
            this.tbpLeaderBoardKver.Controls.Add(this.lblEndScoreKver);
            this.tbpLeaderBoardKver.Controls.Add(this.lblMessageKver);
            this.tbpLeaderBoardKver.Controls.Add(this.tableLayoutPanel1);
            this.tbpLeaderBoardKver.Controls.Add(this.tlpLeaderboardKver);
            this.tbpLeaderBoardKver.Location = new System.Drawing.Point(4, 22);
            this.tbpLeaderBoardKver.Name = "tbpLeaderBoardKver";
            this.tbpLeaderBoardKver.Size = new System.Drawing.Size(1093, 508);
            this.tbpLeaderBoardKver.TabIndex = 4;
            this.tbpLeaderBoardKver.Text = "leaderboard";
            this.tbpLeaderBoardKver.UseVisualStyleBackColor = true;
            // 
            // lblMessageKver
            // 
            this.lblMessageKver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessageKver.AutoSize = true;
            this.lblMessageKver.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageKver.Location = new System.Drawing.Point(3, 13);
            this.lblMessageKver.Name = "lblMessageKver";
            this.lblMessageKver.Size = new System.Drawing.Size(161, 35);
            this.lblMessageKver.TabIndex = 0;
            this.lblMessageKver.Text = "{Message}";
            this.lblMessageKver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(441, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(649, 73);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 73);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 73);
            this.label3.TabIndex = 0;
            this.label3.Text = "Score";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(489, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 73);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpLeaderboardKver
            // 
            this.tlpLeaderboardKver.ColumnCount = 4;
            this.tlpLeaderboardKver.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLeaderboardKver.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLeaderboardKver.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLeaderboardKver.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLeaderboardKver.Location = new System.Drawing.Point(441, 92);
            this.tlpLeaderboardKver.Name = "tlpLeaderboardKver";
            this.tlpLeaderboardKver.RowCount = 1;
            this.tlpLeaderboardKver.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeaderboardKver.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 413F));
            this.tlpLeaderboardKver.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 413F));
            this.tlpLeaderboardKver.Size = new System.Drawing.Size(649, 413);
            this.tlpLeaderboardKver.TabIndex = 0;
            // 
            // tmrMainKver
            // 
            this.tmrMainKver.Tick += new System.EventHandler(this.tmrMainKver_Tick);
            // 
            // tmrQuestionKver
            // 
            this.tmrQuestionKver.Tick += new System.EventHandler(this.tmrQuestionKver_Tick);
            // 
            // lblEndScoreKver
            // 
            this.lblEndScoreKver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndScoreKver.AutoSize = true;
            this.lblEndScoreKver.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndScoreKver.Location = new System.Drawing.Point(3, 51);
            this.lblEndScoreKver.Name = "lblEndScoreKver";
            this.lblEndScoreKver.Size = new System.Drawing.Size(114, 35);
            this.lblEndScoreKver.TabIndex = 0;
            this.lblEndScoreKver.Text = "{score}";
            this.lblEndScoreKver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 558);
            this.Controls.Add(this.tbcMainKver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcMainKver.ResumeLayout(false);
            this.tbpStartKver.ResumeLayout(false);
            this.tbpRegisterKver.ResumeLayout(false);
            this.tbpRegisterKver.PerformLayout();
            this.tbpLoginKver.ResumeLayout(false);
            this.tbpLoginKver.PerformLayout();
            this.tbpQuizKver.ResumeLayout(false);
            this.tbpLeaderBoardKver.ResumeLayout(false);
            this.tbpLeaderBoardKver.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMainKver;
        private System.Windows.Forms.TabPage tbpStartKver;
        private System.Windows.Forms.TabPage tbpRegisterKver;
        private System.Windows.Forms.Button btnRegisterKver;
        private System.Windows.Forms.Button btnLoginKver;
        private System.Windows.Forms.TabPage tbpLoginKver;
        private System.Windows.Forms.TextBox txbRegisterPasswordKver;
        private System.Windows.Forms.TextBox txbRegisterNameKver;
        private System.Windows.Forms.Button btnRegisterSubmitKver;
        private System.Windows.Forms.Button btnLoginSubmitKver;
        private System.Windows.Forms.TextBox txbLoginPasswordKver;
        private System.Windows.Forms.TextBox txbLoginName;
        private System.Windows.Forms.Label lblRegisterResultKver;
        private System.Windows.Forms.Label lblLoginResultKver;
        private System.Windows.Forms.Button btnToLoginKver;
        private System.Windows.Forms.Button btnGuestKver;
        private System.Windows.Forms.TabPage tbpQuizKver;
        private System.Windows.Forms.Button btnAnswer2Kver;
        private System.Windows.Forms.Button btnAnswer1Kver;
        private System.Windows.Forms.Button btnAnswer3Kver;
        private System.Windows.Forms.Button btnAnswer4Kver;
        private System.Windows.Forms.Label lblTimeLeftKver;
        private System.Windows.Forms.Label lblQuestionKver;
        private System.Windows.Forms.Label lblQuestionTimeKver;
        private System.Windows.Forms.Label lblScoreKver;
        private System.Windows.Forms.Button btnSkipKver;
        private System.Windows.Forms.Timer tmrMainKver;
        private System.Windows.Forms.Timer tmrQuestionKver;
        private System.Windows.Forms.TabPage tbpLeaderBoardKver;
        private System.Windows.Forms.TableLayoutPanel tlpLeaderboardKver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMessageKver;
        private System.Windows.Forms.Label lblEndScoreKver;
    }
}

