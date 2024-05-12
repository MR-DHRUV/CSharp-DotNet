using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeMenu();
        }

        private void InitializeMenu()
        {
            // Creating menu items
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");
            ToolStripMenuItem editMenu = new ToolStripMenuItem("Edit");
            ToolStripMenuItem viewMenu = new ToolStripMenuItem("View");

            // Adding menu items to the menu strip
            menuStrip1.Items.Add(fileMenu);
            menuStrip1.Items.Add(editMenu);
            menuStrip1.Items.Add(viewMenu);

            // Adding sub-menu items under "View" menu
            ToolStripMenuItem anchorMenu = new ToolStripMenuItem("Set Anchor");
            ToolStripMenuItem dockMenu = new ToolStripMenuItem("Set Dock");
            viewMenu.DropDownItems.Add(anchorMenu);
            viewMenu.DropDownItems.Add(dockMenu);

            // Adding options for setting Anchor
            ToolStripMenuItem anchorTopMenu = new ToolStripMenuItem("Top");
            ToolStripMenuItem anchorBottomMenu = new ToolStripMenuItem("Bottom");
            ToolStripMenuItem anchorLeftMenu = new ToolStripMenuItem("Left");
            ToolStripMenuItem anchorRightMenu = new ToolStripMenuItem("Right");
            anchorMenu.DropDownItems.Add(anchorTopMenu);
            anchorMenu.DropDownItems.Add(anchorBottomMenu);
            anchorMenu.DropDownItems.Add(anchorLeftMenu);
            anchorMenu.DropDownItems.Add(anchorRightMenu);

            // Adding event handlers for setting Anchor
            anchorTopMenu.Click += AnchorTopMenu_Click;
            anchorBottomMenu.Click += AnchorBottomMenu_Click;
            anchorLeftMenu.Click += AnchorLeftMenu_Click;
            anchorRightMenu.Click += AnchorRightMenu_Click;

            // Adding options for setting Dock
            ToolStripMenuItem dockFillMenu = new ToolStripMenuItem("Fill");
            ToolStripMenuItem dockTopMenu = new ToolStripMenuItem("Top");
            ToolStripMenuItem dockBottomMenu = new ToolStripMenuItem("Bottom");
            ToolStripMenuItem dockLeftMenu = new ToolStripMenuItem("Left");
            ToolStripMenuItem dockRightMenu = new ToolStripMenuItem("Right");
            dockMenu.DropDownItems.Add(dockFillMenu);
            dockMenu.DropDownItems.Add(dockTopMenu);
            dockMenu.DropDownItems.Add(dockBottomMenu);
            dockMenu.DropDownItems.Add(dockLeftMenu);
            dockMenu.DropDownItems.Add(dockRightMenu);

            // Adding event handlers for setting Dock
            dockFillMenu.Click += DockFillMenu_Click;
            dockTopMenu.Click += DockTopMenu_Click;
            dockBottomMenu.Click += DockBottomMenu_Click;
            dockLeftMenu.Click += DockLeftMenu_Click;
            dockRightMenu.Click += DockRightMenu_Click;

            // Add other menu items and event handlers as needed
        }

        // Event handlers for setting Anchor
        private void AnchorTopMenu_Click(object sender, EventArgs e)
        {
            button1.Anchor = AnchorStyles.Top;
        }

        private void AnchorBottomMenu_Click(object sender, EventArgs e)
        {
            button1.Anchor = AnchorStyles.Bottom;
        }

        private void AnchorLeftMenu_Click(object sender, EventArgs e)
        {
            button1.Anchor = AnchorStyles.Left;
        }

        private void AnchorRightMenu_Click(object sender, EventArgs e)
        {
            button1.Anchor = AnchorStyles.Right;
        }

        // Event handlers for setting Dock
        private void DockFillMenu_Click(object sender, EventArgs e)
        {
            button1.Dock = DockStyle.Fill;
        }

        private void DockTopMenu_Click(object sender, EventArgs e)
        {
            button1.Dock = DockStyle.Top;
        }

        private void DockBottomMenu_Click(object sender, EventArgs e)
        {
            button1.Dock = DockStyle.Bottom;
        }

        private void DockLeftMenu_Click(object sender, EventArgs e)
        {
            button1.Dock = DockStyle.Left;
        }

        private void DockRightMenu_Click(object sender, EventArgs e)
        {
            button1.Dock = DockStyle.Right;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
