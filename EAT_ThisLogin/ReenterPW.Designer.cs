namespace EAT_ThisLogin
{
    partial class ReenterPW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReenterPW));
            this.txtPasswordRelog = new System.Windows.Forms.TextBox();
            this.ButEnterPw = new System.Windows.Forms.Button();
            this.xlabel = new System.Windows.Forms.Label();
            this.LbNotice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPasswordRelog
            // 
            this.txtPasswordRelog.Location = new System.Drawing.Point(106, 85);
            this.txtPasswordRelog.Margin = new System.Windows.Forms.Padding(6);
            this.txtPasswordRelog.Name = "txtPasswordRelog";
            this.txtPasswordRelog.PasswordChar = '*';
            this.txtPasswordRelog.Size = new System.Drawing.Size(196, 31);
            this.txtPasswordRelog.TabIndex = 0;
            // 
            // ButEnterPw
            // 
            this.ButEnterPw.BackColor = System.Drawing.Color.Transparent;
            this.ButEnterPw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButEnterPw.BackgroundImage")));
            this.ButEnterPw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButEnterPw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButEnterPw.ForeColor = System.Drawing.Color.Transparent;
            this.ButEnterPw.Location = new System.Drawing.Point(126, 138);
            this.ButEnterPw.Margin = new System.Windows.Forms.Padding(6);
            this.ButEnterPw.Name = "ButEnterPw";
            this.ButEnterPw.Size = new System.Drawing.Size(146, 121);
            this.ButEnterPw.TabIndex = 1;
            this.ButEnterPw.UseVisualStyleBackColor = false;
            this.ButEnterPw.Click += new System.EventHandler(this.ButEnterPw_Click);
            // 
            // xlabel
            // 
            this.xlabel.AutoSize = true;
            this.xlabel.BackColor = System.Drawing.Color.Transparent;
            this.xlabel.Location = new System.Drawing.Point(74, 17);
            this.xlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(279, 25);
            this.xlabel.TabIndex = 2;
            this.xlabel.Text = "Please enter your password";
            // 
            // LbNotice
            // 
            this.LbNotice.AutoSize = true;
            this.LbNotice.BackColor = System.Drawing.Color.Transparent;
            this.LbNotice.Location = new System.Drawing.Point(24, 285);
            this.LbNotice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LbNotice.Name = "LbNotice";
            this.LbNotice.Size = new System.Drawing.Size(23, 25);
            this.LbNotice.TabIndex = 3;
            this.LbNotice.Text = "x";
            // 
            // ReenterPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(472, 377);
            this.Controls.Add(this.LbNotice);
            this.Controls.Add(this.xlabel);
            this.Controls.Add(this.ButEnterPw);
            this.Controls.Add(this.txtPasswordRelog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ReenterPW";
            this.Text = "Eat This";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasswordRelog;
        private System.Windows.Forms.Button ButEnterPw;
        private System.Windows.Forms.Label xlabel;
        private System.Windows.Forms.Label LbNotice;
    }
}