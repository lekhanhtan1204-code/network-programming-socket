using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EmailServer_WindowForm
{
    partial class Form1 : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnStartServer = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStartServer
            // 
            this.btnStartServer.BackColor = System.Drawing.SystemColors.Info;
            this.btnStartServer.Location = new System.Drawing.Point(30, 20);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(150, 40);
            this.btnStartServer.Text = "Khởi Động Server";
            this.btnStartServer.UseVisualStyleBackColor = false;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // listBoxLog
            // 
            this.listBoxLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 20;
            this.listBoxLog.Location = new System.Drawing.Point(0, 80);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(600, 320);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.btnStartServer);
            this.Name = "Form1";
            this.Text = "Email Central Server (Multi-Process / SMTP)";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.ListBox listBoxLog;
    }
}