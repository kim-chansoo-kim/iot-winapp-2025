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
            // 기본생성자
            Person pong = new Person();
            pong.Name = TxtName.Text.Trim();
            pong.Age = int.Parse(TxtAge.Text.Trim());
            pong.Gender = char.Parse(TxtGender.Text.Trim());
            pong.Phone = TxtPhone.Text.Trim();

            // 매개변수 생성자
            Person ashely = new Person("애슐리", 42, 'F', "010-2345-5468");

            TxtResult.Text += pong.ToString();
            pong.Getup();
            pong.GoToSchool();

            // static인 경우는 객체를 생성하지 않음
            Person.GetNumber();
        }
    }
}
