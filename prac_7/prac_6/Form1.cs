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
    public partial class Notify : Form
    {
        bool isSaved = false;
        string fileName = "";
        string filePath = "";
        string fileContent = "";

        Stack<string> state;

        public Notify()
        {
            InitializeComponent();
            state = new Stack<string>();
            state.Push(textBox1.Text);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void edirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file dialog
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFile.Title = "Open File";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Read file
                fileName = openFile.SafeFileName;
                filePath = openFile.FileName;
                fileContent = System.IO.File.ReadAllText(filePath);
                state.Push(textBox1.Text);
                textBox1.Text = fileContent;
                isSaved = true;
            }
            else
            {
                MessageBox.Show("File not opened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            isSaved = false;
            state.Push(textBox1.Text); // Push the current text to the stack
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // cut the selected text
            state.Push(textBox1.Text);
            textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state.Push(textBox1.Text);
            textBox1.SelectedText = "";
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = state.Pop();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // save to 
            System.IO.File.WriteAllText(filePath, textBox1.Text);
            isSaved = true;
            
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // save to user selected file
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFile.Title = "Save File";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFile.FileName, textBox1.Text);
                isSaved = true;
            }
            else
            {
                MessageBox.Show("File not saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state.Push(textBox1.Text);
            textBox1.Paste();
        }

        private void zoomInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size + 5);
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size - 4);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!isSaved)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save the file?", "Save File", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    saveToolStripMenuItem1_Click(sender, e);
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            exitToolStripMenuItem_Click(sender, e);
        }   
    }
}
