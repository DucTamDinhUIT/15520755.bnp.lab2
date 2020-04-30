/*************************************
//	Basic Network Programing Lab2.2
//	Form1.cs <> Visual Studio 2017 </>
//	Purpose: Caculator and output from file.
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
namespace bt3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;            //Read data from file.
            string procesing, answer;               //string init
            
            //remove space
            procesing = content.Replace(" ", string.Empty);
            //find how many operation
            int pos =0 , count =0;
            string temp = procesing;
            do
            {
                pos = temp.LastIndexOf("\n");
                if (pos >= 0)
                {
                    temp = temp.Remove(pos);
                    count++;
                };
            }
            while (pos >= 0);   


            //split string to single operation
            string[] arrListStr = procesing.Split('\n');
            for (int i =0; i<= count; i++)
            {
                answer = arrListStr[1];
            }
            richTextBox2.Text = count.ToString();
            fs.Close();
        }
    }
}
