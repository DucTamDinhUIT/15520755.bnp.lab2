/*************************************
//	Basic Network Programing Lab2.5
//	Form1.cs
//	Purpose: Get informations files in Folder
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

namespace bt5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string pathSelect = folderBrowserDialog1.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(pathSelect);
                FileInfo[] fiArr = di.GetFiles("*.*", SearchOption.AllDirectories);
                listView1.Items.Clear();
                foreach (FileInfo Fi in fiArr)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = Fi.Name.ToString();
                    item.SubItems.Add(Fi.Length.ToString());
                    item.SubItems.Add(Fi.Extension.ToString());
                    item.SubItems.Add(Fi.CreationTime.ToString());
                    listView1.Items.Add(item);
                }
                
            }
        }

    }
}
