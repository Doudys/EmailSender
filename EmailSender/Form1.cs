using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace EmailSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btn_sendemail_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txt_EmailFrom.Text)) 
                {
                    MessageBox.Show("You must provide an sender email address"
                                            , "Sender email address missing"
                                            , MessageBoxButtons.OK
                                            , MessageBoxIcon.Exclamation);
                    return;
                }

                else

                if (!txt_EmailFrom.Text.Contains("@outlook.com"))
                {
                    MessageBox.Show("You must provide an outlook.com email address"
                                        , "Incorrect email address"
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Error);
                    return;
                }
                    

                if (String.IsNullOrEmpty(txt_Recipient.Text))
                {
                    MessageBox.Show("You must provide a recipient to the message"
                                    , "Empty Email address"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Information
                                    );
                    return;
                }

                btn_sendemail.Enabled = false;
                MailMessage message = new MailMessage();
                message.From = new MailAddress(txt_EmailFrom.Text);

              
                message.Subject = txt_Subject.Text;
                message.Body = txt_Body.Text;

                foreach (string s in txt_Recipient.Text.Split(';'))
                    message.To.Add(s);

                if (String.IsNullOrEmpty(txt_password.Text))
                {
                    MessageBox.Show("Please provide a password to send the message"
                                    , "Missing password"
                                    );
                }
                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential(txt_EmailFrom.Text, txt_password.Text);
                client.Host = "smtp-mail.outlook.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Send(message);
            }
            catch { MessageBox.Show("There was an error sending your message. \r\n Make sure to type in your credentials correctly."
                                        , "Error"
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Error); 
                    }
            finally { btn_sendemail.Enabled = true; }
        }

    }
}
