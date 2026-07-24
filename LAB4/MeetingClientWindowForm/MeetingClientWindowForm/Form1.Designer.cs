namespace MeetingClientWindowForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUser = new Label();
            txtUser = new TextBox();
            btnConnect = new Button();
            listBoxMediaView = new ListBox();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(78, 64);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(85, 20);
            lblUser.TabIndex = 0;
            lblUser.Text = "Tên hiển thị";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(78, 100);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(125, 27);
            txtUser.TabIndex = 1;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = SystemColors.Info;
            btnConnect.ForeColor = SystemColors.ActiveCaptionText;
            btnConnect.Location = new Point(78, 153);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(94, 29);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "vào phòng";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click_1;
            // 
            // listBoxMediaView
            // 
            listBoxMediaView.FormattingEnabled = true;
            listBoxMediaView.Location = new Point(414, 78);
            listBoxMediaView.Name = "listBoxMediaView";
            listBoxMediaView.Size = new Size(305, 144);
            listBoxMediaView.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxMediaView);
            Controls.Add(btnConnect);
            Controls.Add(txtUser);
            Controls.Add(lblUser);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private TextBox txtUser;
        private Button btnConnect;
        private ListBox listBoxMediaView;
    }
}