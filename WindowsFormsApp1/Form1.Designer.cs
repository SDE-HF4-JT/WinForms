﻿namespace WindowsFormsApp1
{
    partial class LoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.logInButton = new System.Windows.Forms.Button();
            this.passInputBox = new System.Windows.Forms.TextBox();
            this.userInputBox = new System.Windows.Forms.TextBox();
            this.tabInbox = new System.Windows.Forms.TabPage();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.MessageTextbox = new System.Windows.Forms.RichTextBox();
            this.InboxLabel = new System.Windows.Forms.Label();
            this.InboxList = new System.Windows.Forms.ListBox();
            this.deleteMessageButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.tabSend = new System.Windows.Forms.TabPage();
            this.SMTPpanel = new System.Windows.Forms.Panel();
            this.mailPassInput = new System.Windows.Forms.TextBox();
            this.MailPasswordLabel = new System.Windows.Forms.Label();
            this.mailInput = new System.Windows.Forms.TextBox();
            this.MailLabel = new System.Windows.Forms.Label();
            this.portInput = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.SMTPLabel = new System.Windows.Forms.Label();
            this.SMTPInput = new System.Windows.Forms.TextBox();
            this.SSLCheckBox = new System.Windows.Forms.CheckBox();
            this.SSLLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.SMTPTitleLabel = new System.Windows.Forms.Label();
            this.sendMailButton = new System.Windows.Forms.Button();
            this.timeToLiveLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.carbonCopyLabel = new System.Windows.Forms.Label();
            this.recipientLabel = new System.Windows.Forms.Label();
            this.messageInput = new System.Windows.Forms.RichTextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.carbonCopyInput = new System.Windows.Forms.TextBox();
            this.recipientInput = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabInbox.SuspendLayout();
            this.tabSend.SuspendLayout();
            this.SMTPpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabInbox);
            this.tabControl1.Controls.Add(this.tabSend);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WindowBackground2_768x512;
            resources.ApplyResources(this.tabLogin, "tabLogin");
            this.tabLogin.Controls.Add(this.logInButton);
            this.tabLogin.Controls.Add(this.passInputBox);
            this.tabLogin.Controls.Add(this.userInputBox);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.UseVisualStyleBackColor = true;
            this.tabLogin.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // logInButton
            // 
            resources.ApplyResources(this.logInButton, "logInButton");
            this.logInButton.Name = "logInButton";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // passInputBox
            // 
            resources.ApplyResources(this.passInputBox, "passInputBox");
            this.passInputBox.Name = "passInputBox";
            this.passInputBox.TextChanged += new System.EventHandler(this.passInputBox_TextChanged);
            // 
            // userInputBox
            // 
            resources.ApplyResources(this.userInputBox, "userInputBox");
            this.userInputBox.Name = "userInputBox";
            this.userInputBox.TextChanged += new System.EventHandler(this.userInputBox_TextChanged);
            // 
            // tabInbox
            // 
            this.tabInbox.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WindowBackground3_768x512;
            resources.ApplyResources(this.tabInbox, "tabInbox");
            this.tabInbox.Controls.Add(this.accountNameLabel);
            this.tabInbox.Controls.Add(this.messageLabel);
            this.tabInbox.Controls.Add(this.MessageTextbox);
            this.tabInbox.Controls.Add(this.InboxLabel);
            this.tabInbox.Controls.Add(this.InboxList);
            this.tabInbox.Controls.Add(this.deleteMessageButton);
            this.tabInbox.Controls.Add(this.logOutButton);
            this.tabInbox.Name = "tabInbox";
            this.tabInbox.UseVisualStyleBackColor = true;
            // 
            // accountNameLabel
            // 
            resources.ApplyResources(this.accountNameLabel, "accountNameLabel");
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Click += new System.EventHandler(this.accountNameLabel_Click);
            // 
            // messageLabel
            // 
            resources.ApplyResources(this.messageLabel, "messageLabel");
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Click += new System.EventHandler(this.messageLabel_Click);
            // 
            // MessageTextbox
            // 
            resources.ApplyResources(this.MessageTextbox, "MessageTextbox");
            this.MessageTextbox.Name = "MessageTextbox";
            this.MessageTextbox.ReadOnly = true;
            this.MessageTextbox.TextChanged += new System.EventHandler(this.MessageTextbox_TextChanged);
            // 
            // InboxLabel
            // 
            resources.ApplyResources(this.InboxLabel, "InboxLabel");
            this.InboxLabel.Name = "InboxLabel";
            this.InboxLabel.Click += new System.EventHandler(this.InboxLabel_Click);
            // 
            // InboxList
            // 
            this.InboxList.FormattingEnabled = true;
            resources.ApplyResources(this.InboxList, "InboxList");
            this.InboxList.Name = "InboxList";
            this.InboxList.SelectedIndexChanged += new System.EventHandler(this.InboxList_SelectedIndexChanged);
            // 
            // deleteMessageButton
            // 
            resources.ApplyResources(this.deleteMessageButton, "deleteMessageButton");
            this.deleteMessageButton.Name = "deleteMessageButton";
            this.deleteMessageButton.UseVisualStyleBackColor = true;
            this.deleteMessageButton.Click += new System.EventHandler(this.deleteMessageButton_Click);
            // 
            // logOutButton
            // 
            resources.ApplyResources(this.logOutButton, "logOutButton");
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // tabSend
            // 
            this.tabSend.Controls.Add(this.SMTPpanel);
            this.tabSend.Controls.Add(this.numericUpDown1);
            this.tabSend.Controls.Add(this.SMTPTitleLabel);
            this.tabSend.Controls.Add(this.sendMailButton);
            this.tabSend.Controls.Add(this.timeToLiveLabel);
            this.tabSend.Controls.Add(this.titleLabel);
            this.tabSend.Controls.Add(this.carbonCopyLabel);
            this.tabSend.Controls.Add(this.recipientLabel);
            this.tabSend.Controls.Add(this.messageInput);
            this.tabSend.Controls.Add(this.sendMessageButton);
            this.tabSend.Controls.Add(this.titleInput);
            this.tabSend.Controls.Add(this.carbonCopyInput);
            this.tabSend.Controls.Add(this.recipientInput);
            resources.ApplyResources(this.tabSend, "tabSend");
            this.tabSend.Name = "tabSend";
            this.tabSend.UseVisualStyleBackColor = true;
            // 
            // SMTPpanel
            // 
            this.SMTPpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SMTPpanel.Controls.Add(this.mailPassInput);
            this.SMTPpanel.Controls.Add(this.MailPasswordLabel);
            this.SMTPpanel.Controls.Add(this.mailInput);
            this.SMTPpanel.Controls.Add(this.MailLabel);
            this.SMTPpanel.Controls.Add(this.portInput);
            this.SMTPpanel.Controls.Add(this.PortLabel);
            this.SMTPpanel.Controls.Add(this.SMTPLabel);
            this.SMTPpanel.Controls.Add(this.SMTPInput);
            this.SMTPpanel.Controls.Add(this.SSLCheckBox);
            this.SMTPpanel.Controls.Add(this.SSLLabel);
            resources.ApplyResources(this.SMTPpanel, "SMTPpanel");
            this.SMTPpanel.Name = "SMTPpanel";
            // 
            // mailPassInput
            // 
            resources.ApplyResources(this.mailPassInput, "mailPassInput");
            this.mailPassInput.Name = "mailPassInput";
            this.mailPassInput.TextChanged += new System.EventHandler(this.mailPassInput_TextChanged);
            // 
            // MailPasswordLabel
            // 
            resources.ApplyResources(this.MailPasswordLabel, "MailPasswordLabel");
            this.MailPasswordLabel.Name = "MailPasswordLabel";
            this.MailPasswordLabel.Click += new System.EventHandler(this.MailPasswordLabel_Click);
            // 
            // mailInput
            // 
            resources.ApplyResources(this.mailInput, "mailInput");
            this.mailInput.Name = "mailInput";
            this.mailInput.TextChanged += new System.EventHandler(this.mailInput_TextChanged);
            // 
            // MailLabel
            // 
            resources.ApplyResources(this.MailLabel, "MailLabel");
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Click += new System.EventHandler(this.MailLabel_Click);
            // 
            // portInput
            // 
            resources.ApplyResources(this.portInput, "portInput");
            this.portInput.Name = "portInput";
            this.portInput.TextChanged += new System.EventHandler(this.portInput_TextChanged_1);
            // 
            // PortLabel
            // 
            resources.ApplyResources(this.PortLabel, "PortLabel");
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Click += new System.EventHandler(this.PortLabel_Click_1);
            // 
            // SMTPLabel
            // 
            resources.ApplyResources(this.SMTPLabel, "SMTPLabel");
            this.SMTPLabel.Name = "SMTPLabel";
            this.SMTPLabel.Click += new System.EventHandler(this.SMTPLabel_Click_1);
            // 
            // SMTPInput
            // 
            resources.ApplyResources(this.SMTPInput, "SMTPInput");
            this.SMTPInput.Name = "SMTPInput";
            this.SMTPInput.TextChanged += new System.EventHandler(this.SMTPInput_TextChanged_1);
            // 
            // SSLCheckBox
            // 
            resources.ApplyResources(this.SSLCheckBox, "SSLCheckBox");
            this.SSLCheckBox.Name = "SSLCheckBox";
            this.SSLCheckBox.UseVisualStyleBackColor = true;
            this.SSLCheckBox.CheckedChanged += new System.EventHandler(this.SSLCheckBox_CheckedChanged_1);
            // 
            // SSLLabel
            // 
            resources.ApplyResources(this.SSLLabel, "SSLLabel");
            this.SSLLabel.Name = "SSLLabel";
            this.SSLLabel.Click += new System.EventHandler(this.SSLLabel_Click_1);
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // SMTPTitleLabel
            // 
            resources.ApplyResources(this.SMTPTitleLabel, "SMTPTitleLabel");
            this.SMTPTitleLabel.Name = "SMTPTitleLabel";
            this.SMTPTitleLabel.Click += new System.EventHandler(this.SMTPTitleLabel_Click);
            // 
            // sendMailButton
            // 
            resources.ApplyResources(this.sendMailButton, "sendMailButton");
            this.sendMailButton.Name = "sendMailButton";
            this.sendMailButton.UseVisualStyleBackColor = true;
            this.sendMailButton.Click += new System.EventHandler(this.sendMailButton_Click);
            // 
            // timeToLiveLabel
            // 
            resources.ApplyResources(this.timeToLiveLabel, "timeToLiveLabel");
            this.timeToLiveLabel.Name = "timeToLiveLabel";
            this.timeToLiveLabel.Click += new System.EventHandler(this.timeToLiveLabel_Click);
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // carbonCopyLabel
            // 
            resources.ApplyResources(this.carbonCopyLabel, "carbonCopyLabel");
            this.carbonCopyLabel.Name = "carbonCopyLabel";
            this.carbonCopyLabel.Click += new System.EventHandler(this.carbonCopyLabel_Click);
            // 
            // recipientLabel
            // 
            resources.ApplyResources(this.recipientLabel, "recipientLabel");
            this.recipientLabel.Name = "recipientLabel";
            this.recipientLabel.Click += new System.EventHandler(this.recipientLabel_Click);
            // 
            // messageInput
            // 
            resources.ApplyResources(this.messageInput, "messageInput");
            this.messageInput.Name = "messageInput";
            this.messageInput.TextChanged += new System.EventHandler(this.messageInput_TextChanged);
            // 
            // sendMessageButton
            // 
            resources.ApplyResources(this.sendMessageButton, "sendMessageButton");
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // titleInput
            // 
            resources.ApplyResources(this.titleInput, "titleInput");
            this.titleInput.Name = "titleInput";
            this.titleInput.TextChanged += new System.EventHandler(this.titleInput_TextChanged);
            // 
            // carbonCopyInput
            // 
            resources.ApplyResources(this.carbonCopyInput, "carbonCopyInput");
            this.carbonCopyInput.Name = "carbonCopyInput";
            this.carbonCopyInput.TextChanged += new System.EventHandler(this.carbonCopyInput_TextChanged);
            // 
            // recipientInput
            // 
            resources.ApplyResources(this.recipientInput, "recipientInput");
            this.recipientInput.Name = "recipientInput";
            this.recipientInput.TextChanged += new System.EventHandler(this.recipientInput_TextChanged);
            // 
            // LoginWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginWindow";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabInbox.ResumeLayout(false);
            this.tabInbox.PerformLayout();
            this.tabSend.ResumeLayout(false);
            this.tabSend.PerformLayout();
            this.SMTPpanel.ResumeLayout(false);
            this.SMTPpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.TextBox userInputBox;
        private System.Windows.Forms.TextBox passInputBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabInbox;
        private System.Windows.Forms.TabPage tabSend;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.RichTextBox MessageTextbox;
        private System.Windows.Forms.Label InboxLabel;
        private System.Windows.Forms.ListBox InboxList;
        private System.Windows.Forms.Button deleteMessageButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label timeToLiveLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label carbonCopyLabel;
        private System.Windows.Forms.Label recipientLabel;
        private System.Windows.Forms.RichTextBox messageInput;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.TextBox carbonCopyInput;
        private System.Windows.Forms.TextBox recipientInput;
        private System.Windows.Forms.Label SSLLabel;
        private System.Windows.Forms.CheckBox SSLCheckBox;
        private System.Windows.Forms.TextBox SMTPInput;
        private System.Windows.Forms.Label SMTPLabel;
        private System.Windows.Forms.TextBox portInput;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Button sendMailButton;
        private System.Windows.Forms.Panel SMTPpanel;
        private System.Windows.Forms.TextBox mailPassInput;
        private System.Windows.Forms.Label MailPasswordLabel;
        private System.Windows.Forms.TextBox mailInput;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.Label SMTPTitleLabel;
    }
}

