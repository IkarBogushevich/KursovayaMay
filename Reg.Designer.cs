namespace BogushevichKurs
{
    partial class Reg
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
            RegLogin = new TextBox();
            regPwd = new TextBox();
            MakeReg = new Button();
            SuspendLayout();
            // 
            // RegLogin
            // 
            RegLogin.Location = new Point(127, 47);
            RegLogin.Name = "RegLogin";
            RegLogin.Size = new Size(200, 23);
            RegLogin.TabIndex = 0;
            // 
            // regPwd
            // 
            regPwd.Location = new Point(127, 94);
            regPwd.Name = "regPwd";
            regPwd.Size = new Size(200, 23);
            regPwd.TabIndex = 1;
            // 
            // MakeReg
            // 
            MakeReg.Location = new Point(148, 142);
            MakeReg.Name = "MakeReg";
            MakeReg.Size = new Size(159, 23);
            MakeReg.TabIndex = 2;
            MakeReg.Text = "Зарегистрироваться";
            MakeReg.UseVisualStyleBackColor = true;
            MakeReg.Click += MakeReg_Click;
            // 
            // Reg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 292);
            Controls.Add(MakeReg);
            Controls.Add(regPwd);
            Controls.Add(RegLogin);
            Name = "Reg";
            Text = "Reg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RegLogin;
        private TextBox regPwd;
        private Button MakeReg;
    }
}