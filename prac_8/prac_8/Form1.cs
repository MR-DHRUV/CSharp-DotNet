using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac_8
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics gh;
        bool paint = false;
        Point px, py;
        Pen pen = new Pen(Color.Black, 1), eraser = new Pen(Color.White,10);
        ColorDialog colorPicker = new ColorDialog();
        Color c;
        int index, x, y,  sX, sY, cX, cY;

        public Form1()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 700;

            bm = new Bitmap(this.Width, this.Height);
            gh = Graphics.FromImage(bm);

            // Set color to white 
            gh.Clear(Color.White);

            pic.Image = bm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            // user clicked the canvas, so draw
            paint = true;
            py = e.Location;
               
            // update the start position
            cX = e.X;
            cY = e.Y;
        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_elipse_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if(paint)
            {
                // pencil
                if(index == 1)
                {
                    px = e.Location;
                    gh.DrawLine(pen, py, px);
                    py = px;
                }

                // eraser
                else if(index == 0)
                {
                    px = e.Location;
                    gh.DrawLine(eraser, py, px);
                    py = px;
                }
            }

            // To redraw the canvas
            pic.Refresh();
               
            // update the current position
            x = e.X;
            y = e.Y;
            
            // update the size
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sX = e.X - cX;
            sY = e.Y - cY;

            if(index == 3)
            {
                gh.DrawRectangle(pen, cX, cY, sX, sY);
            }
            else if(index == 4)
            {
                gh.DrawEllipse(pen, cX, cY, sX, sY);
            }

            else if(index == 5)
            {
                gh.DrawLine(pen, cX, cY, x, y);
            }   
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gh.Clear(Color.White);
            pic.Image = bm;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
            c = colorPicker.Color;
            pen.Color = c;
            color_rect.BackColor = c;
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
