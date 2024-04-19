using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using static SendMail_SMPT.Đăng_nhập;

namespace SendMail_SMPT
{
    public partial class TrangchuMail : Form
    {
        public TrangchuMail()
        {
            InitializeComponent();
            GetMail();
        }
        public class EmailInfo
        {
            public string Id { get; set; }
            public string From { get; set; }
            public DateTimeOffset TimeReceive { get; set; }
            public string Subject { get; set; }
            public string Body { get; set; }
            public string FileAttactment { get; set; }
        }
        private void btSendMail_Click(object sender, EventArgs e)
        {
            SendMail instanceSend= new SendMail();
            instanceSend.Show();
        }
        private async void GetMail()
        {
            string textTK = MKTK.TaiKhoan;
            string textMK = MKTK.Matkhau;
            
                var listEmail = new List<EmailInfo>();
                var mailClient = new ImapClient();
                mailClient.Connect("imap.gmail.com", 993);
                mailClient.Authenticate(textTK, textMK);
                var folder = await mailClient.GetFolderAsync("Inbox");
                await folder.OpenAsync(FolderAccess.ReadWrite);
                int emailCount = 0;

            IList<UniqueId> emailIds = folder.Search(SearchQuery.All);

            emailIds = emailIds.OrderByDescending(uid => folder.GetMessage(uid).Date).ToList();

            foreach (UniqueId emailId in emailIds)
                {
                    if (emailCount >= int.Parse("20"))
                    {
                        break;
                    }

                    MimeMessage message = folder.GetMessage(emailId);
                    var emailInfo = new EmailInfo();
                    emailInfo.Id=emailId.ToString();
                    emailInfo.From=message.From.ToString();
                    emailInfo.TimeReceive = message.Date;
                    emailInfo.Subject = message.Subject;
                    emailInfo.Body=message.TextBody;

                    var fileAttachment =new List<string>();

                    foreach(MimeEntity attachment in message.Attachments)
                    {
                        var fileName = attachment.ContentDisposition?.FileName ?? attachment.ContentType.Name;
                        fileAttachment.Add(fileName);

                        using (var stream = new FileStream(fileName, FileMode.Create))
                        {
                            if(attachment is MessagePart)
                            {
                                var rfc822=(MessagePart)attachment;
                                rfc822.Message.WriteTo(stream);

                            }
                            else
                            {
                                var part = (MimePart)attachment;
                                part.Content.DecodeTo(stream);
                            }

                        }
                    }
                    emailInfo.FileAttactment=string.Join("; ", fileAttachment);
                    listEmail.Add(emailInfo);
                    emailCount++;
                }
                dataGridView1.CellClick += DataGridView1_CellClick;
                dataGridView1.DataSource = listEmail;
            
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var emailInfo = dataGridView1.Rows[e.RowIndex].DataBoundItem as EmailInfo;
                if (emailInfo != null)
                {
                    richTextBox1.Text = $"From: {emailInfo.From}\nSubject: {emailInfo.Subject}\nTime Receive: {emailInfo.TimeReceive}\n\n{emailInfo.Body}";
                }
            }
        }
    }
}
