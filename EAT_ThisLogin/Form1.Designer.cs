namespace EAT_ThisLogin
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.BUT_Enter = new System.Windows.Forms.Button();
            this.LB_UserName = new System.Windows.Forms.Label();
            this.Lb_Password = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(552, 515);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(212, 31);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(552, 594);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(212, 31);
            this.txtPassword.TabIndex = 1;
            // 
            // BUT_Enter
            // 
            this.BUT_Enter.AutoSize = true;
            this.BUT_Enter.BackColor = System.Drawing.Color.Transparent;
            this.BUT_Enter.Cursor = System.Windows.Forms.Cursors.Default;
            this.BUT_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUT_Enter.ForeColor = System.Drawing.Color.Transparent;
            this.BUT_Enter.Image = ((System.Drawing.Image)(resources.GetObject("BUT_Enter.Image")));
            this.BUT_Enter.Location = new System.Drawing.Point(870, 515);
            this.BUT_Enter.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_Enter.Name = "BUT_Enter";
            this.BUT_Enter.Size = new System.Drawing.Size(98, 98);
            this.BUT_Enter.TabIndex = 2;
            this.BUT_Enter.UseVisualStyleBackColor = false;
            this.BUT_Enter.Click += new System.EventHandler(this.BUT_Enter_Click);
            // 
            // LB_UserName
            // 
            this.LB_UserName.AutoSize = true;
            this.LB_UserName.BackColor = System.Drawing.Color.Transparent;
            this.LB_UserName.ForeColor = System.Drawing.Color.Green;
            this.LB_UserName.Location = new System.Drawing.Point(336, 515);
            this.LB_UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_UserName.Name = "LB_UserName";
            this.LB_UserName.Size = new System.Drawing.Size(110, 25);
            this.LB_UserName.TabIndex = 3;
            this.LB_UserName.Text = "Username";
            // 
            // Lb_Password
            // 
            this.Lb_Password.AutoSize = true;
            this.Lb_Password.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Password.ForeColor = System.Drawing.Color.Green;
            this.Lb_Password.Location = new System.Drawing.Point(340, 596);
            this.Lb_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Password.Name = "Lb_Password";
            this.Lb_Password.Size = new System.Drawing.Size(106, 25);
            this.Lb_Password.TabIndex = 4;
            this.Lb_Password.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1268, 323);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(552, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 323);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-34, 313);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1348, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1268, 767);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BUT_Enter);
            this.Controls.Add(this.LB_UserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Lb_Password);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogInForm";
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button BUT_Enter;
        private System.Windows.Forms.Label LB_UserName;
        private System.Windows.Forms.Label Lb_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

