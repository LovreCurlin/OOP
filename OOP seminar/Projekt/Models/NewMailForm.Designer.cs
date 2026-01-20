namespace Projekt.Models
{
    partial class NewMailForm
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
            components = new System.ComponentModel.Container();
            Send = new Button();
            Cancel = new Button();
            MailBody = new TextBox();
            MailSubject = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            toolStripSeparator1 = new ToolStripSeparator();
            UserList = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // Send
            // 
            Send.Location = new Point(1147, 683);
            Send.Name = "Send";
            Send.Size = new Size(174, 74);
            Send.TabIndex = 0;
            Send.Text = "Sand";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(967, 683);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(174, 74);
            Cancel.TabIndex = 1;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // MailBody
            // 
            MailBody.Location = new Point(84, 195);
            MailBody.Multiline = true;
            MailBody.Name = "MailBody";
            MailBody.PlaceholderText = "Mail body....";
            MailBody.Size = new Size(1202, 456);
            MailBody.TabIndex = 4;
            MailBody.WordWrap = false;
            // 
            // MailSubject
            // 
            MailSubject.Location = new Point(176, 128);
            MailSubject.Name = "MailSubject";
            MailSubject.Size = new Size(993, 35);
            MailSubject.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(28, 28);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(28, 28);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { toolStripSeparator1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 10);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(57, 6);
            // 
            // UserList
            // 
            UserList.DropDownStyle = ComboBoxStyle.DropDownList;
            UserList.FormattingEnabled = true;
            UserList.Location = new Point(175, 55);
            UserList.Name = "UserList";
            UserList.Size = new Size(993, 38);
            UserList.TabIndex = 6;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 58);
            label1.Name = "label1";
            label1.Size = new Size(83, 30);
            label1.TabIndex = 7;
            label1.Text = "Mail to:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 128);
            label2.Name = "label2";
            label2.Size = new Size(86, 30);
            label2.TabIndex = 8;
            label2.Text = "Subject:";
            // 
            // NewMailForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1422, 791);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UserList);
            Controls.Add(MailSubject);
            Controls.Add(MailBody);
            Controls.Add(Cancel);
            Controls.Add(Send);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NewMailForm";
            Text = "NewMailForm";
            FormClosing += NewMailForm_FormClosing;
            contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Send;
        private Button Cancel;
        private TextBox MailBody;
        private TextBox MailSubject;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripSeparator toolStripSeparator1;
        private ComboBox UserList;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Label label2;
        private Label label1;
    }
}