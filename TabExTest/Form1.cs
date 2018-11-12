using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolbarEx;

namespace TabExTest
{
    public partial class Form1 : Form
    {
        int i = 0;
        UserControl1 mnuHost;

        public Form1()
        {
            InitializeComponent();

            mnuHost = new UserControl1();
            this.tabControlEx1.AllowDrop = true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TabPageEx pg = new TabPageEx("test-" + i.ToString());

            //set menu
            pg.Menu = mnuHost.ContextMenuStrip;

            //add a label
            Label lbl = new Label();
            lbl.AutoSize = false;
            lbl.Size = new Size(272, 50);
            lbl.Text = "This tab name is editable..double click to enter.. " + i.ToString();
            pg.Controls.Add(lbl);

            //add tab to control
            tabControlEx1.Controls.Add(pg);
            i++;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            mnuHost.Dispose();
        }

    }
}
