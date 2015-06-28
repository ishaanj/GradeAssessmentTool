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
        String id, pwd;

        public MailForm(String id, String pwd)
        {
            this.id = id;
            this.pwd = pwd;
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
                MessageBox.Show("Enter an email address");
            else if (file == null || file == "")
                MessageBox.Show("Add an attachment");

            else
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    SmtpServer.Port = 587;
                    SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                    SmtpServer.EnableSsl = true;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(id, pwd);

                    Attachment attach = new Attachment(file);

                    mail.From = new MailAddress(id);
                    mail.To.Add(mailToBox.Text);

                    if (mailSub.Text == "" || mailSub.Text == null)
                        mail.Body = "Student Report in Excel";
                    else
                        mail.Body = mailBody.Text;
                    
                    if (mailBody.Text == "" || mailBody.Text == null)
                        mail.Body = "Excel sheet for student report";
                    else
                        mail.Body = mailBody.Text;

                    mail.Attachments.Add(attach);

                    SmtpServer.Send(mail);
                    MessageBox.Show("Mail sent to : " + mailToBox.Text.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            StartTeacherForm sf = new StartTeacherForm();
            sf.Show();
            this.Hide();
        }
    }
}
