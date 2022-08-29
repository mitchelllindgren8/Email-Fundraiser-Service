using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using AE.Net.Mail;
using System.Threading;

namespace EmailFundProject
{
    public partial class Dashboard : Form
    {
        static ImapClient IC;
        private static string emailaddress;
        private static string password;
        private static string numID;
        private static string fullName;

        //   *** DESIGNER'S UPDATE NOTE (8/2022) ***
        //
        // AS OF MAY 31ST, 2022; GOOGLE HAS UPDATED THEIR ACCOUNT AUTHENTICATION PROCESS THUS OUT-DATING 
        // THE "emailReader()" AND "emailSender()" FUNCTIONS. UPDATES WOULD BE REQIURED TO MEET GOOGLE'S
        // NEW SECURITY GUIDELINES IN ORDER TO OPERATE THIS APPLICATION TO THE FULLEST.
        //
        // THE APPLICATION MUST BE MODIFIED TO MODEL A SCHOOL OR ORGANIZATION FOR MARKETABLE PURPOSES.
        // FOR DEMONSTRATION PURPOSES THE CODE HAS BEEN EDITED/COMMENTED OUT

        public Dashboard()
        {
            InitializeComponent();
            emailaddress = "";  //attach a company-like email address here, this will be the account the application operates through (GMAIL)
            password = "";  //Enter the password for the GMAIL account, this would need to be encrypted
            //emailReader();
            //emailSender();
        }

        public void loadForm(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
            {
                this.panelMain.Controls.RemoveAt(0);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        static void emailReader()
        {
            IC = new ImapClient("imap.gmail.com", emailaddress, password, AuthMethods.Login, 993, true);
            IC.SelectMailbox("INBOX");
            int emailCount = IC.GetMessageCount();
            //Console.WriteLine("Count: " + emailCount);
            var Email1 = IC.GetMessage(IC.GetMessageCount() - 1);    //most recent email received
            //Console.WriteLine("Subject: " + Email1.Subject);
            //Console.WriteLine("Body: " + Email1.Body);
            emailParser(Email1.Subject, Email1.Body);
            //Console.ReadLine();     //this keeps the console open, w/o it the console-app closes

        }

        static void emailParser(String subjectStr, String bodyStr)
        {
            //for entire subject line, splits into 3 substrings
            char[] delimiterChars = { ',', '/', '-', '_' };
            string sportStr;

            //while (subjectStr)
            string[] words = subjectStr.Split(delimiterChars);
            numID = words[0];
            sportStr = words[1];
            fullName = words[2];
            //Console.WriteLine(numID + " " + sportStr + " " + fullName);

            //parse full name
            string[] name = fullName.Split(' ');
            string firstN = name[0];
            string lastN = name[1];
            //Console.WriteLine(firstN + " " + lastN);

            //call ID function organizer
            checkEventID(); // numID

            string[] sports = sportStr.Split('.');
            string level = sports[0];
            string gender = sports[1];
            string sport = sports[2];
            //Console.WriteLine(level + " " + gender + " " + sport);

            //collect emails
            string[] emails = bodyStr.Split(',');

            for (int i = 1; i < emails.Length; i++)
            {
                //string email+i = emails[i - 1];
            }

        }

        static void checkEventID()
        {
            //once event is created >> excelsheet created >> create check to see if valid ID 
            // **************************
            // **************************
        }

        static void emailSender()
        {
            //create obj which will will use to fill the message data
            MimeMessage message = new MimeMessage();

            //add the sender info that will apperar in the email message
            message.From.Add(new MailboxAddress("Adam", emailaddress));

            //add the receiver email address
            message.To.Add(new MailboxAddress("John", "youremail@gmail.com"));

            //add the message subject
            message.Subject = "Test Email";

            //add the message body as plain text the "PLain" string passsed to the TextPart
            //indicates that it's plain text and not HTML for example
            message.Body = new TextPart("plain")
            {
                Text = @"Hello!

                Please donate to www.donate.com
                Thank you,
                -Adam"
            };

            //create a new SMPT client
            SmtpClient client = new SmtpClient();

            try
            {
                //connect tp the gmail smtp server using port 465 with SSL enabled
                client.Connect("smtp.gmail.com", 465, true);
                // Note: only needed if the SMTP server requies authentication, like gmail for example
                client.Authenticate(emailaddress, password);
                client.Send(message);

                //display success meassge
                Console.WriteLine("Email Sent!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Thread.Sleep(2000);
                //at any case always disconnect from the client
                client.Disconnect(true);
                //and dispose of the client object
                client.Dispose();
            }
        }


        // ******** HOME BUTTON ********
        private void btnHome_Click(object sender, EventArgs e)
        {
            resetColors();
            btnHome.BackColor = Color.FromArgb(6, 53, 152);
            loadForm(new Home());
            lblHeader.Text = "Email Fundraiser";
        }

        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            if (btnHome.BackColor == Color.FromArgb(6, 53, 152))
            {
                return;
            }
            else
            {
                btnHome.BackColor = Color.Gray;
            }
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            if (btnHome.BackColor == Color.FromArgb(6, 53, 152))
            {
                return;
            }
            else
            {
                btnHome.BackColor = Color.FromArgb(64, 64, 64);
            }
        }
        // ******************************************

        // ******** ADD BUTTON **********************
        public void btnAdd_Click(object sender, EventArgs e)
        {
            resetColors();
            btnAdd.BackColor = Color.FromArgb(6, 53, 152);
            loadForm(new AddEvent());
            lblHeader.Text = "Add Event";
            Console.WriteLine("Add");
        }

        public void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            if (btnAdd.BackColor == Color.FromArgb(6, 53, 152))
            {
                return;
            }
            else
            {
                btnAdd.BackColor = Color.Gray;
            }
        }

        public void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            if (btnAdd.BackColor == Color.FromArgb(6, 53, 152))
            {
                return;
            }
            else
            {
                btnAdd.BackColor = Color.FromArgb(64, 64, 64);
            }
        }
        // ******************************************

        // ******** VIEW BUTTON *********************
        private void btnView_Click(object sender, EventArgs e)
        {
            resetColors();
            btnView.BackColor = Color.FromArgb(6, 53, 152);
            loadForm(new ViewEvent());
            lblHeader.Text = "View Event";
        }

        private void btnView_MouseEnter(object sender, EventArgs e)
        {
            if (btnView.BackColor == Color.FromArgb(6, 53, 152))
            {
                return;
            }
            else
            {
                btnView.BackColor = Color.Gray;
            }
        }

        private void btnView_MouseLeave(object sender, EventArgs e)
        {
            if (btnView.BackColor == Color.FromArgb(6, 53, 152))
            {
                return;
            }
            else
            {
                btnView.BackColor = Color.FromArgb(64, 64, 64);
            }
        }
        // ******************************************

        // ******** SETTINGS BUTTON *****************
        private void btnSettings_Click(object sender, EventArgs e)
        {
            resetColors();
            btnSettings.BackColor = Color.FromArgb(6, 53, 152);
            loadForm(new Settings());
            lblHeader.Text = "Settings";
        }
        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            if (btnSettings.BackColor == Color.FromArgb(6, 53, 152))
            {
                return;
            }
            else
            {
                btnSettings.BackColor = Color.Gray;
            }
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            if (btnSettings.BackColor == Color.FromArgb(6, 53, 152))
            {
                return;
            }
            else
            {
                btnSettings.BackColor = Color.FromArgb(64, 64, 64);
            }
        }
        // ******************************************

        // ******** SINGOUT BUTTON ******************
        private void btnSignout_Click(object sender, EventArgs e)
        {
            resetColors();
            btnSignout.BackColor = Color.FromArgb(6, 53, 152);

            DialogResult dialog = MessageBox.Show("Are you sure you want to sign out?", "Sign out", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                this.Hide();
                login.Show();
            }
        }

        private void btnSignout_MouseEnter(object sender, EventArgs e)
        {
            if(btnSignout.BackColor == Color.FromArgb(6, 53, 152))
            {
                return;
            }
            else
            {
                btnSignout.BackColor = Color.Gray;
            }
        }

        private void btnSignout_MouseLeave(object sender, EventArgs e)
        {
            if (btnSignout.BackColor == Color.FromArgb(6, 53, 152))
            {
                return;
            }
            else
            {
                btnSignout.BackColor = Color.FromArgb(64, 64, 64);
            }
        }
        // ******************************************

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetColors()
        {
            btnHome.BackColor = Color.FromArgb(64, 64, 64);
            btnAdd.BackColor = Color.FromArgb(64, 64, 64);
            btnView.BackColor = Color.FromArgb(64, 64, 64);
            btnSettings.BackColor = Color.FromArgb(64, 64, 64);
            btnSignout.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnhorse_Click(object sender, EventArgs e)
        {
            btnhorse.BackColor = Color.White;
        }
    }
}
