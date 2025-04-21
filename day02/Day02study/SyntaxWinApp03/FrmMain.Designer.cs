namespace SyntaxWinApp03
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
            Btnmsg = new Button();
            LblPain = new Label();
            TxtPain = new TextBox();
            LblPainPoint = new Label();
            CboPainPoint = new ComboBox();
            BtnDisPlay = new Button();
            TxtResult = new TextBox();
            BtnWhile = new Button();
            SuspendLayout();
            // 
            // Btnmsg
            // 
            Btnmsg.BackColor = Color.IndianRed;
            Btnmsg.Location = new Point(459, 259);
            Btnmsg.Name = "Btnmsg";
            Btnmsg.Size = new Size(100, 40);
            Btnmsg.TabIndex = 5;
            Btnmsg.Text = "메시지";
            Btnmsg.UseVisualStyleBackColor = false;
            Btnmsg.Click += Btnmsg_Click;
            // 
            // LblPain
            // 
            LblPain.AutoSize = true;
            LblPain.Location = new Point(21, 13);
            LblPain.Name = "LblPain";
            LblPain.Size = new Size(64, 15);
            LblPain.TabIndex = 1;
            LblPain.Text = "통증여부 -";
            // 
            // TxtPain
            // 
            TxtPain.Location = new Point(91, 10);
            TxtPain.MaxLength = 3;
            TxtPain.Name = "TxtPain";
            TxtPain.PlaceholderText = "네 또는 아니오";
            TxtPain.Size = new Size(100, 23);
            TxtPain.TabIndex = 1;
            TxtPain.KeyPress += TxtPain_KeyPress;
            // 
            // LblPainPoint
            // 
            LblPainPoint.AutoSize = true;
            LblPainPoint.Location = new Point(21, 40);
            LblPainPoint.Name = "LblPainPoint";
            LblPainPoint.Size = new Size(64, 15);
            LblPainPoint.TabIndex = 3;
            LblPainPoint.Text = "통증부위 -";
            // 
            // CboPainPoint
            // 
            CboPainPoint.FormattingEnabled = true;
            CboPainPoint.Items.AddRange(new object[] { "머리", "눈", "코", "목", "가슴", "배" });
            CboPainPoint.Location = new Point(91, 37);
            CboPainPoint.Name = "CboPainPoint";
            CboPainPoint.Size = new Size(121, 23);
            CboPainPoint.TabIndex = 2;
            CboPainPoint.Text = "부위선택";
            CboPainPoint.SelectedIndexChanged += CboPainPoint_SelectedIndexChanged;
            // 
            // BtnDisPlay
            // 
            BtnDisPlay.BackColor = Color.Gold;
            BtnDisPlay.Location = new Point(353, 259);
            BtnDisPlay.Name = "BtnDisPlay";
            BtnDisPlay.Size = new Size(100, 40);
            BtnDisPlay.TabIndex = 4;
            BtnDisPlay.Text = "구구단";
            BtnDisPlay.UseVisualStyleBackColor = false;
            BtnDisPlay.Click += BtnDisPlay_Click;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(12, 66);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(560, 180);
            TxtResult.TabIndex = 6;
            // 
            // BtnWhile
            // 
            BtnWhile.BackColor = SystemColors.ActiveCaption;
            BtnWhile.Location = new Point(247, 259);
            BtnWhile.Name = "BtnWhile";
            BtnWhile.Size = new Size(100, 40);
            BtnWhile.TabIndex = 3;
            BtnWhile.Text = "반복";
            BtnWhile.UseVisualStyleBackColor = false;
            BtnWhile.Click += BtnWhile_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(BtnWhile);
            Controls.Add(TxtResult);
            Controls.Add(BtnDisPlay);
            Controls.Add(CboPainPoint);
            Controls.Add(LblPainPoint);
            Controls.Add(TxtPain);
            Controls.Add(LblPain);
            Controls.Add(Btnmsg);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "문법학습 윈앱 03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btnmsg;
        private Label LblPain;
        private TextBox TxtPain;
        private Label LblPainPoint;
        private ComboBox CboPainPoint;
        private Button BtnDisPlay;
        private TextBox TxtResult;
        private Button BtnWhile;
    }
}
