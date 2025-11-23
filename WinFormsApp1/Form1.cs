using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> files = new List<string>();
        int counter = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Filter = "Все файлы (*.*)|*.*|Классы и верстки (*.cs *.xaml)|*.cs; *.xaml";

            DialogResult dr = fileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                foreach (string file in fileDialog.FileNames)
                {
                    files.Add(file);
                }
            }
            label2.Text = files.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (files.Count == 0)
            {
                MessageBox.Show("нет файликов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (separatorTbx.Text == "")
            {
                MessageBox.Show("поставьте пожалуйста символ в поле для символа-разделителя. при помощи него нужный текст будет выделен times new roman. без него не работает(", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            char separator = separatorTbx.Text[0];

            progressBar1.Visible = true;
            panel1.Enabled = false;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";
            for (int i = 0; i < files.Count; i++)
            {
                string fileName = files[i].Substring(files[i].LastIndexOf("\\") + 1);
                using (StreamReader sr = new StreamReader(files[i]))
                {
                    var fileContainer = sr.ReadToEnd();
                    richTextBox1.Text += $"{separator}" + (i + 1) + ") " + fileName + $";{separator}\n\n" + fileContainer + "\n\n";
                    richTextBox4.Text += fileContainer.Count(x => x == '\n') + "\n";
                }
                ;
                richTextBox2.Text += fileName + "\n";
                richTextBox3.Text += Math.Ceiling((double)new FileInfo(files[i]).Length / 1024) + " КБ \n";
                counter++;
            }
            counter = 0;
            int firstIndex = 0;
            int secondIndex;
            do
            {
                firstIndex = richTextBox1.Text.IndexOf(separator, firstIndex);
                secondIndex = richTextBox1.Text.IndexOf(separator, firstIndex + 1);
                richTextBox1.Select(firstIndex, secondIndex - firstIndex);
                richTextBox1.SelectionFont = new Font("Times New Roman", 14);
                firstIndex = secondIndex + 1;
                counter++;
            } while (secondIndex != richTextBox1.Text.LastIndexOf(separator) && counter <= files.Count);

            panel1.Enabled = true;
            progressBar1.Visible = false;
        }

    }
}
