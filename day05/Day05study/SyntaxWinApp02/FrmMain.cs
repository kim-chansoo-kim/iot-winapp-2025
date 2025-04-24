namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        int add(int x, int y)
        {
            return x + y; // ���� ¥��
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int result = add(10, 5);

            //       �븮��          =      ���ٽ�
            Func<int, int, int> add2 = (x, y) => x + y;
            TxtLog.Text += result + "\r\n";
            TxtLog.Text += add2(10, 6) + "\r\n";

            // Say
            Action<string> SayHello = name => MessageBox.Show($"�ȳ� {name}", "�λ�",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information); ;

            SayHello("����");

            // LINQ ��� ����
            List<int> resList = new List<int>();
            List<int> numbers = [4, 10, 1, 5, 9, 8, 6, 2, 3, 7];

            // ¦���� �����ؼ� �������� ���� �ϴ� ����
            foreach (int n in numbers)
            {
                if (n % 2 == 0) // 2�� ������ ������ 0�̸� ¦��
                {
                    resList.Add(n);
                }
            }

            TxtLog.Text += "���� ¦������Ʈ > " + string.Join(" ", resList) + "\r\n";

            resList.Sort();

            TxtLog.Text += "���� ���ĸ���Ʈ > " + string.Join(" ", resList) + "\r\n";

            // �⺻ LINQ��� > 3�ٷ� ���� �������� ó��
            numbers = [14, 20, 11, 15, 18, 19, 16, 13, 12, 17];
            var resList2 = from n in numbers
                          where n % 2 == 0
                          orderby n
                          select n;
            TxtLog.Text += "��ť ���ĸ���Ʈ > " + string.Join(" ", resList2) + "\r\n";

            // LINQ Method Chaining
            numbers = [24, 30, 21, 25, 28, 29, 26, 23, 22, 27];
            var resList3 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
            TxtLog.Text += "��ť2 ���ĸ���Ʈ > " + string.Join(" ", resList3) + "\r\n";
        }
    }
}
