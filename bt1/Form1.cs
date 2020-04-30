/**********************************
//	Basic Network Programing Lab2.1
//	Form1.cs
//	Purpose: Check line,Read File, Write file.
//
//	@author 15520755@gm.uit.edu.vn
***********************************/
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

namespace bt1
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName,FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            int lineCount = 0;
            while (sr.ReadLine() != null)
            {
                lineCount++;
            }
            fs.Close();
            MessageBox.Show("There are " + lineCount + " lines in " + ofd.FileName);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName,FileMode.Append);
            StreamWriter bw = new StreamWriter(fs);
            string content = richTextBox1.Text;
            bw.Write(content);
            bw.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName,FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;
            fs.Close();
        }


    }
}
