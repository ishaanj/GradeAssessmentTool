using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace MathsGradeAssessmentTool.Forms
{
    public partial class MailForm : Form
    {

        String file;

        public MailForm()
        {
            InitializeComponent();
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                file = openFileDialog1.FileName;
                try
                {
                    fileBox.Text = file;
                }
                catch (IOException)
                {
                }
            }
        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            if (mailToBox.Text == null || mailToBox.Text == "")
                Console.WriteLine("enter an email address");
            else if (file == null || file == "")
                Console.WriteLine("Add an attachment");
            else
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    Attachment attach = new Attachment(file);

                    mail.From = new MailAddress("ishjain@hotmail.com");
                    mail.To.Add(mailToBox.Text);
                    mail.Subject = "Student Report in Excel";
                    mail.Body = "Excel sheet for student report";
                    mail.Attachments.Add(attach);

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("username","password");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("mail Sent");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
