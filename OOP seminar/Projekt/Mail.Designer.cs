namespace Projekt
{
    partial class Mail
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
            menuStrip1 = new MenuStrip();
            profileToolStripMenuItem = new ToolStripMenuItem();
            PersonalDataToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            deleteProfileToolStripMenuItem = new ToolStripMenuItem();
            newMailToolStripMenuItem = new ToolStripMenuItem();
            deliverdToolStripMenuItem = new ToolStripMenuItem();
            sentToolStripMenuItem = new ToolStripMenuItem();
            deletedToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            registrationBindingSource = new BindingSource(components);
            MailTextBox = new TextBox();
            MailList = new ListView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)registrationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AllowItemReorder = true;
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { profileToolStripMenuItem, newMailToolStripMenuItem, deliverdToolStripMenuItem, sentToolStripMenuItem, deletedToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(200, 1100);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.AutoSize = false;
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PersonalDataToolStripMenuItem, changePasswordToolStripMenuItem, deleteProfileToolStripMenuItem });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(196, 60);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // PersonalDataToolStripMenuItem
            // 
            PersonalDataToolStripMenuItem.Name = "PersonalDataToolStripMenuItem";
            PersonalDataToolStripMenuItem.Size = new Size(295, 40);
            PersonalDataToolStripMenuItem.Text = "Personal data";
            PersonalDataToolStripMenuItem.Click += PersonalDataToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(295, 40);
            changePasswordToolStripMenuItem.Text = "Change password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // deleteProfileToolStripMenuItem
            // 
            deleteProfileToolStripMenuItem.Name = "deleteProfileToolStripMenuItem";
            deleteProfileToolStripMenuItem.Size = new Size(295, 40);
            deleteProfileToolStripMenuItem.Text = "Delete profile";
            deleteProfileToolStripMenuItem.Click += deleteProfileToolStripMenuItem_Click;
            // 
            // newMailToolStripMenuItem
            // 
            newMailToolStripMenuItem.AutoSize = false;
            newMailToolStripMenuItem.Name = "newMailToolStripMenuItem";
            newMailToolStripMenuItem.Size = new Size(196, 60);
            newMailToolStripMenuItem.Text = "New mail";
            newMailToolStripMenuItem.Click += newMailToolStripMenuItem_Click;
            // 
            // deliverdToolStripMenuItem
            // 
            deliverdToolStripMenuItem.AutoSize = false;
            deliverdToolStripMenuItem.Name = "deliverdToolStripMenuItem";
            deliverdToolStripMenuItem.Size = new Size(196, 60);
            deliverdToolStripMenuItem.Text = "Inbox";
            deliverdToolStripMenuItem.Click += deliverdToolStripMenuItem_Click;
            // 
            // sentToolStripMenuItem
            // 
            sentToolStripMenuItem.AutoSize = false;
            sentToolStripMenuItem.Name = "sentToolStripMenuItem";
            sentToolStripMenuItem.Size = new Size(196, 60);
            sentToolStripMenuItem.Text = "Sent";
            sentToolStripMenuItem.Click += sentToolStripMenuItem_Click;
            // 
            // deletedToolStripMenuItem
            // 
            deletedToolStripMenuItem.AutoSize = false;
            deletedToolStripMenuItem.Name = "deletedToolStripMenuItem";
            deletedToolStripMenuItem.Size = new Size(196, 60);
            deletedToolStripMenuItem.Text = "Deleted";
            deletedToolStripMenuItem.Click += deletedToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.AutoSize = false;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.ShowShortcutKeys = false;
            logoutToolStripMenuItem.Size = new Size(196, 60);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // registrationBindingSource
            // 
            registrationBindingSource.DataSource = typeof(Registration);
            // 
            // MailTextBox
            // 
            MailTextBox.Location = new Point(1004, 59);
            MailTextBox.Multiline = true;
            MailTextBox.Name = "MailTextBox";
            MailTextBox.Size = new Size(892, 992);
            MailTextBox.TabIndex = 3;
            // 
            // MailList
            // 
            MailList.GridLines = true;
            MailList.Location = new Point(207, 59);
            MailList.Name = "MailList";
            MailList.Size = new Size(770, 900);
            MailList.TabIndex = 5;
            MailList.UseCompatibleStateImageBehavior = false;
            MailList.View = View.List;
            MailList.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(207, 965);
            button1.Name = "button1";
            button1.Size = new Size(380, 40);
            button1.TabIndex = 6;
            button1.Text = "Select all";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(597, 965);
            button2.Name = "button2";
            button2.Size = new Size(380, 40);
            button2.TabIndex = 7;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(597, 1011);
            button3.Name = "button3";
            button3.Size = new Size(380, 40);
            button3.TabIndex = 8;
            button3.Text = "Mark as unread";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(207, 1011);
            button4.Name = "button4";
            button4.Size = new Size(380, 40);
            button4.TabIndex = 9;
            button4.Text = "Mark as read";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(597, 965);
            button5.Name = "button5";
            button5.Size = new Size(380, 40);
            button5.TabIndex = 10;
            button5.Text = "Recover";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Mail
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1956, 1100);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(MailList);
            Controls.Add(menuStrip1);
            Controls.Add(MailTextBox);
            Controls.Add(button5);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Mail";
            Text = "Mail";
           
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)registrationBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private BindingSource registrationBindingSource;
       
        private TextBox MailTextBox;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem newMailToolStripMenuItem;
        private ToolStripMenuItem sentToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem deliverdToolStripMenuItem;
        private ToolStripMenuItem PersonalDataToolStripMenuItem;
        private ToolStripMenuItem deleteProfileToolStripMenuItem;
        private ListView MailList;
        private Button button1;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private Button button2;
        private Button button3;
        private Button button4;
        private ToolStripMenuItem deletedToolStripMenuItem;
        private Button button5;
    }
}