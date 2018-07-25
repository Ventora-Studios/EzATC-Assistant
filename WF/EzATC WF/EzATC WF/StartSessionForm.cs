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

namespace EzATC_WF
{
    public partial class StartSession : Form
    {
        public Session s;

        public StartSession()
        {
            InitializeComponent();

            Utilities.makeLabelTransparent(this, label3, pictureBox1);
            Utilities.makeLabelTransparent(this, label4, pictureBox1);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sessionButton_Click(object sender, EventArgs e)
        {
            s = new Session("EDDK", "438235");

            this.Hide();
            MainWindow mw = new MainWindow();
            mw.Closed += (s, args) => this.Close();
            mw.Show();

            
        }

        public Session getSession()
        {
            return s;
        }

        private void StartSession_Load(object sender, EventArgs e)
        {

        }
    }
}
