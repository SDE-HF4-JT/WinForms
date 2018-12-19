using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp1
{
    //TODO:
    // Krypter password og besked! XML

    public partial class LoginWindow : Form
    {
        private SqlConnection sqlConnect = new SqlConnection();

        //--- OnLogin ---//
        //private string accountUsername = userInputBox.Text; //Org
        private string accountUsername; //Temp
        private string AccountUsernameGetSet { get => userInputBox.Text; set => accountUsername = value; } //Temp / Better?

        //private string accountPassword = passInputBox.Text; //Org
        private string accountPassword; //Temp
        private string AccountPasswordGetSet { get => passInputBox.Text; set => accountPassword = value; } // -||-

        //--- OnInbox ---//
        //x

        //--- OnSend ---//
        //private string recipientString = recipientInput.Text; //Org
        private string recipientString; //Temp
        private string RecipientGetSet { get => recipientInput.Text; set => recipientString = value; } // -||-

        //private string titleString = titleInput.Text; //Org
        private string titleString; //Temp
        private string TitleGetSet { get => titleInput.Text; set => titleString = value; } // -||-

        //private string messageString = messageInput.Text; //Org
        private string messageString; //Temp
        private string MessageGetSet { get => messageInput.Text; set => messageString = value; } // -||-

        //private Int32 timeToLiveInt = (int)numericUpDown1.Value; //Org
        private Int32 timeToLiveInt; //Temp
        private Int32 TimeToLiveIntGetSet { get => (int)numericUpDown1.Value; set => timeToLiveInt = value; } // -||-

        //SMTP
        private NetworkCredential login;
        private SmtpClient client;
        private MailMessage msg;

        //--- Other ---//
        public LoginWindow()
        {
            InitializeComponent();

            //Disable/Enable tabs:
            ((Control)this.tabInbox).Enabled = false;
            ((Control)this.tabSend).Enabled = false;

            //Clear code related textLabels:
            accountNameLabel.Text = "";
        }
        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        //Test
        private void LoginWindow_Exit(object sender, EventArgs e)
        {

        }

        //--------------------------- FORM 1 : Login -------------------------//
        //* Label *//
        private void PortLabel_Click(object sender, EventArgs e)
        {

        }
        private void SMTPLabel_Click(object sender, EventArgs e)
        {

        }
        private void SSLLabel_Click(object sender, EventArgs e)
        {

        }

        //* Tabs *//
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //* Input fields *//
        private void userInputBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void passInputBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void PortInputBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void SMTPInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        //* CheckBox *//
        private void SSLCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        //* Buttons *//
        private void logInButton_Click(object sender, EventArgs e)
        {
            if (userInputBox.Text.Length == 0 || passInputBox.Text.Length == 0)
            {
                string errorMessage = "One or more fields are empty!";
                string caption = "Attention";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(errorMessage, caption, buttons, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    //This needs to be empty!
                }
            }
            else
            {
                try
                {
                    SQLconnect();
                }
                catch (Exception specialError)
                {
                    string errorMessage = "Error!: " + specialError;
                    string caption = "Attention";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    result = MessageBox.Show(errorMessage, caption, buttons, MessageBoxIcon.Error);
                }
            }
        }
        //* Buttons END *//

        private void SQLconnect()
        {
            //SqlConnection sqlConnect = new SqlConnection();
            sqlConnect.ConnectionString =
                "Data Source = 62.116.202.237;" +   //Server name
                "Initial Catalog = TJDB;" +         //Database name
                "User id = SA;" +                   //User ID
                "Password = Admin123;";             //Password
            sqlConnect.Open();

            //string accountUsername = userInputBox.Text;
            //string accountPassword = passInputBox.Text;

            //Note: '=' IKKE '=='! Det er SQLscript ikke C#
            //SqlCommand sqlCmd = new SqlCommand("SELECT Username, Password FROM dbo.Accounts WHERE Username = '" + accountUsername + "' AND Password = '" + accountPassword + "' ", sqlConnect);
            SqlCommand sqlCmd = new SqlCommand("SELECT Username, Password FROM dbo.Accounts WHERE Username = '" + AccountUsernameGetSet + "' AND Password = '" + AccountPasswordGetSet + "' ", sqlConnect);

            // PIN-POINT : 1
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
            DataTable sqlDT = new DataTable();

            sqlDA.Fill(sqlDT);
            if (sqlDT.Rows.Count > 0)
            {
                try
                {
                    //Upon success:
                    LoginChangesMethod();
                }
                catch (Exception e)
                {
                    string errorMessage = "Error: " + e;
                    string caption = "Attention";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    result = MessageBox.Show(errorMessage, caption, buttons, MessageBoxIcon.Error);
                }
            }
            else
            {
                string errorMessage = "Username or Password is incorrect!";
                string caption = "Attention";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(errorMessage, caption, buttons, MessageBoxIcon.Information);
                //sqlConnect.Close(); //temp
            }
            //PIN-POINT : 1 END

            //sqlConnect.Close();
        }
        //--------------------------- FORM 1 END -----------------------------//
        //--------------------------- FORM 2 : Inbox -------------------------//
        //* Label *//
        private void accountNameLabel_Click(object sender, EventArgs e)
        {
            //Important
        }
        private void InboxLabel_Click(object sender, EventArgs e)
        {

        }
        private void messageLabel_Click(object sender, EventArgs e)
        {

        }

        //* Button *//
        private void tab2_SendNewButton_Click(object sender, EventArgs e)
        {
            //-!Obsolete!-
        }
        private void inboxButton_Click(object sender, EventArgs e)
        {
            //-!Obsolete!-
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            //sqlConnect.Close();
            LogoutChangesMethod();
        }
        private void deleteMessageButton_Click(object sender, EventArgs e)
        {
            //Fetch message from DB, delete and refresh list
        }

        //* Input field *//
        private void MessageTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        //* List *//
        private void InboxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //--------------------------- FORM 2 END -----------------------------//
        //--------------------------- FORM 3 : Send new ----------------------//
        //* Button *//
        private void button3_Click(object sender, EventArgs e)
        {
            //? - Most likely obsolete
        }
        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            //Security: The DB and Tables are shared which in official settings would be a security concern- DO NOT USE COMMERCIALLY!
            //Objects: recipientInput, titleInput and messageInput -- VIA: dbo.Accounts
            //SQL obj: FromUser, ToUser, SendDate, MessageTitle, MessageContent, TimeToLive -- VIA: dbo.MessageBank

            //SqlConnection - open :TODO

            //string recipientString = recipientInput.Text;
            //string titleString = titleInput.Text;
            //string messageString = messageInput.Text;
            //Int32 timeToLiveInt = (int)numericUpDown1.Value;

            ////Original
            //SqlCommand sqlCmd = new SqlCommand("SELECT FromUser, ToUser, SendDate, MessageTitle, MessageContent, TimeToLive " +
            //    "FROM dbo.MessageBank " +
            //    "WHERE FromUser = '" + accountUsername + "' " +
            //    "AND ToUser = '" + recipientString + "' " +
            //    //"AND SendDate X" + //Find SQLcommand for this
            //    "AND MessageTitle = '" + titleString + "' " +
            //    "AND MessageContent = '" + messageString + "' " +
            //    "AND TimeToLive = '" + timeToLiveInt + "' ", sqlConnect);

            ////Modified
            //SqlCommand sqlCmd = new SqlCommand("SELECT FromUser, ToUser, SendDate, MessageTitle, MessageContent, TimeToLive " +
            //    "FROM dbo.MessageBank " +
            //    "WHERE FromUser = '" + AccountUsernameGetSet + "' " +
            //    "AND ToUser = '" + RecipientGetSet + "' " +
            //    //"AND SendDate X" + //Find SQLcommand for this
            //    "AND MessageTitle = '" + TitleGetSet + "' " +
            //    "AND MessageContent = '" + MessageGetSet + "' " +
            //    "AND TimeToLive = '" + TimeToLiveIntGetSet + "' ", sqlConnect);
            try
            {
                //SQL DB message send
                SqlCommand sqlCmdSend = new SqlCommand("INSERT INTO dbo.MessageBank " +
                "(FromUser, ToUser, SendDate, MessageTitle, MessageContent, TimeToLive)" +
                "VALUES + " +
                "('" + AccountUsernameGetSet + "', '" + RecipientGetSet + "', GETDATE(), '" + TitleGetSet + "', '" + MessageGetSet + "', '" + TimeToLiveIntGetSet + "')");

                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmdSend);  //
                DataTable sqlDT = new DataTable();                      //
            }
            catch (Exception sendError)
            {
                string errorMessage = "Error: " + sendError;
                string caption = "Attention";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(errorMessage, caption, buttons, MessageBoxIcon.Error);
            }
        }
        private void sendMailButton_Click(object sender, EventArgs e)
        {
            try
            {
                //SMTP mail send
                ///OnEmptyField:
                if (mailInput.Text.Length == 0 || mailPassInput.Text.Length == 0 || portInput.Text.Length == 0 || SMTPInput.Text.Length == 0)
                {
                    string errorMessage = "One or more textboxe(s) haven't been filled in SMTP field";
                    string caption = "Attention";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    result = MessageBox.Show(errorMessage, caption, buttons, MessageBoxIcon.Error);
                }
                ///OnSuccess:
                if (mailInput.Text.Length != 0 && mailPassInput.Text.Length != 0 && portInput.Text.Length != 0 && SMTPInput.Text.Length != 0)
                {
                    //Send mail! - Added Reference: System.net
                    login = new NetworkCredential(mailInput.Text, mailPassInput.Text);
                    client = new SmtpClient(SMTPInput.Text);
                    client.Port = Convert.ToInt32(portInput.Text);
                    client.EnableSsl = SSLCheckBox.Checked;
                    client.Credentials = login;
                    msg = new MailMessage { From = new MailAddress(mailInput.Text + SMTPInput.Text.Replace("smtp.", "@"), "Patharoth", Encoding.UTF8) };
                    msg.To.Add(new MailAddress(recipientInput.Text));
                    if (!string.IsNullOrEmpty(carbonCopyInput.Text))
                        msg.To.Add(new MailAddress(carbonCopyInput.Text));

                    msg.Subject = titleInput.Text;
                    msg.Body = messageInput.Text;
                    msg.BodyEncoding = Encoding.UTF8;
                    msg.IsBodyHtml = true;
                    msg.Priority = MailPriority.Normal;
                    msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);

                    string userstate = "Sending...";
                    client.SendAsync(msg, userstate);
                }
            }
            catch(Exception mailError)
            {
                string errorMessage = "Error: " + mailError;
                string caption = "Attention";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(errorMessage, caption, buttons, MessageBoxIcon.Error);
            }
        }

        //* Input field *//
        private void recipientInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void carbonCopyInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void titleInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void messageInput_TextChanged(object sender, EventArgs e)
        {

        }
        //Space
        private void mailInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void mailPassInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void portInput_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void SMTPInput_TextChanged_1(object sender, EventArgs e)
        {

        }

        //* Label *//
        private void recipientLabel_Click(object sender, EventArgs e)
        {

        }
        private void carbonCopyLabel_Click(object sender, EventArgs e)
        {

        }
        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
        private void timeToLiveLabel_Click(object sender, EventArgs e)
        {

        }
        //Space
        private void SMTPTitleLabel_Click(object sender, EventArgs e)
        {

        }
        private void MailLabel_Click(object sender, EventArgs e)
        {

        }
        private void MailPasswordLabel_Click(object sender, EventArgs e)
        {

        }
        private void PortLabel_Click_1(object sender, EventArgs e)
        {

        }
        private void SMTPLabel_Click_1(object sender, EventArgs e)
        {

        }
        private void SSLLabel_Click_1(object sender, EventArgs e)
        {

        }

        //* Numeric *//
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        //* Checked *//
        private void SSLCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        //--------------------------- FORM 3 END -----------------------------//
        //--------------------------- METHODS --------------------------------//
        private void LoginChangesMethod()
        {
            //On successful login:
            ((Control)this.tabLogin).Enabled = false;
            ((Control)this.tabInbox).Enabled = true;
            ((Control)this.tabSend).Enabled = true;

            //Change/setActive tab:
            tabControl1.SelectTab(tabInbox);

            //"Move" login name:
            accountNameLabel.Text = userInputBox.Text;

            //Clear:
            userInputBox.Clear();
            passInputBox.Clear();

            //Rename:
            LoginWindow.ActiveForm.Text = "Mail";
        }
        private void LogoutChangesMethod()
        {
            //On successful login:
            ((Control)this.tabLogin).Enabled = true;
            ((Control)this.tabInbox).Enabled = false;
            ((Control)this.tabSend).Enabled = false;

            //Change/setActive tab:
            tabControl1.SelectTab(tabLogin);

            //"Move" login name:
            accountNameLabel.Text = "";

            ////Clear:
            //Will clear all fields, lists, etc.

            //Rename:
            LoginWindow.ActiveForm.Text = "Login";

            //Other:
            sqlConnect.Close();
        }

        //Make this work! -- Close sqlConnection UPON window close/exit
        private void btnClose_Click(object sender, EventArgs e)
        {
            string errorMessage = "You are now logged off";
            string caption = "Attention";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(errorMessage, caption, buttons, MessageBoxIcon.Information);
        }

        //Error and Success messages for SMTP process
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Your message has been successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
