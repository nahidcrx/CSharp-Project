namespace Matrix_Academy.Forms
{
    partial class FormAddTeacher
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
            this.emlpoyee = new System.Windows.Forms.Panel();
            this.txtPayment = new System.Windows.Forms.MaskedTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.joinDate = new System.Windows.Forms.DateTimePicker();
            this.religion = new System.Windows.Forms.ComboBox();
            this.bloodGroup = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emlpoyee.SuspendLayout();
            this.SuspendLayout();
            // 
            // emlpoyee
            // 
            this.emlpoyee.Controls.Add(this.txtPayment);
            this.emlpoyee.Controls.Add(this.btnSubmit);
            this.emlpoyee.Controls.Add(this.btnCancel);
            this.emlpoyee.Controls.Add(this.joinDate);
            this.emlpoyee.Controls.Add(this.religion);
            this.emlpoyee.Controls.Add(this.bloodGroup);
            this.emlpoyee.Controls.Add(this.txtAddress);
            this.emlpoyee.Controls.Add(this.txtDesignation);
            this.emlpoyee.Controls.Add(this.txtContactNo);
            this.emlpoyee.Controls.Add(this.txtMail);
            this.emlpoyee.Controls.Add(this.txtName);
            this.emlpoyee.Controls.Add(this.label11);
            this.emlpoyee.Controls.Add(this.label10);
            this.emlpoyee.Controls.Add(this.label9);
            this.emlpoyee.Controls.Add(this.label8);
            this.emlpoyee.Controls.Add(this.label7);
            this.emlpoyee.Controls.Add(this.label6);
            this.emlpoyee.Controls.Add(this.label4);
            this.emlpoyee.Controls.Add(this.label3);
            this.emlpoyee.Controls.Add(this.label2);
            this.emlpoyee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.emlpoyee.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emlpoyee.Location = new System.Drawing.Point(0, 53);
            this.emlpoyee.Name = "emlpoyee";
            this.emlpoyee.Size = new System.Drawing.Size(1186, 693);
            this.emlpoyee.TabIndex = 3;
            // 
            // txtPayment
            // 
            this.txtPayment.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPayment.Location = new System.Drawing.Point(230, 551);
            this.txtPayment.Mask = "00000";
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(261, 45);
            this.txtPayment.TabIndex = 9;
            this.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPayment.ValidatingType = typeof(int);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSubmit.Location = new System.Drawing.Point(639, 574);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(252, 54);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(928, 574);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 54);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // joinDate
            // 
            this.joinDate.CustomFormat = "";
            this.joinDate.Location = new System.Drawing.Point(230, 441);
            this.joinDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.joinDate.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.joinDate.Name = "joinDate";
            this.joinDate.Size = new System.Drawing.Size(474, 45);
            this.joinDate.TabIndex = 7;
            this.joinDate.Value = new System.DateTime(2017, 12, 23, 0, 0, 0, 0);
            // 
            // religion
            // 
            this.religion.BackColor = System.Drawing.SystemColors.Info;
            this.religion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.religion.FormattingEnabled = true;
            this.religion.ItemHeight = 38;
            this.religion.Items.AddRange(new object[] {
            "Islam",
            "Hinduism",
            "Christianity",
            "Buddhism"});
            this.religion.Location = new System.Drawing.Point(230, 251);
            this.religion.Name = "religion";
            this.religion.Size = new System.Drawing.Size(229, 46);
            this.religion.TabIndex = 5;
            // 
            // bloodGroup
            // 
            this.bloodGroup.BackColor = System.Drawing.SystemColors.Info;
            this.bloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bloodGroup.FormattingEnabled = true;
            this.bloodGroup.ItemHeight = 38;
            this.bloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.bloodGroup.Location = new System.Drawing.Point(230, 195);
            this.bloodGroup.Name = "bloodGroup";
            this.bloodGroup.Size = new System.Drawing.Size(229, 46);
            this.bloodGroup.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(230, 307);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(420, 124);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(230, 496);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(261, 45);
            this.txtDesignation.TabIndex = 8;
            this.txtDesignation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(230, 140);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(420, 45);
            this.txtContactNo.TabIndex = 3;
            this.txtContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(230, 85);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(420, 45);
            this.txtMail.TabIndex = 2;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Location = new System.Drawing.Point(230, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(420, 45);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 558);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 38);
            this.label11.TabIndex = 9;
            this.label11.Text = "Pay/Class :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 503);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 38);
            this.label10.TabIndex = 8;
            this.label10.Text = "Designation :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 38);
            this.label9.TabIndex = 7;
            this.label9.Text = "Joining Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 38);
            this.label8.TabIndex = 6;
            this.label8.Text = "Address :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 38);
            this.label7.TabIndex = 5;
            this.label7.Text = "Religion :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 38);
            this.label6.TabIndex = 4;
            this.label6.Text = "Blood Group :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contact No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1186, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Teacher";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1186, 746);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emlpoyee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddTeacher";
            this.emlpoyee.ResumeLayout(false);
            this.emlpoyee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel emlpoyee;
        private System.Windows.Forms.MaskedTextBox txtPayment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker joinDate;
        private System.Windows.Forms.ComboBox religion;
        private System.Windows.Forms.ComboBox bloodGroup;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}