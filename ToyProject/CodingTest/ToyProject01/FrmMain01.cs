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
            string food = TxtFood.Text;
            string calText = TxtCal.Text;
            string meal = CboMeal.SelectedItem?.ToString() ?? "";
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            string entry = $"[{date}] {meal} - {food} : {calText} kcal";
            RtbNote.AppendText(entry + Environment.NewLine);

            if (int.TryParse(calText, out int cal))
                totalCalories += cal;

            UpdateCalories();
            ClearInputs();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DlgSave.FileName = "diet.txt";
            DlgSave.Filter = "�ؽ�Ʈ ���� (*.txt)|*.txt";

            if (DlgSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(DlgSave.FileName, RtbNote.Text, Encoding.UTF8);
                    MessageBox.Show("������ ����Ǿ����ϴ�.", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    ShowError($"���� ����: {ex.Message}");
                }
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            DlgOpen.Filter = "�ؽ�Ʈ ���� (*.txt)|*.txt";

            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string content = File.ReadAllText(DlgOpen.FileName, Encoding.UTF8);
                    RtbNote.Text = content;
                    totalCalories = SumCalories(content);
                    UpdateCalories();
                }
                catch (Exception ex)
                {
                    ShowError($"�б� ����: {ex.Message}");
                }
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            RtbNote.Clear();
            totalCalories = 0;
            UpdateCalories();
        }

        private void UpdateCalories()
        {
            LblTotalCalories.Text = $"�� Į�θ�: {totalCalories} kcal";
        }

        private void ClearInputs()
        {
            TxtFood.Clear();
            TxtCal.Clear();
            CboMeal.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void ShowError(string msg)
        {
            MessageBox.Show(msg, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int SumCalories(string text)
        {
            int sum = 0;
            var lines = text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (var line in lines)
            {
                var parts = line.Split(':');
                if (parts.Length > 1 && int.TryParse(parts[1].Trim().Replace(" kcal", ""), out int cal))
                {
                    sum += cal;
                }
            }

            return sum;
        }
    }
}
