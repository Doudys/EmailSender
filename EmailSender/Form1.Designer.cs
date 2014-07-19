namespace EmailSender
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Recipient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Body = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_EmailFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_sendemail = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recipient:";
            // 
            // txt_Recipient
            // 
            this.txt_Recipient.Location = new System.Drawing.Point(12, 28);
            this.txt_Recipient.Multiline = true;
            this.txt_Recipient.Name = "txt_Recipient";
            this.txt_Recipient.Size = new System.Drawing.Size(208, 45);
            this.txt_Recipient.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txt_Recipient, "When providing multiple email addresses, you must seperate each address with a se" +
                    "mi-column.");
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject:";
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(58, 80);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(162, 20);
            this.txt_Subject.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Body:";
            // 
            // txt_Body
            // 
            this.txt_Body.Location = new System.Drawing.Point(19, 128);
            this.txt_Body.Multiline = true;
            this.txt_Body.Name = "txt_Body";
            this.txt_Body.Size = new System.Drawing.Size(201, 126);
            this.txt_Body.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // txt_EmailFrom
            // 
            this.txt_EmailFrom.Location = new System.Drawing.Point(44, 19);
            this.txt_EmailFrom.Name = "txt_EmailFrom";
            this.txt_EmailFrom.Size = new System.Drawing.Size(151, 20);
            this.txt_EmailFrom.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(72, 45);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(123, 20);
            this.txt_password.TabIndex = 10;
            // 
            // btn_sendemail
            // 
            this.btn_sendemail.Image = ((System.Drawing.Image)(resources.GetObject("btn_sendemail.Image")));
            this.btn_sendemail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sendemail.Location = new System.Drawing.Point(121, 351);
            this.btn_sendemail.Name = "btn_sendemail";
            this.btn_sendemail.Size = new System.Drawing.Size(99, 30);
            this.btn_sendemail.TabIndex = 11;
            this.btn_sendemail.Text = "Send Email";
            this.btn_sendemail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sendemail.UseVisualStyleBackColor = true;
            this.btn_sendemail.Click += new System.EventHandler(this.btn_sendemail_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_EmailFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(19, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 76);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credentials";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 393);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_sendemail);
            this.Controls.Add(this.txt_Body);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Subject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Recipient);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Recipient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Body;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_EmailFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_sendemail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

