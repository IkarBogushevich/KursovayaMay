namespace BogushevichKurs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MakeDis = new Button();
            Input = new TextBox();
            Output = new Label();
            SuspendLayout();
            // 
            // MakeDis
            // 
            MakeDis.Location = new Point(179, 164);
            MakeDis.Name = "MakeDis";
            MakeDis.Size = new Size(207, 40);
            MakeDis.TabIndex = 0;
            MakeDis.Text = "Шифруй";
            MakeDis.UseVisualStyleBackColor = true;
            MakeDis.Click += button1_Click;
            // 
            // Input
            // 
            Input.Location = new Point(95, 41);
            Input.Name = "Input";
            Input.Size = new Size(368, 23);
            Input.TabIndex = 1;
            Input.TextChanged += textBox1_TextChanged;
            // 
            // Output
            // 
            Output.AutoSize = true;
            Output.Location = new Point(225, 101);
            Output.Name = "Output";
            Output.Size = new Size(113, 15);
            Output.TabIndex = 2;
            Output.Text = "Тут будет результат";
            Output.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 278);
            Controls.Add(Output);
            Controls.Add(Input);
            Controls.Add(MakeDis);
            Name = "Form1";
            Text = "ШИФРУЙ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MakeDis;
        private TextBox Input;
        private Label Output;
    }
}
