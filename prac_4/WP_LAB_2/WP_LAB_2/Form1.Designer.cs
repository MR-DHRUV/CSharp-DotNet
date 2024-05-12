namespace WP_LAB_2
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
            this.smsNoti = new System.Windows.Forms.CheckBox();
            this.reports = new System.Windows.Forms.CheckBox();
            this.transactionReports = new System.Windows.Forms.CheckBox();
            this.servicesBox = new System.Windows.Forms.GroupBox();
            this.signupBtn = new System.Windows.Forms.Button();
            this.servicesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(65, 75);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(173, 32);
            this.fName.TabIndex = 0;
            this.fName.Text = "First Name : ";
            this.fName.Click += new System.EventHandler(this.fName_Click);
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(65, 186);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(172, 32);
            this.LName.TabIndex = 0;
            this.LName.Text = "Last Name : ";
            this.LName.Click += new System.EventHandler(this.LName_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(65, 297);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(219, 32);
            this.email.TabIndex = 0;
            this.email.Text = "Email Address : ";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // lNameInput
            // 
            this.lNameInput.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameInput.Location = new System.Drawing.Point(356, 177);
            this.lNameInput.Name = "lNameInput";
            this.lNameInput.Size = new System.Drawing.Size(417, 41);
            this.lNameInput.TabIndex = 1;
            this.lNameInput.TextChanged += new System.EventHandler(this.lNameInput_TextChanged);
            // 
            // emailInput
            // 
            this.emailInput.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInput.Location = new System.Drawing.Point(356, 288);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(417, 41);
            this.emailInput.TabIndex = 1;
            this.emailInput.TextChanged += new System.EventHandler(this.emailInput_TextChanged);
            // 
            // fNameInput
            // 
            this.fNameInput.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameInput.Location = new System.Drawing.Point(356, 66);
            this.fNameInput.Name = "fNameInput";
            this.fNameInput.Size = new System.Drawing.Size(417, 41);
            this.fNameInput.TabIndex = 1;
            this.fNameInput.TextChanged += new System.EventHandler(this.fNameInput_TextChanged);
            // 
            // smsNoti
            // 
            this.smsNoti.AutoSize = true;
            this.smsNoti.Location = new System.Drawing.Point(45, 62);
            this.smsNoti.Name = "smsNoti";
            this.smsNoti.Size = new System.Drawing.Size(265, 36);
            this.smsNoti.TabIndex = 1;
            this.smsNoti.Text = "SMS Notifications";
            this.smsNoti.UseVisualStyleBackColor = true;
            this.smsNoti.CheckedChanged += new System.EventHandler(this.smsNoti_CheckedChanged);
            // 
            // reports
            // 
            this.reports.AutoSize = true;
            this.reports.Location = new System.Drawing.Point(45, 143);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(139, 36);
            this.reports.TabIndex = 1;
            this.reports.Text = "Reports";
            this.reports.UseVisualStyleBackColor = true;
            this.reports.CheckedChanged += new System.EventHandler(this.reports_CheckedChanged);
            // 
            // transactionReports
            // 
            this.transactionReports.AutoSize = true;
            this.transactionReports.Location = new System.Drawing.Point(45, 224);
            this.transactionReports.Name = "transactionReports";
            this.transactionReports.Size = new System.Drawing.Size(295, 36);
            this.transactionReports.TabIndex = 1;
            this.transactionReports.Text = "Transaction Reports";
            this.transactionReports.UseVisualStyleBackColor = true;
            this.transactionReports.CheckedChanged += new System.EventHandler(this.transactionReports_CheckedChanged);
            // 
            // servicesBox
            // 
            this.servicesBox.Controls.Add(this.transactionReports);
            this.servicesBox.Controls.Add(this.reports);
            this.servicesBox.Controls.Add(this.smsNoti);
            this.servicesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.servicesBox.Location = new System.Drawing.Point(71, 389);
            this.servicesBox.Name = "servicesBox";
            this.servicesBox.Size = new System.Drawing.Size(702, 293);
            this.servicesBox.TabIndex = 2;
            this.servicesBox.TabStop = false;
            this.servicesBox.Text = "Services";
            this.servicesBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // signupBtn
            // 
            this.signupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.Location = new System.Drawing.Point(71, 740);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(149, 64);
            this.signupBtn.TabIndex = 3;
            this.signupBtn.Text = "Signup";
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 858);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.servicesBox);
            this.Controls.Add(this.fNameInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.lNameInput);
            this.Controls.Add(this.email);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.fName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.servicesBox.ResumeLayout(false);
            this.servicesBox.PerformLayout();
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
        private System.Windows.Forms.CheckBox smsNoti;
        private System.Windows.Forms.CheckBox reports;
        private System.Windows.Forms.CheckBox transactionReports;
        private System.Windows.Forms.GroupBox servicesBox;
        private System.Windows.Forms.Button signupBtn;
    }
}

