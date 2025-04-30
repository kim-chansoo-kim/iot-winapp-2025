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
            // Step 1. �Է°� ��������
            string food = TxtFood.Text;
            string calories = TxtCal.Text;
            string mealType = CboMeal.SelectedItem?.ToString() ?? "";
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd"); // ��¥�� ������

            // Step 2. ��ġ�ؽ�Ʈ�ڽ��� ���� �߰�
            string newEntry = $"[{date}] {mealType} - {food} : {calories} kcal";
            RtbNote.AppendText(newEntry + Environment.NewLine);

            // Step 3. �� Į�θ� �ջ�
            if (int.TryParse(calories, out int calorieValue))
            {
                totalCalories += calorieValue;
            }

            // Step 4. �� Į�θ� ������Ʈ
            UpdateTotalCalories();

            // Step 5. �Է� �ʵ� �ʱ�ȭ
            ResetInputs();
        }

        private void UpdateTotalCalories()
        {
            // �� Į�θ��� �󺧿� ǥ��
            LblTotalCalories.Text = $"�� Į�θ�: {totalCalories} kcal";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DlgSave.FileName = "diet.txt";
            DlgSave.Filter = "�ؽ�Ʈ ���� (*.txt)|*.txt";
            DlgSave.Title = "�������� ����";

            if (DlgSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var fullPath = DlgSave.FileName;
                    var contentToSave = RtbNote.Text;
                    File.WriteAllText(fullPath, contentToSave, Encoding.UTF8);

                    MessageBox.Show("������ ����Ǿ����ϴ�.", "��������",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    ShowError($"���� ���� : {ex.Message}");
                }
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            DlgOpen.FileName = string.Empty;
            DlgOpen.Filter = "Txt���� (*.txt)|*.txt";
            DlgOpen.Title = "�������� �б�";

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
                    ShowError($"�б� ���� : {ex.Message}");
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
            MessageBox.Show(message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
