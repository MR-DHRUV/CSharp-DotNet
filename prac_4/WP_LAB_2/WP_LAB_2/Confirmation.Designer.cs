namespace WP_LAB_2
{
    partial class Confirmation
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.servicesBox = new System.Windows.Forms.GroupBox();
            this.tranRepLabel = new System.Windows.Forms.Label();
            this.repLabel = new System.Windows.Forms.Label();
            this.smsLabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.Label();
            this.lNameContainer = new System.Windows.Forms.Label();
            this.emailNameContainer = new System.Windows.Forms.Label();
            this.fNameContainer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.servicesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(96, 821);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(149, 64);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // servicesBox
            // 
            this.servicesBox.Controls.Add(this.tranRepLabel);
            this.servicesBox.Controls.Add(this.repLabel);
            this.servicesBox.Controls.Add(this.smsLabel);
            this.servicesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.servicesBox.Location = new System.Drawing.Point(96, 470);
            this.servicesBox.Name = "servicesBox";
            this.servicesBox.Size = new System.Drawing.Size(702, 293);
            this.servicesBox.TabIndex = 10;
            this.servicesBox.TabStop = false;
            this.servicesBox.Text = "Opted Services";
            // 
            // tranRepLabel
            // 
            this.tranRepLabel.AutoSize = true;
            this.tranRepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tranRepLabel.Location = new System.Drawing.Point(40, 213);
            this.tranRepLabel.Name = "tranRepLabel";
            this.tranRepLabel.Size = new System.Drawing.Size(283, 32);
            this.tranRepLabel.TabIndex = 6;
            this.tranRepLabel.Text = "Transacion Reports : ";
            // 
            // repLabel
            // 
            this.repLabel.AutoSize = true;
            this.repLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repLabel.Location = new System.Drawing.Point(40, 154);
            this.repLabel.Name = "repLabel";
            this.repLabel.Size = new System.Drawing.Size(135, 32);
            this.repLabel.TabIndex = 6;
            this.repLabel.Text = "Reports : ";
            // 
            // smsLabel
            // 
            this.smsLabel.AutoSize = true;
            this.smsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smsLabel.Location = new System.Drawing.Point(40, 88);
            this.smsLabel.Name = "smsLabel";
            this.smsLabel.Size = new System.Drawing.Size(261, 32);
            this.smsLabel.TabIndex = 6;
            this.smsLabel.Text = "SMS Notifications : ";
            this.smsLabel.Click += new System.EventHandler(this.smsLabel_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(90, 378);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(219, 32);
            this.email.TabIndex = 4;
            this.email.Text = "Email Address : ";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(90, 267);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(172, 32);
            this.LName.TabIndex = 5;
            this.LName.Text = "Last Name : ";
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(90, 156);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(173, 32);
            this.fName.TabIndex = 6;
            this.fName.Text = "First Name : ";
            // 
            // lNameContainer
            // 
            this.lNameContainer.AutoSize = true;
            this.lNameContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameContainer.Location = new System.Drawing.Point(337, 267);
            this.lNameContainer.Name = "lNameContainer";
            this.lNameContainer.Size = new System.Drawing.Size(0, 32);
            this.lNameContainer.TabIndex = 6;
            this.lNameContainer.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailNameContainer
            // 
            this.emailNameContainer.AutoSize = true;
            this.emailNameContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailNameContainer.Location = new System.Drawing.Point(337, 378);
            this.emailNameContainer.Name = "emailNameContainer";
            this.emailNameContainer.Size = new System.Drawing.Size(0, 32);
            this.emailNameContainer.TabIndex = 6;
            this.emailNameContainer.Click += new System.EventHandler(this.label1_Click);
            // 
            // fNameContainer
            // 
            this.fNameContainer.AutoSize = true;
            this.fNameContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameContainer.Location = new System.Drawing.Point(337, 156);
            this.fNameContainer.Name = "fNameContainer";
            this.fNameContainer.Size = new System.Drawing.Size(0, 32);
            this.fNameContainer.TabIndex = 6;
            this.fNameContainer.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1021, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = "Thanks for signing up! We\'ll be in touch soon";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 1016);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.servicesBox);
            this.Controls.Add(this.email);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.fNameContainer);
            this.Controls.Add(this.emailNameContainer);
            this.Controls.Add(this.lNameContainer);
            this.Controls.Add(this.fName);
            this.Name = "Confirmation";
            this.Text = "Confirmation";
            this.Load += new System.EventHandler(this.Confirmation_Load);
            this.servicesBox.ResumeLayout(false);
            this.servicesBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.GroupBox servicesBox;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Label lNameContainer;
        private System.Windows.Forms.Label emailNameContainer;
        private System.Windows.Forms.Label fNameContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tranRepLabel;
        private System.Windows.Forms.Label repLabel;
        private System.Windows.Forms.Label smsLabel;
    }
}