using System.Text;
using System.Windows.Forms;

namespace ToyProject01
{
    public partial class FrmMain01 : Form
    {
        private int totalCalories = 0;
        public FrmMain01()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Step 1. 입력값 가져오기
            string food = TxtFood.Text;
            string calories = TxtCal.Text;
            string mealType = CboMeal.SelectedItem?.ToString() ?? "";
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd"); // 날짜만 가져옴

            // Step 2. 리치텍스트박스에 내용 추가
            string newEntry = $"[{date}] {mealType} - {food} : {calories} kcal";
            RtbNote.AppendText(newEntry + Environment.NewLine);

            // Step 3. 총 칼로리 합산
            if (int.TryParse(calories, out int calorieValue))
            {
                totalCalories += calorieValue;
            }

            // Step 4. 총 칼로리 업데이트
            UpdateTotalCalories();

            // Step 5. 입력 필드 초기화
            ResetInputs();
        }

        private void UpdateTotalCalories()
        {
            // 총 칼로리를 라벨에 표시
            LblTotalCalories.Text = $"총 칼로리: {totalCalories} kcal";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DlgSave.FileName = "diet.txt";
            DlgSave.Filter = "텍스트 파일 (*.txt)|*.txt";
            DlgSave.Title = "문서파일 저장";

            if (DlgSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var fullPath = DlgSave.FileName;
                    var contentToSave = RtbNote.Text;
                    File.WriteAllText(fullPath, contentToSave, Encoding.UTF8);

                    MessageBox.Show("파일이 저장되었습니다.", "파일저장",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    ShowError($"저장 실패 : {ex.Message}");
                }
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            DlgOpen.FileName = string.Empty;
            DlgOpen.Filter = "Txt파일 (*.txt)|*.txt";
            DlgOpen.Title = "문서파일 읽기";

            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var fullPath = DlgOpen.FileName;
                    var fileContent = File.ReadAllText(fullPath, Encoding.UTF8);
                    RtbNote.Text = fileContent;

                    totalCalories = CalculateTotalCalories(fileContent);
                    UpdateTotalCalories();
                }
                catch (Exception ex)
                {
                    ShowError($"읽기 실패 : {ex.Message}");
                }
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            RtbNote.Clear();
            totalCalories = 0;
            UpdateTotalCalories();
        }

        private void ResetInputs()
        {
            TxtFood.Clear();
            TxtCal.Clear();
            CboMeal.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int CalculateTotalCalories(string content)
        {
            int total = 0;
            var lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (var line in lines)
            {
                var parts = line.Split(new[] { ':' }, StringSplitOptions.None);
                if (parts.Length > 1)
                {
                    var calorieText = parts[1].Trim().Replace(" kcal", "");
                    if (int.TryParse(calorieText, out int calorie))
                    {
                        total += calorie;
                    }
                }
            }

            return total;
        }
    }
}
