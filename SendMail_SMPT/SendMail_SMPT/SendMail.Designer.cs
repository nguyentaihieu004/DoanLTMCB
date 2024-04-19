namespace SendMail_SMPT
{
    partial class SendMail
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
            this.txbTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSubject = new System.Windows.Forms.TextBox();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.locationfile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đến";
            // 
            // txbTo
            // 
            this.txbTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTo.Location = new System.Drawing.Point(121, 16);
            this.txbTo.Name = "txbTo";
            this.txbTo.Size = new System.Drawing.Size(656, 22);
            this.txbTo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiêu đề";
            // 
            // txbSubject
            // 
            this.txbSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSubject.Location = new System.Drawing.Point(121, 63);
            this.txbSubject.Name = "txbSubject";
            this.txbSubject.Size = new System.Drawing.Size(656, 22);
            this.txbSubject.TabIndex = 3;
            // 
            // txbMessage
            // 
            this.txbMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMessage.Location = new System.Drawing.Point(17, 103);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(760, 299);
            this.txbMessage.TabIndex = 4;
            // 
            // btSend
            // 
            this.btSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSend.Location = new System.Drawing.Point(662, 409);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(115, 49);
            this.btSend.TabIndex = 5;
            this.btSend.Text = "Gửi ";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(17, 422);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 26);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Đính kèm tệp";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // locationfile
            // 
            this.locationfile.AutoSize = true;
            this.locationfile.Location = new System.Drawing.Point(172, 422);
            this.locationfile.Name = "locationfile";
            this.locationfile.Size = new System.Drawing.Size(0, 16);
            this.locationfile.TabIndex = 7;
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.locationfile);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.txbSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbTo);
            this.Controls.Add(this.label1);
            this.Name = "SendMail";
            this.Text = "SendMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSubject;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label locationfile;
    }
}