namespace SyntaxWinApp02
{
    partial class FrmMain
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
            Btnmasg = new Button();
            SuspendLayout();
            // 
            // Btnmasg
            // 
            Btnmasg.ForeColor = Color.IndianRed;
            Btnmasg.Location = new Point(472, 259);
            Btnmasg.Name = "Btnmasg";
            Btnmasg.Size = new Size(100, 40);
            Btnmasg.TabIndex = 0;
            Btnmasg.Text = "메시지";
            Btnmasg.UseVisualStyleBackColor = true;
            Btnmasg.Click += Btnmasg_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(Btnmasg);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "문법학습 윈앱 02";
            ResumeLayout(false);
        }

        #endregion

        private Button Btnmasg;
    }
}
