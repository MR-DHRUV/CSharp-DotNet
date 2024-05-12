namespace prac_8
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.color_rect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_elipse = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btn_line);
            this.panel1.Controls.Add(this.btn_elipse);
            this.panel1.Controls.Add(this.btn_rect);
            this.panel1.Controls.Add(this.save_btn);
            this.panel1.Controls.Add(this.clear_btn);
            this.panel1.Controls.Add(this.btn_eraser);
            this.panel1.Controls.Add(this.btn_pencil);
            this.panel1.Controls.Add(this.btn_color);
            this.panel1.Controls.Add(this.color_rect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 89);
            this.panel1.TabIndex = 0;
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_eraser.Image = global::prac_8.Properties.Resources.eraser;
            this.btn_eraser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eraser.Location = new System.Drawing.Point(165, 12);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(77, 60);
            this.btn_eraser.TabIndex = 2;
            this.btn_eraser.Text = "Eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = false;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_pencil.Image = global::prac_8.Properties.Resources.pencil;
            this.btn_pencil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pencil.Location = new System.Drawing.Point(248, 12);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(85, 60);
            this.btn_pencil.TabIndex = 1;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = false;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_color.Image = global::prac_8.Properties.Resources.color;
            this.btn_color.Location = new System.Drawing.Point(84, 12);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(75, 60);
            this.btn_color.TabIndex = 0;
            this.btn_color.Text = "  Color";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // color_rect
            // 
            this.color_rect.Location = new System.Drawing.Point(23, 22);
            this.color_rect.Name = "color_rect";
            this.color_rect.Size = new System.Drawing.Size(41, 38);
            this.color_rect.TabIndex = 0;
            this.color_rect.UseVisualStyleBackColor = true;
            this.color_rect.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 616);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 28);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 89);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(952, 527);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(790, 49);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 3;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(790, 12);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_rect.Image = global::prac_8.Properties.Resources.rectangle;
            this.btn_rect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rect.Location = new System.Drawing.Point(433, 12);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(83, 60);
            this.btn_rect.TabIndex = 5;
            this.btn_rect.Text = "Rectangle";
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = false;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_elipse
            // 
            this.btn_elipse.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_elipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_elipse.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_elipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elipse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_elipse.Image = global::prac_8.Properties.Resources.circle;
            this.btn_elipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elipse.Location = new System.Drawing.Point(537, 12);
            this.btn_elipse.Name = "btn_elipse";
            this.btn_elipse.Size = new System.Drawing.Size(83, 60);
            this.btn_elipse.TabIndex = 6;
            this.btn_elipse.Text = "Ellipse";
            this.btn_elipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elipse.UseVisualStyleBackColor = false;
            this.btn_elipse.Click += new System.EventHandler(this.btn_elipse_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_line.Image = global::prac_8.Properties.Resources.line;
            this.btn_line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_line.Location = new System.Drawing.Point(646, 12);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(83, 60);
            this.btn_line.TabIndex = 3;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 644);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button color_rect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_elipse;
        private System.Windows.Forms.Button btn_rect;
    }
}

