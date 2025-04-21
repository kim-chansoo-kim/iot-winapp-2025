using System.Windows.Forms.Design;

namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        // var int09 = 10; // var는 전역변수 사용 불가

        public FrmMain()
        {
            InitializeComponent();
        }
        private void BtnMsg_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("메시지", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // 정수형 자료형
            sbyte sbtVal = 127;        // singed byte : - 128 ~ 127 수를 저장
            System.SByte sbtVal2 = System.SByte.MinValue;                   // -128 할당
            byte btVal = 255;           // byte : 0 ~ 255 수를 저장(1 byte)
            System.Byte btVal2 = System.Byte.MinValue;                      // 0 할당
            short stVal = 32767;        // short : -32768 ~ 32767 수를 저장
            System.Int16 stVal2 = System.Int16.MinValue;                    // -32768 할당
            ushort ustVal = 65535;      // unsinged short : 0 ~ 65535 저장(2 bytes)
            System.UInt16 ustVal2 = System.UInt16.MinValue;                 // 0 할당
            int intVal = 2147483647;    // int -21억 ~ 21억 (4 bytes)
            System.Int32 intVal2 = System.Int32.MinValue;                   // - 21억할당
            uint uintVal = 4294967295;  // unsinged int : 0 ~ 42억 (4 bytes)
            System.UInt32 uintVal2 = System.UInt32.MinValue;                // 0 할당
            long lngVal = 9000000000000000000; // long : -92경 ~ 92경
            ulong ulngVal = 18000000000000000000; // unsinged long : 1800경(8 bytes)
            System.Int64 longVal02;         // 8 bytes
            System.UInt64 biglongVal03;     // 16 bytes

            // 실수형 자료형
            float fVal = 3.141592f;     // float : 4 bytes 소수점
            System.Single fval = System.Single.MinValue;                    // +-1.5e-45 할당
            double bVal = 3.141592;     // double : 8 bytes 소수점
            System.Double bval2 = System.Double.MinValue;
            decimal dcVal = 3.141592m;  // decimal : 16 bytes 소수점
            System.Decimal dcVal2 = System.Decimal.MinValue;

            // 문자형 자료형
            char ch01 = 'A';
            System.Char ch03 = 'B';
            Console.WriteLine(ch01);
            char ch02 = '\u25b6';
            Console.WriteLine(ch02);

            string str01 = "Hello\0World!"; // \0 : end of line
            System.String str02 = "Hello C#";

            // 불린 타입
            bool bool01 = true;
            System.Boolean bool02 = false;

            // Nullable
            // int int02 = null; // 기본타입(정수형, 실수형, 불린 / 문자열제외)은 NULL 할당 불가능
            int? int03 = null;// 타입 뒤에 '?' 붙이기

            // 상수 타입
            const int int04 = 15; // const를 만나면 상수처리 한번 할당 후 값 변경 불가
            // int04 = 26;

            // 동적 타입 // 컴파일 되면서 해당 타입으로 형태결정
            var int06 = false;

            //MessageBox.Show(intVal2.ToString(), "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show(int03.ToString(), "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
