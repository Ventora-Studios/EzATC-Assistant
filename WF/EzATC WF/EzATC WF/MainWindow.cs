using System;
using System.Windows.Forms;
using EzATC_WF.dev;
using System.Drawing;

namespace EzATC_WF.src
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void addTestItems()
        {
            listView1.Items.Clear();

            Flight f = new Flight("BER3125", "EDDK", "EDDS", "ABTAL L163 BOMBI Y123 KOPAG", "0000", "B734", FlightType.IFR);

            ListViewItem f1 = new ListViewItem();
            f1.Text = f.Callsign;
            f1.SubItems.Add(f.Destination);
            f1.SubItems.Add("ABTAL");
            f1.SubItems.Add("ABTAL4B");
            f1.SubItems.Add(f.Sqw);

            listView1.Items.Add(f1);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Utilities.makeLabelTransparent(this, sessionStatusLabel, pictureBox1);


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
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tafButton_Click(object sender, EventArgs e)
        {

        }

        private void commCenterButton_Click(object sender, EventArgs e)
        {

        }

        private void reloadButton_Click(object sender, EventArgs e)
        {

        }
    }
}
