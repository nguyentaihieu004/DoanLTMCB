using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SendMail_SMPT
{
    public partial class Đăng_nhập : Form
    {
        public Đăng_nhập()
        {
            InitializeComponent();

        }
        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
        public static class MKTK
        {
            public static string TaiKhoan { get; set; }
            public static string Matkhau { get; set; }
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new System.Net.NetworkCredential(txbTaikhoan.Text, txbMatkhau.Text);
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;

                smtpClient.Send(new MailMessage("noreply@example.com", "test@example.com", "Test subject", "Test body"));

                MKTK.TaiKhoan = txbTaikhoan.Text;
                MKTK.Matkhau = txbMatkhau.Text;
                TrangchuMail instancemail = new TrangchuMail();
                instancemail.Show();
            }
            catch 
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void displayMk_CheckedChanged(object sender, EventArgs e)
        {
            if (displayMk.Checked)
            {
                txbMatkhau.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {

                txbMatkhau.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }

        
    }
}
