using System.Windows.Forms.Design;

namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        // var int09 = 10; // var�� �������� ��� �Ұ�

        public FrmMain()
        {
            InitializeComponent();
        }
        private void BtnMsg_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("�޽���", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // ������ �ڷ���
            sbyte sbtVal = 127;        // singed byte : - 128 ~ 127 ���� ����
            System.SByte sbtVal2 = System.SByte.MinValue;                   // -128 �Ҵ�
            byte btVal = 255;           // byte : 0 ~ 255 ���� ����(1 byte)
            System.Byte btVal2 = System.Byte.MinValue;                      // 0 �Ҵ�
            short stVal = 32767;        // short : -32768 ~ 32767 ���� ����
            System.Int16 stVal2 = System.Int16.MinValue;                    // -32768 �Ҵ�
            ushort ustVal = 65535;      // unsinged short : 0 ~ 65535 ����(2 bytes)
            System.UInt16 ustVal2 = System.UInt16.MinValue;                 // 0 �Ҵ�
            int intVal = 2147483647;    // int -21�� ~ 21�� (4 bytes)
            System.Int32 intVal2 = System.Int32.MinValue;                   // - 21���Ҵ�
            uint uintVal = 4294967295;  // unsinged int : 0 ~ 42�� (4 bytes)
            System.UInt32 uintVal2 = System.UInt32.MinValue;                // 0 �Ҵ�
            long lngVal = 9000000000000000000; // long : -92�� ~ 92��
            ulong ulngVal = 18000000000000000000; // unsinged long : 1800��(8 bytes)
            System.Int64 longVal02;         // 8 bytes
            System.UInt64 biglongVal03;     // 16 bytes

            // �Ǽ��� �ڷ���
            float fVal = 3.141592f;     // float : 4 bytes �Ҽ���
            System.Single fval = System.Single.MinValue;                    // +-1.5e-45 �Ҵ�
            double bVal = 3.141592;     // double : 8 bytes �Ҽ���
            System.Double bval2 = System.Double.MinValue;
            decimal dcVal = 3.141592m;  // decimal : 16 bytes �Ҽ���
            System.Decimal dcVal2 = System.Decimal.MinValue;

            // ������ �ڷ���
            char ch01 = 'A';
            System.Char ch03 = 'B';
            Console.WriteLine(ch01);
            char ch02 = '\u25b6';
            Console.WriteLine(ch02);

            string str01 = "Hello\0World!"; // \0 : end of line
            System.String str02 = "Hello C#";

            // �Ҹ� Ÿ��
            bool bool01 = true;
            System.Boolean bool02 = false;

            // Nullable
            // int int02 = null; // �⺻Ÿ��(������, �Ǽ���, �Ҹ� / ���ڿ�����)�� NULL �Ҵ� �Ұ���
            int? int03 = null;// Ÿ�� �ڿ� '?' ���̱�

            // ��� Ÿ��
            const int int04 = 15; // const�� ������ ���ó�� �ѹ� �Ҵ� �� �� ���� �Ұ�
            // int04 = 26;

            // ���� Ÿ�� // ������ �Ǹ鼭 �ش� Ÿ������ ���°���
            var int06 = false;

            //MessageBox.Show(intVal2.ToString(), "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show(int03.ToString(), "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
