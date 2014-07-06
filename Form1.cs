using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using anycpulib;
namespace UnlhaSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            List<string> aryFiles = new List<string>();
            aryFiles.Add(@"C:\ssi2\test.dat");


            File.Delete(@"c:\ssi2\lzhfles.lzh");
            LzhManager.fnCompressFiles(aryFiles, @"c:\ssi2\lzhfiles.lzh");

        }

        private void btnExtract_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(anycpulib.Class1.Hello());
        }
    }
}
