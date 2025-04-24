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
            return x + y; // 한줄 짜리
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int result = add(10, 5);

            //       대리자          =      람다식
            Func<int, int, int> add2 = (x, y) => x + y;
            TxtLog.Text += result + "\r\n";
            TxtLog.Text += add2(10, 6) + "\r\n";

            // Say
            Action<string> SayHello = name => MessageBox.Show($"안녕 {name}", "인사",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information); ;

            SayHello("퐁당");

            // LINQ 사용 이전
            List<int> resList = new List<int>();
            List<int> numbers = [4, 10, 1, 5, 9, 8, 6, 2, 3, 7];

            // 짝수만 추출해서 오름차순 정렬 하는 로직
            foreach (int n in numbers)
            {
                if (n % 2 == 0) // 2로 나눠서 나머지 0이면 짝수
                {
                    resList.Add(n);
                }
            }

            TxtLog.Text += "전통 짝수리스트 > " + string.Join(" ", resList) + "\r\n";

            resList.Sort();

            TxtLog.Text += "전통 정렬리스트 > " + string.Join(" ", resList) + "\r\n";

            // 기본 LINQ방식 > 3줄로 위의 전통방식을 처리
            numbers = [14, 20, 11, 15, 18, 19, 16, 13, 12, 17];
            var resList2 = from n in numbers
                          where n % 2 == 0
                          orderby n
                          select n;
            TxtLog.Text += "링큐 정렬리스트 > " + string.Join(" ", resList2) + "\r\n";

            // LINQ Method Chaining
            numbers = [24, 30, 21, 25, 28, 29, 26, 23, 22, 27];
            var resList3 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
            TxtLog.Text += "링큐2 정렬리스트 > " + string.Join(" ", resList3) + "\r\n";
        }
    }
}
