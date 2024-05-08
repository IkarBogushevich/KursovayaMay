namespace BogushevichKurs
{
    partial class Auth
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
            AuthLog = new TextBox();
            AuthPwd = new TextBox();
            MakeAuth = new Button();
            GoReg = new Button();
            SuspendLayout();
            // 
            // AuthLog
            // 
            AuthLog.Location = new Point(72, 12);
            AuthLog.Name = "AuthLog";
            AuthLog.PlaceholderText = "Login";
            AuthLog.Size = new Size(328, 23);
            AuthLog.TabIndex = 0;
            // 
            // AuthPwd
            // 
            AuthPwd.Location = new Point(72, 51);
            AuthPwd.Name = "AuthPwd";
            AuthPwd.PasswordChar = '*';
            AuthPwd.PlaceholderText = "Password";
            AuthPwd.Size = new Size(328, 23);
            AuthPwd.TabIndex = 1;
            // 
            // MakeAuth
            // 
            MakeAuth.Location = new Point(189, 89);
            MakeAuth.Name = "MakeAuth";
            MakeAuth.Size = new Size(95, 23);
            MakeAuth.TabIndex = 2;
            MakeAuth.Text = "Авторизация";
            MakeAuth.UseVisualStyleBackColor = true;
            MakeAuth.Click += MakeAuth_Click;
            // 
            // GoReg
            // 
            GoReg.Location = new Point(304, 89);
            GoReg.Name = "GoReg";
            GoReg.Size = new Size(96, 23);
            GoReg.TabIndex = 3;
            GoReg.Text = "Регистрация";
            GoReg.UseVisualStyleBackColor = true;
            GoReg.Click += GoReg_Click;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 195);
            Controls.Add(GoReg);
            Controls.Add(MakeAuth);
            Controls.Add(AuthPwd);
            Controls.Add(AuthLog);
            Name = "Auth";
            Text = "Auth";
            FormClosed += Auth_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AuthLog;
        private TextBox AuthPwd;
        private Button MakeAuth;
        private Button GoReg;
    }
}