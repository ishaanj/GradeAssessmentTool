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

        //EDIT THE EMPTY STRINGS HERE
        private string fromAddress = "titu1994@gmail.com";
        private string fromPassword = "zxc1234567890";

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
                    SmtpServer.Credentials = new System.Net.NetworkCredential(fromAddress, fromPassword);

                    Attachment attach = new Attachment(file);

                    mail.From = new MailAddress(fromAddress);
                    mail.To.Add(mailToBox.Text);
                    mail.Subject = "Student Report in Excel";
                    mail.Body = "Excel sheet for student report";
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
