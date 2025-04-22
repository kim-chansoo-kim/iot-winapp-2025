using SyntaxWinApp02.Properties;

namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            switch (CboDivision.SelectedIndex)
            {
                case 0: // Computer
                    Computer myCom = new Computer();
                    PicComputer.Image = Resources.computer_case;

                    myCom.Reset();
                    myCom.ShutDown();
                    myCom.Boot();
                    break;

                case 1: // Notebook
                    Notebook mynotebook = new Notebook();
                    PicComputer.Image = Resources.laptop;

                    mynotebook.Reset();
                    mynotebook.ShutDown(); // �θ�� �ٸ��� ����

                    //Computer sCom = mynotebook;
                    // �θ�Ŭ������ �ڽ�Ŭ������ ����ȯ�ϸ鼭 �����߻� ����
                    //Notebook myBook = (Notebook)new Computer();
                    Computer myComputer = new Notebook();

                    if (myComputer is Notebook)
                    {
                        Console.WriteLine("myComputer�� Notebook�Դϴ�.");
                        Notebook notebook2 = myComputer as Notebook;
                        Console.WriteLine("myComputer�� Notebook���� ����!");
                    }

                    // �����ν� Ȯ��
                    bool hasFinger = mynotebook.HasFingerScanDevice();
                    Console.WriteLine($"���� �����νĿ��� :: {hasFinger}");
                    // �޼��� �����ε�
                    hasFinger = mynotebook.HasFingerScanDevice(true);
                    Console.WriteLine($"���� �����νĿ��� :: {hasFinger}");
                    break;

                case 2: // Server
                    Server myserver = new Server();
                    PicComputer.Image = Resources.server;
                    break;

                default:
                    break;
            }
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Server server1 = new Server();
            server1.Name = "HP����";

            // ���� ���� : ���� ���� ����
            Server server2 = server1;
            server2.Name = "DELL����";

            bool isSame = server1.Equals(server2);
            Console.WriteLine(isSame);

            MessageBox.Show($"{server1.Name}\r\n{server2.Name}", "������");

            // ���� ���� : ���� �ٸ���ü�� ����
            Server server3 = server1.DeepCopy();
            server3.Name = "INTEL����";

            isSame = server2.Equals(server3);
            Console.WriteLine(isSame);

            MessageBox.Show($"{server1.Name}\r\n{server3.Name}", "������");
        }
    }
}
