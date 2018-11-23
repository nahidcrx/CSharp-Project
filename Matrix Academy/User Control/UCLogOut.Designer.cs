namespace Matrix_Academy.User_Control
{
    partial class UCLogOut
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnLO = new System.Windows.Forms.Button();
            this.btnLOE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(0, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 403);
            this.label2.TabIndex = 2;
            this.label2.Text = "Do you really want to Log Out??";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLO
            // 
            this.btnLO.BackColor = System.Drawing.Color.Maroon;
            this.btnLO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLO.Font = new System.Drawing.Font("Palatino Linotype", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLO.ForeColor = System.Drawing.Color.White;
            this.btnLO.Location = new System.Drawing.Point(522, 392);
            this.btnLO.Name = "btnLO";
            this.btnLO.Size = new System.Drawing.Size(329, 76);
            this.btnLO.TabIndex = 91;
            this.btnLO.Text = "LogOut";
            this.btnLO.UseVisualStyleBackColor = false;
            this.btnLO.Click += new System.EventHandler(this.btnLO_Click);
            // 
            // btnLOE
            // 
            this.btnLOE.BackColor = System.Drawing.Color.Maroon;
            this.btnLOE.FlatAppearance.BorderSize = 0;
            this.btnLOE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLOE.Font = new System.Drawing.Font("Palatino Linotype", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOE.ForeColor = System.Drawing.Color.White;
            this.btnLOE.Location = new System.Drawing.Point(522, 500);
            this.btnLOE.Name = "btnLOE";
            this.btnLOE.Size = new System.Drawing.Size(329, 76);
            this.btnLOE.TabIndex = 92;
            this.btnLOE.Text = "LogOut and Exit";
            this.btnLOE.UseVisualStyleBackColor = false;
            this.btnLOE.Click += new System.EventHandler(this.btnLOE_Click);
            // 
            // UCLogOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Matrix_Academy.Properties.Resources.LogOut_Exit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnLOE);
            this.Controls.Add(this.btnLO);
            this.Controls.Add(this.label2);
            this.Name = "UCLogOut";
            this.Size = new System.Drawing.Size(985, 645);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLO;
        private System.Windows.Forms.Button btnLOE;
    }
}
