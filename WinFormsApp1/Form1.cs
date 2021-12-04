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
            fileDialog.Filter = "Классы и верстки (*.cs *.xaml)|*.cs; *.xaml|Все файлы (*.*)|*.*";

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
            progressBar1.Visible = true;
            panel1.Enabled = false;
            richTextBox1.Text = "";
            for (int i = 0; i < files.Count; i++)
            {
                string fileName = files[i].Substring(files[i].LastIndexOf("\\") + 1);
                using (StreamReader sr = new StreamReader(files[i]))
                {
                    richTextBox1.Text += "~" + (i + 1) + ") " + fileName + ";~\n\n" + sr.ReadToEnd() + "\n\n";
                };
                richTextBox2.Text += fileName + "\n";
                richTextBox3.Text += Math.Ceiling((double)new FileInfo(files[i]).Length/1024) + " КБ \n";
                counter++;
            }
            counter = 0;
            int firstIndex = 0;
            int secondIndex;
            do
            {
                firstIndex = richTextBox1.Text.IndexOf('~', firstIndex);
                secondIndex = richTextBox1.Text.IndexOf('~', firstIndex + 1);
                richTextBox1.Select(firstIndex, secondIndex - firstIndex);
                richTextBox1.SelectionFont = new Font("Times New Roman", 14);
                firstIndex = secondIndex + 1;
                counter++;
            } while (secondIndex != richTextBox1.Text.LastIndexOf('~'));

            panel1.Enabled = true;
            progressBar1.Visible = false;
        }

    }
}
