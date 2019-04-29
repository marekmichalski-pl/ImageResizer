using System;
using System.Data;
using System.Drawing;
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

            string[] files = Directory.GetFiles(path);

           
            DataTable table = new System.Data.DataTable();
            table.Columns.Add("File Name");
            table.Columns.Add("Size");
            table.Columns.Add("Dimension");

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                
                table.Rows.Add(file.Name, BytesToString(file.Length), GetImageSize(file.ToString()));
            }

            dgvFileGrid.DataSource = table;

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

        static string BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB"}; 

            if (byteCount == 0)
                return "0" + suf[0];

            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 2);

            return (Math.Sign(byteCount) * num).ToString() + " " + suf[place];
        }

        static string GetImageSize(string file)
        {
            string s;
            int height;
            int width;

            using (var img = Image.FromFile(file))
            {
                height = img.Height;
                width = img.Width;
            }

           
           s = width.ToString() + " x " + width.ToString();
            

            return s;
        }
    }
}
