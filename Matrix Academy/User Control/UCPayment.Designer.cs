namespace Matrix_Academy.User_Control
{
    partial class UCPayment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStudentPayment = new System.Windows.Forms.Button();
            this.btnTeacherPayment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStudentPayment
            // 
            this.btnStudentPayment.BackColor = System.Drawing.Color.Teal;
            this.btnStudentPayment.FlatAppearance.BorderSize = 0;
            this.btnStudentPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnStudentPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStudentPayment.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentPayment.ForeColor = System.Drawing.Color.White;
            this.btnStudentPayment.Location = new System.Drawing.Point(68, 209);
            this.btnStudentPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStudentPayment.Name = "btnStudentPayment";
            this.btnStudentPayment.Size = new System.Drawing.Size(146, 43);
            this.btnStudentPayment.TabIndex = 0;
            this.btnStudentPayment.Text = "Student";
            this.btnStudentPayment.UseVisualStyleBackColor = false;
            this.btnStudentPayment.Click += new System.EventHandler(this.btnStudentPayment_Click);
            // 
            // btnTeacherPayment
            // 
            this.btnTeacherPayment.BackColor = System.Drawing.Color.Peru;
            this.btnTeacherPayment.FlatAppearance.BorderSize = 0;
            this.btnTeacherPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnTeacherPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTeacherPayment.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherPayment.ForeColor = System.Drawing.Color.White;
            this.btnTeacherPayment.Location = new System.Drawing.Point(288, 209);
            this.btnTeacherPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTeacherPayment.Name = "btnTeacherPayment";
            this.btnTeacherPayment.Size = new System.Drawing.Size(130, 43);
            this.btnTeacherPayment.TabIndex = 0;
            this.btnTeacherPayment.Text = "Teacher";
            this.btnTeacherPayment.UseVisualStyleBackColor = false;
            this.btnTeacherPayment.Click += new System.EventHandler(this.btnTeacherPayment_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "A penny saved is a penny earned.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(281, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "~ George Herbert";
            // 
            // UCPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Matrix_Academy.Properties.Resources.Payment;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTeacherPayment);
            this.Controls.Add(this.btnStudentPayment);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCPayment";
            this.Size = new System.Drawing.Size(537, 349);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudentPayment;
        private System.Windows.Forms.Button btnTeacherPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
