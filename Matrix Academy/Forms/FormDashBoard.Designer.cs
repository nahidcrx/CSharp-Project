namespace Matrix_Academy.Forms
{
    partial class FormDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashBoard));
            this.TopPan = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.LeftPan = new System.Windows.Forms.Panel();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAttendence = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnSetUp = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStudnent = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.BottomPan = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.ucAttendence = new Matrix_Academy.User_Control.UCAttendence();
            this.ucPayment = new Matrix_Academy.User_Control.UCPayment();
            this.ucDashBoard = new Matrix_Academy.User_Control.UCDashBoard();
            this.ucStudent = new Matrix_Academy.User_Control.UCStudent();
            this.ucTeacher = new Matrix_Academy.User_Control.UCTeacher();
            this.ucSettings = new Matrix_Academy.User_Control.UCSettings();
            this.ucLogOut = new Matrix_Academy.User_Control.UCLogOut();
            this.ucSetUp = new Matrix_Academy.User_Control.UCSetUp();
            this.TopPan.SuspendLayout();
            this.LeftPan.SuspendLayout();
            this.BottomPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPan
            // 
            this.TopPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.TopPan.Controls.Add(this.lblTitle);
            this.TopPan.Controls.Add(this.lblDate);
            this.TopPan.Controls.Add(this.btnExit);
            this.TopPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPan.Location = new System.Drawing.Point(0, 0);
            this.TopPan.Name = "TopPan";
            this.TopPan.Size = new System.Drawing.Size(1236, 100);
            this.TopPan.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(239, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(362, 100);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "DashBoard";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Palatino Linotype", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(607, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(489, 100);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LeftPan
            // 
            this.LeftPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.LeftPan.Controls.Add(this.btnDashBoard);
            this.LeftPan.Controls.Add(this.btnSettings);
            this.LeftPan.Controls.Add(this.btnAttendence);
            this.LeftPan.Controls.Add(this.btnPayment);
            this.LeftPan.Controls.Add(this.btnSetUp);
            this.LeftPan.Controls.Add(this.btnLogout);
            this.LeftPan.Controls.Add(this.btnStudnent);
            this.LeftPan.Controls.Add(this.btnTeacher);
            this.LeftPan.Controls.Add(this.btnExam);
            this.LeftPan.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPan.Location = new System.Drawing.Point(0, 100);
            this.LeftPan.Name = "LeftPan";
            this.LeftPan.Size = new System.Drawing.Size(250, 686);
            this.LeftPan.TabIndex = 0;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Courier New", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.Location = new System.Drawing.Point(0, 0);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(250, 70);
            this.btnDashBoard.TabIndex = 10;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Courier New", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 490);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(250, 70);
            this.btnSettings.TabIndex = 80;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAttendence
            // 
            this.btnAttendence.FlatAppearance.BorderSize = 0;
            this.btnAttendence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendence.Font = new System.Drawing.Font("Courier New", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendence.ForeColor = System.Drawing.Color.White;
            this.btnAttendence.Location = new System.Drawing.Point(0, 280);
            this.btnAttendence.Name = "btnAttendence";
            this.btnAttendence.Size = new System.Drawing.Size(250, 70);
            this.btnAttendence.TabIndex = 50;
            this.btnAttendence.Text = "Attendence";
            this.btnAttendence.UseVisualStyleBackColor = true;
            this.btnAttendence.Click += new System.EventHandler(this.btnAttendence_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Courier New", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(0, 70);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(250, 70);
            this.btnPayment.TabIndex = 20;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnSetUp
            // 
            this.btnSetUp.FlatAppearance.BorderSize = 0;
            this.btnSetUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetUp.Font = new System.Drawing.Font("Courier New", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetUp.ForeColor = System.Drawing.Color.White;
            this.btnSetUp.Location = new System.Drawing.Point(0, 420);
            this.btnSetUp.Name = "btnSetUp";
            this.btnSetUp.Size = new System.Drawing.Size(250, 70);
            this.btnSetUp.TabIndex = 70;
            this.btnSetUp.Text = "SetUp";
            this.btnSetUp.UseVisualStyleBackColor = true;
            this.btnSetUp.Click += new System.EventHandler(this.btnSetUp_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Courier New", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 560);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 70);
            this.btnLogout.TabIndex = 90;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStudnent
            // 
            this.btnStudnent.FlatAppearance.BorderSize = 0;
            this.btnStudnent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudnent.Font = new System.Drawing.Font("Courier New", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudnent.ForeColor = System.Drawing.Color.White;
            this.btnStudnent.Location = new System.Drawing.Point(0, 210);
            this.btnStudnent.Name = "btnStudnent";
            this.btnStudnent.Size = new System.Drawing.Size(250, 70);
            this.btnStudnent.TabIndex = 40;
            this.btnStudnent.Text = "Student";
            this.btnStudnent.UseVisualStyleBackColor = true;
            this.btnStudnent.Click += new System.EventHandler(this.btnStudnent_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.FlatAppearance.BorderSize = 0;
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacher.Font = new System.Drawing.Font("Courier New", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.ForeColor = System.Drawing.Color.White;
            this.btnTeacher.Location = new System.Drawing.Point(0, 140);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(250, 70);
            this.btnTeacher.TabIndex = 30;
            this.btnTeacher.Text = "Teacher";
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnExam
            // 
            this.btnExam.FlatAppearance.BorderSize = 0;
            this.btnExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExam.Font = new System.Drawing.Font("Courier New", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExam.ForeColor = System.Drawing.Color.White;
            this.btnExam.Location = new System.Drawing.Point(0, 350);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(250, 70);
            this.btnExam.TabIndex = 60;
            this.btnExam.Text = "Exam";
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // BottomPan
            // 
            this.BottomPan.BackColor = System.Drawing.Color.Gray;
            this.BottomPan.Controls.Add(this.lblName);
            this.BottomPan.Controls.Add(this.lblLoggedInAs);
            this.BottomPan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPan.Location = new System.Drawing.Point(250, 746);
            this.BottomPan.Name = "BottomPan";
            this.BottomPan.Size = new System.Drawing.Size(986, 40);
            this.BottomPan.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Palatino Linotype", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblName.Location = new System.Drawing.Point(187, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(164, 40);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.BackColor = System.Drawing.Color.Transparent;
            this.lblLoggedInAs.Font = new System.Drawing.Font("Palatino Linotype", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInAs.ForeColor = System.Drawing.Color.Honeydew;
            this.lblLoggedInAs.Location = new System.Drawing.Point(0, 0);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(181, 40);
            this.lblLoggedInAs.TabIndex = 0;
            this.lblLoggedInAs.Text = "Logged in as :";
            this.lblLoggedInAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateTimer
            // 
            this.DateTimer.Enabled = true;
            this.DateTimer.Interval = 250;
            this.DateTimer.Tick += new System.EventHandler(this.DateTimer_Tick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.btnExit.BackgroundImage = global::Matrix_Academy.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1144, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 80);
            this.btnExit.TabIndex = 100;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ucAttendence
            // 
            this.ucAttendence.BackColor = System.Drawing.Color.Transparent;
            this.ucAttendence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucAttendence.BackgroundImage")));
            this.ucAttendence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucAttendence.Location = new System.Drawing.Point(250, 100);
            this.ucAttendence.Name = "ucAttendence";
            this.ucAttendence.Size = new System.Drawing.Size(985, 645);
            this.ucAttendence.TabIndex = 7;
            this.ucAttendence.Visible = false;
            // 
            // ucPayment
            // 
            this.ucPayment.BackColor = System.Drawing.Color.Transparent;
            this.ucPayment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucPayment.BackgroundImage")));
            this.ucPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucPayment.Location = new System.Drawing.Point(250, 100);
            this.ucPayment.Name = "ucPayment";
            this.ucPayment.Size = new System.Drawing.Size(985, 645);
            this.ucPayment.TabIndex = 6;
            this.ucPayment.Visible = false;
            // 
            // ucDashBoard
            // 
            this.ucDashBoard.BackColor = System.Drawing.Color.Transparent;
            this.ucDashBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucDashBoard.BackgroundImage")));
            this.ucDashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucDashBoard.Location = new System.Drawing.Point(250, 100);
            this.ucDashBoard.Name = "ucDashBoard";
            this.ucDashBoard.Size = new System.Drawing.Size(985, 645);
            this.ucDashBoard.TabIndex = 5;
            // 
            // ucStudent
            // 
            this.ucStudent.BackColor = System.Drawing.Color.Transparent;
            this.ucStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucStudent.BackgroundImage")));
            this.ucStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucStudent.Location = new System.Drawing.Point(250, 100);
            this.ucStudent.Name = "ucStudent";
            this.ucStudent.Size = new System.Drawing.Size(985, 645);
            this.ucStudent.TabIndex = 4;
            this.ucStudent.Visible = false;
            // 
            // ucTeacher
            // 
            this.ucTeacher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTeacher.BackgroundImage")));
            this.ucTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTeacher.Location = new System.Drawing.Point(250, 100);
            this.ucTeacher.Name = "ucTeacher";
            this.ucTeacher.Size = new System.Drawing.Size(985, 645);
            this.ucTeacher.TabIndex = 3;
            this.ucTeacher.Visible = false;
            // 
            // ucSettings
            // 
            this.ucSettings.BackColor = System.Drawing.Color.White;
            this.ucSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucSettings.BackgroundImage")));
            this.ucSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucSettings.Location = new System.Drawing.Point(250, 100);
            this.ucSettings.Name = "ucSettings";
            this.ucSettings.Size = new System.Drawing.Size(985, 645);
            this.ucSettings.TabIndex = 2;
            this.ucSettings.Visible = false;
            // 
            // ucLogOut
            // 
            this.ucLogOut.BackColor = System.Drawing.Color.White;
            this.ucLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucLogOut.BackgroundImage")));
            this.ucLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucLogOut.Location = new System.Drawing.Point(250, 100);
            this.ucLogOut.Name = "ucLogOut";
            this.ucLogOut.Size = new System.Drawing.Size(985, 645);
            this.ucLogOut.TabIndex = 1;
            this.ucLogOut.Visible = false;
            // 
            // ucSetUp
            // 
            this.ucSetUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucSetUp.BackgroundImage")));
            this.ucSetUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucSetUp.Location = new System.Drawing.Point(250, 100);
            this.ucSetUp.Name = "ucSetUp";
            this.ucSetUp.Size = new System.Drawing.Size(985, 645);
            this.ucSetUp.TabIndex = 8;
            this.ucSetUp.Visible = false;
            // 
            // FormDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1236, 786);
            this.Controls.Add(this.ucSetUp);
            this.Controls.Add(this.ucAttendence);
            this.Controls.Add(this.ucPayment);
            this.Controls.Add(this.ucDashBoard);
            this.Controls.Add(this.ucStudent);
            this.Controls.Add(this.ucTeacher);
            this.Controls.Add(this.ucSettings);
            this.Controls.Add(this.ucLogOut);
            this.Controls.Add(this.BottomPan);
            this.Controls.Add(this.LeftPan);
            this.Controls.Add(this.TopPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrix Academy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDashBoard_FormClosed);
            this.TopPan.ResumeLayout(false);
            this.LeftPan.ResumeLayout(false);
            this.BottomPan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPan;
        private System.Windows.Forms.Panel LeftPan;
        private System.Windows.Forms.Panel BottomPan;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer DateTimer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAttendence;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnSetUp;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStudnent;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLoggedInAs;
        private User_Control.UCLogOut ucLogOut;
        private User_Control.UCSettings ucSettings;
        private User_Control.UCTeacher ucTeacher;
        private User_Control.UCStudent ucStudent;
        private User_Control.UCDashBoard ucDashBoard;
        private User_Control.UCPayment ucPayment;
        private User_Control.UCAttendence ucAttendence;
        private User_Control.UCSetUp ucSetUp;
    }
}