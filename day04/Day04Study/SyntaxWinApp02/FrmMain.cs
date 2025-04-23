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
            // ������ DB���� �����ͷε� �� �Ʒ��� �۾����� ����
            // �迭 ����
            string[] fruits = { "���", "�ٳ���", "����", "����", "��纣��" };
            CboArray.Items.AddRange(fruits); // �迭�� �޺��ڽ��� �Ҵ�
            CboArray.SelectedIndex = 0;

            // ����Ʈ ���� - ���� ��� ����̵� ��밡��

            // ù��° ���
            //List<string> lFruits = new List<string>();
            //lFruits.Add("���");
            //lFruits.Add("����ƾ");
            //lFruits.Add("���ø���");
            //lFruits.Add("�ڸ�");

            // �ι�° ���(����)
            List<string> lFruits = ["���", "����ƾ", "���ø���", "�ڸ�", "�θ���"];
            CboList.DataSource = lFruits;


            // ��ųʸ� ���� - DB �ڵ鸵�� ���� ���� ���Ǵ� ���
            Dictionary<string, string> dCountry = new Dictionary<string, string>()
            {
                { "KR", "���ѹα�" },
                { "US", "�̱�" },
                { "JP", "�Ϻ�" },
                { "CN", "�߱�" },
                { "IN", "�ε�" },
                { "PH", "�ʸ���" }
            };
            CboDic.DataSource = new BindingSource(dCountry, null);
            CboDic.DisplayMember = "Value"; // ����ڿ��� ���̴� �̸�
            CboDic.ValueMember = "Key";     // ���������� ���õǴ� ��

            // foreach�� �ݺ� ó��
            string result = "";
            foreach (var item in dCountry)
            {
                Console.WriteLine(item.ToString());
            }

        }

        private void CboArray_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SelectedItem �� object?
            string selected1 = CboArray.SelectedItem.ToString();
            MessageBox.Show($"������ ������ {selected1} �Դϴ�.", "�����ϴ� ����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected2 = CboList.SelectedItem.ToString();
            MessageBox.Show($"������ ������ {selected2} �Դϴ�.", "�Ⱦ��ϴ� ����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CboDic_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kvp = (KeyValuePair<string, string>)CboDic.SelectedItem;
            string key = kvp.Key;
            string value = kvp.Value;

            string selected3 = CboDic.SelectedItem.ToString();
            MessageBox.Show($"���õ� Ű�� [{key}], ���� [{value}]", "���õ� ����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
