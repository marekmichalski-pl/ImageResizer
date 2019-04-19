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

namespace ImageResizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            lblSelectedInputFolder.Text = SelectFolder();
            CountFilesInFolder(lblSelectedInputFolder.Text, "*.jpg");
        }


        private string SelectFolder()
        {
            string path = "";

            using (var fldrDlg = new FolderBrowserDialog())
            {
                if (fldrDlg.ShowDialog() == DialogResult.OK)
                {
                    path = fldrDlg.SelectedPath;
                }
            }

            return path;
        }

        private int CountFilesInFolder(string path, string fileTye)
        {
            int count = 0;

            count = Directory.GetFiles(path, fileTye, SearchOption.TopDirectoryOnly).Length;

            return count;
        }
    }
}
