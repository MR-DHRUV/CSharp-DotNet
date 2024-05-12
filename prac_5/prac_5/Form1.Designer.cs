namespace prac_5
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
            this.Country = new System.Windows.Forms.ListBox();
            this.State = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Country
            // 
            this.Country.FormattingEnabled = true;
            this.Country.Location = new System.Drawing.Point(42, 43);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(120, 95);
            this.Country.TabIndex = 0;
            this.Country.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // State
            // 
            this.State.FormattingEnabled = true;
            this.State.Location = new System.Drawing.Point(209, 43);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(120, 95);
            this.State.TabIndex = 1;
            this.State.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.State);
            this.Controls.Add(this.Country);
            this.Name = "Form1";
            this.Text = "MyApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Country;
        private System.Windows.Forms.ListBox State;
    }
}

