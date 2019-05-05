using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageResizer
{
    public partial class DetailInfo : Form
    {
        public DetailInfo(string filePath)
        {
            InitializeComponent();

            Image image = Image.FromFile(filePath);
            pictureBox1.Image = image;
        }
    }
}
