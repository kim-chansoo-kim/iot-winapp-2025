namespace SyntaxWinApp04
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtAge.Text == "")
            {
                MessageBox.Show("���� ä���ּ���.");
                return; // �޼��� Ż��
            }else
            {
                // ���� ������ ������ ����...
                LblResult.Text = "ó����� : ";
                TxtResult.Text = "���� ó���� ���� �Ƹ���?";

                string name = TxtName.Text.Trim(); // Trim() : �յ� ������ ����
                // �Ľ�(Parse) -> �м��ؼ� �� ��ȯ
                DateTime birthday = DateTime.Parse(TxtAge.Text.Trim());
                int age = DateTime.Now.Year - birthday.Year;
                // 3�׽� �б�
                string gender = RdoMale.Checked ? "��" : "��";

                // ���� ��� ���ڿ� ������
                TxtResult.Text = "���� " + name + "�̰�, " + birthday + "�� �¾ " + age + "�� " +  gender + "�� �Դϴ�.";
                // �ʽ� ��� ���ڿ� ������ $""
                TxtResult.Text = $"���� {name}�̰�, {birthday: yyyy-MM-dd}�� �¾ {age:F2}�� {gender}�� �Դϴ�!!";
            }
        }
    }
}
