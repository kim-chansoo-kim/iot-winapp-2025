namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // �⺻������
            Person pong = new Person();
            pong.Name = TxtName.Text.Trim();
            pong.Age = int.Parse(TxtAge.Text.Trim());
            pong.Gender = char.Parse(TxtGender.Text.Trim());
            pong.Phone = TxtPhone.Text.Trim();

            // �Ű����� ������
            Person ashely = new Person("�ֽ���", 42, 'F', "010-2345-5468");

            TxtResult.Text += pong.ToString();
            pong.Getup();
            pong.GoToSchool();

            // static�� ���� ��ü�� �������� ����
            Person.GetNumber();
        }
    }
}
