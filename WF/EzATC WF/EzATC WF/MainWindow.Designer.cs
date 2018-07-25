namespace EzATC_WF.src
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.depCSHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flightStripRulesLabel = new System.Windows.Forms.Label();
            this.flightStripSquawkLabel = new System.Windows.Forms.Label();
            this.flightStripTypeLabel = new System.Windows.Forms.Label();
            this.flightStripCallsignLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tafButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sessionStatusLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.commCenterButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.flightStripRouteLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.dEVToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // dEVToolStripMenuItem
            // 
            this.dEVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFlightToolStripMenuItem});
            this.dEVToolStripMenuItem.Name = "dEVToolStripMenuItem";
            this.dEVToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.dEVToolStripMenuItem.Text = "DEV";
            // 
            // addFlightToolStripMenuItem
            // 
            this.addFlightToolStripMenuItem.Name = "addFlightToolStripMenuItem";
            this.addFlightToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.addFlightToolStripMenuItem.Text = "Add flight";
            this.addFlightToolStripMenuItem.Click += new System.EventHandler(this.addFlightToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.depCSHeader,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(0, 151);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(623, 481);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // depCSHeader
            // 
            this.depCSHeader.Text = "Callsign";
            this.depCSHeader.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Destination";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "First Fix";
            this.columnHeader3.Width = 164;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "SID";
            this.columnHeader7.Width = 116;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Initial Climb";
            this.columnHeader8.Width = 115;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.listView2.Location = new System.Drawing.Point(629, 151);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(623, 481);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Callsign";
            this.columnHeader4.Width = 144;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Departure";
            this.columnHeader5.Width = 148;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Last Fix";
            this.columnHeader6.Width = 164;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 638);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1083, 191);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flightStripRouteLabel);
            this.panel1.Controls.Add(this.flightStripRulesLabel);
            this.panel1.Controls.Add(this.flightStripSquawkLabel);
            this.panel1.Controls.Add(this.flightStripTypeLabel);
            this.panel1.Controls.Add(this.flightStripCallsignLabel);
            this.panel1.Location = new System.Drawing.Point(6, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 99);
            this.panel1.TabIndex = 1;
            // 
            // flightStripRulesLabel
            // 
            this.flightStripRulesLabel.AutoSize = true;
            this.flightStripRulesLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightStripRulesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.flightStripRulesLabel.Location = new System.Drawing.Point(4, 66);
            this.flightStripRulesLabel.Name = "flightStripRulesLabel";
            this.flightStripRulesLabel.Size = new System.Drawing.Size(25, 17);
            this.flightStripRulesLabel.TabIndex = 0;
            this.flightStripRulesLabel.Text = "IFR";
            // 
            // flightStripSquawkLabel
            // 
            this.flightStripSquawkLabel.AutoSize = true;
            this.flightStripSquawkLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightStripSquawkLabel.Location = new System.Drawing.Point(100, 12);
            this.flightStripSquawkLabel.Name = "flightStripSquawkLabel";
            this.flightStripSquawkLabel.Size = new System.Drawing.Size(36, 17);
            this.flightStripSquawkLabel.TabIndex = 0;
            this.flightStripSquawkLabel.Text = "4123";
            // 
            // flightStripTypeLabel
            // 
            this.flightStripTypeLabel.AutoSize = true;
            this.flightStripTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightStripTypeLabel.Location = new System.Drawing.Point(4, 39);
            this.flightStripTypeLabel.Name = "flightStripTypeLabel";
            this.flightStripTypeLabel.Size = new System.Drawing.Size(47, 17);
            this.flightStripTypeLabel.TabIndex = 0;
            this.flightStripTypeLabel.Text = "B752/F";
            // 
            // flightStripCallsignLabel
            // 
            this.flightStripCallsignLabel.AutoSize = true;
            this.flightStripCallsignLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightStripCallsignLabel.Location = new System.Drawing.Point(3, 9);
            this.flightStripCallsignLabel.Name = "flightStripCallsignLabel";
            this.flightStripCallsignLabel.Size = new System.Drawing.Size(77, 21);
            this.flightStripCallsignLabel.TabIndex = 0;
            this.flightStripCallsignLabel.Text = "BER341G";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reloadButton);
            this.groupBox2.Controls.Add(this.tafButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1230, 63);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weather";
            // 
            // tafButton
            // 
            this.tafButton.Location = new System.Drawing.Point(970, 25);
            this.tafButton.Name = "tafButton";
            this.tafButton.Size = new System.Drawing.Size(45, 29);
            this.tafButton.TabIndex = 2;
            this.tafButton.Text = "TAF";
            this.tafButton.UseVisualStyleBackColor = true;
            this.tafButton.Click += new System.EventHandler(this.tafButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1107, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "230° at 4";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(6, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(958, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "EDDK 221850Z 04002KT CAVOK 24/14 Q1015 NOSIG";
            // 
            // sessionStatusLabel
            // 
            this.sessionStatusLabel.AutoSize = true;
            this.sessionStatusLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.sessionStatusLabel.ForeColor = System.Drawing.Color.White;
            this.sessionStatusLabel.Location = new System.Drawing.Point(854, 37);
            this.sessionStatusLabel.Name = "sessionStatusLabel";
            this.sessionStatusLabel.Size = new System.Drawing.Size(0, 28);
            this.sessionStatusLabel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EzATC_WF.Properties.Resources.backgroundtemplate;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1254, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // commCenterButton
            // 
            this.commCenterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commCenterButton.ForeColor = System.Drawing.Color.Green;
            this.commCenterButton.Location = new System.Drawing.Point(1101, 638);
            this.commCenterButton.Name = "commCenterButton";
            this.commCenterButton.Size = new System.Drawing.Size(141, 94);
            this.commCenterButton.TabIndex = 2;
            this.commCenterButton.Text = "COMMCENTER";
            this.commCenterButton.UseVisualStyleBackColor = true;
            this.commCenterButton.Click += new System.EventHandler(this.commCenterButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(1101, 798);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(141, 31);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(1021, 25);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(80, 29);
            this.reloadButton.TabIndex = 3;
            this.reloadButton.Text = "RELOAD";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // flightStripRouteLabel
            // 
            this.flightStripRouteLabel.AutoSize = true;
            this.flightStripRouteLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightStripRouteLabel.Location = new System.Drawing.Point(156, 13);
            this.flightStripRouteLabel.Name = "flightStripRouteLabel";
            this.flightStripRouteLabel.Size = new System.Drawing.Size(357, 17);
            this.flightStripRouteLabel.TabIndex = 1;
            this.flightStripRouteLabel.Text = "MARUN Y164 ABTAL L135 BOMBI A312 KENAG T128 BADSO";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1254, 841);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.commCenterButton);
            this.Controls.Add(this.sessionStatusLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EzATC Assistant Session";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader depCSHeader;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label sessionStatusLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tafButton;
        private System.Windows.Forms.Label flightStripCallsignLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label flightStripTypeLabel;
        private System.Windows.Forms.Label flightStripRulesLabel;
        private System.Windows.Forms.Label flightStripSquawkLabel;
        private System.Windows.Forms.ToolStripMenuItem dEVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFlightToolStripMenuItem;
        private Session s;

        public MainWindow(Session s)
        {
            this.s = s;
        }
        private System.Windows.Forms.Button commCenterButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Label flightStripRouteLabel;
    }
}