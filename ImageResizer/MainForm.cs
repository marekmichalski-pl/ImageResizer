using System;
using System.IO;
using System.Windows.Forms;

namespace ImageResizer
{
    public partial class MainForm : Form
    {
        public MainForm()
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

        private int CountFilesInFolder(string path, string fileType)
        {
            int count = 0;

            count = Directory.GetFiles(path, fileType, SearchOption.TopDirectoryOnly).Length;

            return count;
        }

        private int CountFilesInFolders(string path, string fileType)
        {
            int count = 0;

            count = Directory.GetFiles(path, fileType, SearchOption.AllDirectories).Length;

            return count;
        }

        private bool AreFilsInSubdirectories(string path, string fileType)
        {
            int a = CountFilesInFolder(path, fileType);
            int b = CountFilesInFolders(path, fileType);

            return (b > a);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
