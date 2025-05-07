namespace ToyProject01
{
    partial class FrmMain01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain01));
            LblFood = new Label();
            TxtFood = new TextBox();
            LblCal = new Label();
            TxtCal = new TextBox();
            LblMeal = new Label();
            CboMeal = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            BtnAdd = new Button();
            BtnDel = new Button();
            RtbNote = new RichTextBox();
            BtnLoad = new Button();
            DlgOpen = new OpenFileDialog();
            DlgSave = new SaveFileDialog();
            BtnSave = new Button();
            LblTotalCalories = new Label();
            SuspendLayout();
            // 
            // LblFood
            // 
            LblFood.AutoSize = true;
            LblFood.Location = new Point(9, 19);
            LblFood.Name = "LblFood";
            LblFood.Size = new Size(50, 15);
            LblFood.TabIndex = 0;
            LblFood.Text = "음식명 :";
            // 
            // TxtFood
            // 
            TxtFood.Location = new Point(65, 16);
            TxtFood.Name = "TxtFood";
            TxtFood.Size = new Size(100, 23);
            TxtFood.TabIndex = 1;
            // 
            // LblCal
            // 
            LblCal.AutoSize = true;
            LblCal.Location = new Point(171, 19);
            LblCal.Name = "LblCal";
            LblCal.Size = new Size(50, 15);
            LblCal.TabIndex = 0;
            LblCal.Text = "칼로리 :";
            // 
            // TxtCal
            // 
            TxtCal.Location = new Point(227, 16);
            TxtCal.Name = "TxtCal";
            TxtCal.Size = new Size(100, 23);
            TxtCal.TabIndex = 2;
            // 
            // LblMeal
            // 
            LblMeal.AutoSize = true;
            LblMeal.Location = new Point(341, 19);
            LblMeal.Name = "LblMeal";
            LblMeal.Size = new Size(55, 15);
            LblMeal.TabIndex = 0;
            LblMeal.Text = "식사종류";
            // 
            // CboMeal
            // 
            CboMeal.FormattingEnabled = true;
            CboMeal.Items.AddRange(new object[] { "아침", "점심", "저녁", "간식" });
            CboMeal.Location = new Point(402, 16);
            CboMeal.Name = "CboMeal";
            CboMeal.Size = new Size(60, 23);
            CboMeal.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(477, 16);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(697, 16);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 23);
            BtnAdd.TabIndex = 5;
            BtnAdd.Text = "추가";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnDel
            // 
            BtnDel.Location = new Point(697, 412);
            BtnDel.Name = "BtnDel";
            BtnDel.Size = new Size(75, 23);
            BtnDel.TabIndex = 8;
            BtnDel.Text = "삭제";
            BtnDel.UseVisualStyleBackColor = true;
            BtnDel.Click += BtnDel_Click;
            // 
            // RtbNote
            // 
            RtbNote.Font = new Font("나눔고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            RtbNote.Location = new Point(12, 74);
            RtbNote.Name = "RtbNote";
            RtbNote.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            RtbNote.Size = new Size(760, 332);
            RtbNote.TabIndex = 6;
            RtbNote.Text = "";
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(616, 412);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(75, 23);
            BtnLoad.TabIndex = 7;
            BtnLoad.Text = "읽기";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // DlgOpen
            // 
            DlgOpen.FileName = "openFileDialog1";
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(535, 412);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 23);
            BtnSave.TabIndex = 6;
            BtnSave.Text = "저장";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // LblTotalCalories
            // 
            LblTotalCalories.AutoSize = true;
            LblTotalCalories.Location = new Point(12, 420);
            LblTotalCalories.Name = "LblTotalCalories";
            LblTotalCalories.Size = new Size(67, 15);
            LblTotalCalories.TabIndex = 7;
            LblTotalCalories.Text = "칼로리총합";
            // 
            // FrmMain01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(784, 461);
            Controls.Add(LblTotalCalories);
            Controls.Add(RtbNote);
            Controls.Add(BtnDel);
            Controls.Add(BtnLoad);
            Controls.Add(BtnSave);
            Controls.Add(BtnAdd);
            Controls.Add(dateTimePicker1);
            Controls.Add(CboMeal);
            Controls.Add(TxtCal);
            Controls.Add(LblMeal);
            Controls.Add(LblCal);
            Controls.Add(TxtFood);
            Controls.Add(LblFood);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmMain01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "식단/칼로리 관리 프로그램";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblFood;
        private TextBox TxtFood;
        private Label LblCal;
        private TextBox TxtCal;
        private Label LblMeal;
        private ComboBox CboMeal;
        private DateTimePicker dateTimePicker1;
        private Button BtnAdd;
        private Button BtnDel;
        private RichTextBox RtbNote;
        private Button BtnLoad;
        private OpenFileDialog DlgOpen;
        private SaveFileDialog DlgSave;
        private Button BtnSave;
        private Label LblTotalCalories;
    }
}
