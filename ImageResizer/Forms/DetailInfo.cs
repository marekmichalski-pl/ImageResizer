using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageResizer.Forms
{
    public partial class ImageResizer : Form
    {
        public ImageResizer(string fileParth)
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap("fileParth");
        }

        
    }
}
