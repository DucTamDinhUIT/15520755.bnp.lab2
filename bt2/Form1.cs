/*************************************
//	Basic Network Programing Lab2.2
//	Form1.cs
//	Purpose: Get information of file
//
//	@author 15520755@gm.uit.edu.vn
**************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace bt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;

            // Count number of character in a file //
            int charCount = content.Length;
            // Count number of line in a file
            content = content.Replace("\r\n", "\r");
            int lineCount = richTextBox1.Lines.Count();
            content = content.Replace('\r', ' ');
            // Count number of word in a file //
            string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';',':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = source.Count();

            fs.Close();
            textBox1.Text = ofd.SafeFileName;
            textBox2.Text = ofd.FileName;
            textBox3.Text = lineCount.ToString();
            textBox4.Text = wordCount.ToString();
            textBox5.Text = charCount.ToString();
        }

    }
}
