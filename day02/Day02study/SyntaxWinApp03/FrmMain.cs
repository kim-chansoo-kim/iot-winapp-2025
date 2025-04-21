namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Btnmsg_Click(object sender, EventArgs e)
        {
            // �б⹮
            if (TxtPain.Text == "�ƴϿ�")
            {
                MessageBox.Show("������ �� �Ծ��. ������!");
            }
            else if (TxtPain.Text == "��")
            {
                string PainPoint = CboPainPoint.SelectedItem.ToString();

                // switch��
                switch (PainPoint)
                {
                    case "�Ӹ�":
                        MessageBox.Show("�Ű���� ������", "���������");
                        break;
                    case "��":
                        MessageBox.Show("�Ȱ��� ������!", "���������");
                        break;
                    case "��":
                        MessageBox.Show("�̺����İ��� ������!", "���������");
                        break;
                    case "��":
                        MessageBox.Show("�̺����İ��� ������!", "���������");
                        break;
                    case "����":
                        MessageBox.Show("������ ������!", "���������");
                        break;
                    case "��":
                        MessageBox.Show("��ȭ���� ������!", "���������");
                        break;
                    default:
                        MessageBox.Show("�� �𸣰ھ��. ����ó�� ������.");
                        break;
                }
            }
        }

        private void TxtPain_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ű���������� ���͸� �Է��ϸ� C, C++ if���� ����
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show(TxtPain.Text, "�Է°�");
            }
        }

        private void CboPainPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPoint = CboPainPoint.SelectedItem.ToString();
            MessageBox.Show(selectedPoint, "��������");
        }

        private void BtnDisPlay_Click(object sender, EventArgs e)
        {
            TxtResult.Text = string.Empty; // �ʱ�ȭ
            // for��
            for (int x = 2; x < 10; x++)
            {
                for (int y = 1; y < 10; y++)
                {
                    var result = x + "x" + y + "=" + (x * y);
                    TxtResult.Text += result + " ";
                }
                TxtResult.Text += "\r\n";   // ���� ������� \r\n�� ���� �����
            }
        }

        int clickNum = 0;

        private void BtnWhile_Click(object sender, EventArgs e)
        {
            // ���ѹݺ�
            while (true)
            {
                MessageBox.Show("��� > " + clickNum);
                clickNum++;

                if (clickNum == 10)
                {
                    break; // �ݺ��� Ż�� for, foreach, while���� ��밡��
                    // continue; �� �ľ��� ��
                    // goto; �� �ظ��ϸ� ���� ����
                }
            }
        }
    }
}
