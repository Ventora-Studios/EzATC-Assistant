using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EzATC_WF.src;
using EzATC_WF.dev;

namespace EzATC_WF.src
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Utilities.makeLabelTransparent(this, label1, pictureBox1);
        }

        private void addFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevAdd da = new DevAdd();
            da.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
