
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            panel1 = new System.Windows.Forms.Panel();
            separatorTbx = new System.Windows.Forms.TextBox();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            label3 = new System.Windows.Forms.Label();
            richTextBox4 = new System.Windows.Forms.RichTextBox();
            richTextBox3 = new System.Windows.Forms.RichTextBox();
            richTextBox2 = new System.Windows.Forms.RichTextBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Количество файлов:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(137, 11);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(13, 15);
            label2.TabIndex = 1;
            label2.Text = "0";
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            button1.Location = new System.Drawing.Point(550, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(213, 23);
            button1.TabIndex = 2;
            button1.Text = "Открыть файлы";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            button2.Location = new System.Drawing.Point(550, 32);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(213, 25);
            button2.TabIndex = 3;
            button2.Text = "Перенести их в один файл";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            richTextBox1.Font = new System.Drawing.Font("Times New Roman", 9F);
            richTextBox1.Location = new System.Drawing.Point(11, 63);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(387, 477);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.Controls.Add(separatorTbx);
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(richTextBox4);
            panel1.Controls.Add(richTextBox3);
            panel1.Controls.Add(richTextBox2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Location = new System.Drawing.Point(25, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(777, 558);
            panel1.TabIndex = 7;
            // 
            // separatorTbx
            // 
            separatorTbx.Location = new System.Drawing.Point(273, 34);
            separatorTbx.MaxLength = 1;
            separatorTbx.Name = "separatorTbx";
            separatorTbx.Size = new System.Drawing.Size(28, 23);
            separatorTbx.TabIndex = 10;
            separatorTbx.Text = "~";
            // 
            // progressBar1
            // 
            progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            progressBar1.Location = new System.Drawing.Point(0, 268);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(777, 27);
            progressBar1.TabIndex = 6;
            progressBar1.Value = 50;
            progressBar1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(11, 37);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(256, 15);
            label3.TabIndex = 9;
            label3.Text = "Символ-разделитель (для форматирования):";
            toolTip1.SetToolTip(label3, "Этим символом будут выделена нумерация в итоговом обьединении. Введите символ, который 100% не встречается у вас в проекте");
            // 
            // richTextBox4
            // 
            richTextBox4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            richTextBox4.Font = new System.Drawing.Font("Times New Roman", 12F);
            richTextBox4.Location = new System.Drawing.Point(684, 63);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new System.Drawing.Size(79, 477);
            richTextBox4.TabIndex = 8;
            richTextBox4.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            richTextBox3.Font = new System.Drawing.Font("Times New Roman", 12F);
            richTextBox3.Location = new System.Drawing.Point(599, 63);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new System.Drawing.Size(79, 477);
            richTextBox3.TabIndex = 7;
            richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            richTextBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
            richTextBox2.Location = new System.Drawing.Point(404, 63);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new System.Drawing.Size(189, 477);
            richTextBox2.TabIndex = 6;
            richTextBox2.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(814, 582);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Генератор текста программы";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.TextBox separatorTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

