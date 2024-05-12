namespace prac_11
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
            this.fName = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.lNameInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.fNameInput = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.data_container = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_container)).BeginInit();
            this.SuspendLayout();
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(35, 92);
            this.fName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(98, 20);
            this.fName.TabIndex = 0;
            this.fName.Text = "First Name : ";
            this.fName.Click += new System.EventHandler(this.fName_Click);
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(35, 152);
            this.LName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(98, 20);
            this.LName.TabIndex = 0;
            this.LName.Text = "Last Name : ";
            this.LName.Click += new System.EventHandler(this.LName_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(35, 212);
            this.email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(123, 20);
            this.email.TabIndex = 0;
            this.email.Text = "Email Address : ";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // lNameInput
            // 
            this.lNameInput.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameInput.Location = new System.Drawing.Point(194, 147);
            this.lNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.lNameInput.Name = "lNameInput";
            this.lNameInput.Size = new System.Drawing.Size(229, 27);
            this.lNameInput.TabIndex = 1;
            this.lNameInput.TextChanged += new System.EventHandler(this.lNameInput_TextChanged);
            // 
            // emailInput
            // 
            this.emailInput.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInput.Location = new System.Drawing.Point(194, 207);
            this.emailInput.Margin = new System.Windows.Forms.Padding(2);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(229, 27);
            this.emailInput.TabIndex = 1;
            this.emailInput.TextChanged += new System.EventHandler(this.emailInput_TextChanged);
            // 
            // fNameInput
            // 
            this.fNameInput.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameInput.Location = new System.Drawing.Point(194, 87);
            this.fNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.fNameInput.Name = "fNameInput";
            this.fNameInput.Size = new System.Drawing.Size(229, 27);
            this.fNameInput.TabIndex = 1;
            this.fNameInput.TextChanged += new System.EventHandler(this.fNameInput_TextChanged);
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.Location = new System.Drawing.Point(39, 282);
            this.Insert.Margin = new System.Windows.Forms.Padding(2);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(81, 35);
            this.Insert.TabIndex = 3;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(194, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(35, 39);
            this.id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(23, 20);
            this.id.TabIndex = 4;
            this.id.Text = "Id";
            this.id.Click += new System.EventHandler(this.label1_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(194, 282);
            this.update.Margin = new System.Windows.Forms.Padding(2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(81, 35);
            this.update.TabIndex = 6;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(342, 282);
            this.delete.Margin = new System.Windows.Forms.Padding(2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(81, 35);
            this.delete.TabIndex = 7;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // data_container
            // 
            this.data_container.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_container.BackgroundColor = System.Drawing.SystemColors.Control;
            this.data_container.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_container.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_container.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.data_container.Location = new System.Drawing.Point(0, 382);
            this.data_container.Name = "data_container";
            this.data_container.RowHeadersWidth = 60;
            this.data_container.Size = new System.Drawing.Size(811, 247);
            this.data_container.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 331);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Records can be only deleted/updated with id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_container);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.fNameInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.lNameInput);
            this.Controls.Add(this.email);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.fName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_container)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox lNameInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox fNameInput;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView data_container;
        private System.Windows.Forms.Label label1;
    }
}

