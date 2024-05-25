namespace c_sharp_db
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
            this.label1 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.idInput = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.fNameInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.lNameInput = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.Label();
            this.data_container = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_container)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 314);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Records can be only deleted/updated with id";
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(339, 265);
            this.delete.Margin = new System.Windows.Forms.Padding(2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(81, 35);
            this.delete.TabIndex = 20;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(191, 265);
            this.update.Margin = new System.Windows.Forms.Padding(2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(81, 35);
            this.update.TabIndex = 19;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // idInput
            // 
            this.idInput.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idInput.Location = new System.Drawing.Point(191, 32);
            this.idInput.Margin = new System.Windows.Forms.Padding(2);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(229, 27);
            this.idInput.TabIndex = 18;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(32, 37);
            this.id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(23, 20);
            this.id.TabIndex = 17;
            this.id.Text = "Id";
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.Location = new System.Drawing.Point(36, 265);
            this.Insert.Margin = new System.Windows.Forms.Padding(2);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(81, 35);
            this.Insert.TabIndex = 16;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // fNameInput
            // 
            this.fNameInput.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameInput.Location = new System.Drawing.Point(191, 85);
            this.fNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.fNameInput.Name = "fNameInput";
            this.fNameInput.Size = new System.Drawing.Size(229, 27);
            this.fNameInput.TabIndex = 13;
            // 
            // emailInput
            // 
            this.emailInput.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInput.Location = new System.Drawing.Point(191, 205);
            this.emailInput.Margin = new System.Windows.Forms.Padding(2);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(229, 27);
            this.emailInput.TabIndex = 14;
            // 
            // lNameInput
            // 
            this.lNameInput.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameInput.Location = new System.Drawing.Point(191, 145);
            this.lNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.lNameInput.Name = "lNameInput";
            this.lNameInput.Size = new System.Drawing.Size(229, 27);
            this.lNameInput.TabIndex = 15;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(32, 210);
            this.email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(123, 20);
            this.email.TabIndex = 10;
            this.email.Text = "Email Address : ";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(32, 150);
            this.LName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(98, 20);
            this.LName.TabIndex = 11;
            this.LName.Text = "Last Name : ";
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(32, 90);
            this.fName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(98, 20);
            this.fName.TabIndex = 12;
            this.fName.Text = "First Name : ";
            // 
            // data_container
            // 
            this.data_container.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_container.BackgroundColor = System.Drawing.SystemColors.Control;
            this.data_container.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_container.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_container.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.data_container.Location = new System.Drawing.Point(0, 377);
            this.data_container.Name = "data_container";
            this.data_container.RowHeadersWidth = 60;
            this.data_container.Size = new System.Drawing.Size(866, 247);
            this.data_container.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 624);
            this.Controls.Add(this.data_container);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.id);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.fNameInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.lNameInput);
            this.Controls.Add(this.email);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.fName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_container)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox fNameInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox lNameInput;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.DataGridView data_container;
    }
}

