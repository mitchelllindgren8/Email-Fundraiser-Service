using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace EmailFundProject
{
    public partial class ViewEvent : Form
    { 
        private int panelItr = 0;

        public ViewEvent()
        {
            InitializeComponent();
            loadPage();
        }

        private void loadPage()
        {
            SqlConnection conncection = new SqlConnection(@"Data Source=DESKTOP-AK16H71\SQLEXPRESS;Initial Catalog=EFDatabase;Integrated Security=True");
            int eventSize = 0;
            string stmtCount = "SELECT COUNT(*) FROM dbo.EventList";

            //find the event size
            using (conncection)
            {
                using (SqlCommand cmdCount = new SqlCommand(stmtCount, conncection))
                {
                    conncection.Open();
                    eventSize = (int)cmdCount.ExecuteScalar();
                    SqlDataReader readerr;
                    readerr = cmdCount.ExecuteReader();
                    conncection.Close();
                }
            }
            conncection.Close();

            if(eventSize == 0)
            {
                panelList.Size = new System.Drawing.Size(700, 297); 
            }

            SqlConnection conT = new SqlConnection(@"Data Source=DESKTOP-AK16H71\SQLEXPRESS;Initial Catalog=EFDatabase;Integrated Security=True");
            string query = "Select * from EventList";
            SqlCommand cmdT = new SqlCommand();
            cmdT.Connection = conT;
            cmdT.CommandText = query;
            conT.Open();
            SqlDataReader rdr = cmdT.ExecuteReader();

            //creates Event Panels with data pulled from SQL database
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AK16H71\SQLEXPRESS;Initial Catalog=EFDatabase;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select id, startDate, endDate, sport, sportLevel, goal from EventList where id=@id", conn);
                    cmd.Parameters.AddWithValue("id", rdr["id"]);
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = (int)reader["id"];
                        Console.WriteLine("SD: " + reader["startDate"].ToString() + ", ED: " + reader["endDate"].ToString() + ", Sport: " + reader["sport"].ToString() + ", Level: " + reader["sportLevel"].ToString() + ", Goal: " + reader["goal"].ToString());
                        Console.WriteLine("ID: " + id);

                        Panel panelEvent = new Panel();
                        //this.Controls.Add(panelEvent);   WORKS
                        panelList.Controls.Add(panelEvent);
                        panelEvent.BackColor = System.Drawing.Color.White;
                        panelEvent.Location = new System.Drawing.Point(20, (101 + panelItr));
                        panelItr += 174;    // 164(panel) + 10(spacing)
                        panelEvent.Name = "panelExample";
                        panelEvent.Size = new System.Drawing.Size(658, 164);
                        panelEvent.TabIndex = 0;

                        Label lblheader = new Label();
                        lblheader.AutoSize = true;
                        lblheader.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblheader.Location = new System.Drawing.Point(13, 20);
                        lblheader.Name = "lblFullSport";
                        lblheader.Size = new System.Drawing.Size(460, 43);
                        lblheader.TabIndex = 0;
                        lblheader.Text = reader["sportLevel"].ToString() + " " + reader["sport"].ToString();
                        panelEvent.Controls.Add(lblheader);

                        Label lblend = new Label();
                        lblend.AutoSize = true;
                        lblend.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblend.ForeColor = System.Drawing.Color.DimGray;
                        lblend.Location = new System.Drawing.Point(185, 90);
                        lblend.Name = "lblend";
                        lblend.Size = new System.Drawing.Size(77, 16);
                        lblend.TabIndex = 6;
                        lblend.Text = "End Date:";
                        panelEvent.Controls.Add(lblend);

                        Label lblstart = new Label();
                        lblstart.AutoSize = true;
                        lblstart.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblstart.ForeColor = System.Drawing.Color.DimGray;
                        lblstart.Location = new System.Drawing.Point(30, 90);
                        lblstart.Name = "lblstart";
                        lblstart.Size = new System.Drawing.Size(83, 16);
                        lblstart.TabIndex = 5;
                        lblstart.Text = "Start Date:";
                        panelEvent.Controls.Add(lblstart);

                        Label lblgoal = new Label();
                        lblgoal.AutoSize = true;
                        lblgoal.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblgoal.ForeColor = System.Drawing.Color.DimGray;
                        lblgoal.Location = new System.Drawing.Point(330, 90);
                        lblgoal.Name = "lblgoal";
                        lblgoal.Size = new System.Drawing.Size(45, 16);
                        lblgoal.TabIndex = 8;
                        lblgoal.Text = "Goal:";
                        panelEvent.Controls.Add(lblgoal);

                        Label lblID = new Label();
                        lblID.AutoSize = true;
                        lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(152)))));
                        lblID.Location = new System.Drawing.Point(13, 0);
                        lblID.Name = "lblID";
                        lblID.Size = new System.Drawing.Size(38, 16);
                        lblID.TabIndex = 16;
                        lblID.Text = reader["id"].ToString();
                        lblID.Visible = true;
                        panelEvent.Controls.Add(lblID);

                        Label lblIDicon = new Label();
                        lblIDicon.AutoSize = true;
                        lblIDicon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblIDicon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(152)))));
                        lblIDicon.Location = new System.Drawing.Point(0, 0);
                        lblIDicon.Name = "lblIDicon";
                        lblIDicon.Size = new System.Drawing.Size(38, 16);
                        lblIDicon.TabIndex = 16;
                        lblIDicon.Text = "#";
                        lblIDicon.Visible = true;
                        panelEvent.Controls.Add(lblIDicon);

                        Label lblEndD = new Label();
                        lblEndD.AutoSize = true;
                        lblEndD.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblEndD.Location = new System.Drawing.Point(185, 106);
                        lblEndD.Name = "lblEndD";
                        lblEndD.Size = new System.Drawing.Size(184, 23);
                        lblEndD.TabIndex = 3;
                        lblEndD.Text = reader["endDate"].ToString();
                        panelEvent.Controls.Add(lblEndD);

                        Label lblStartD = new Label();
                        lblStartD.AutoSize = true;
                        lblStartD.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblStartD.Location = new System.Drawing.Point(30, 106);
                        lblStartD.Name = "lblStartD";
                        lblStartD.Size = new System.Drawing.Size(184, 23);
                        lblStartD.TabIndex = 2;
                        lblStartD.Text = reader["startDate"].ToString();
                        panelEvent.Controls.Add(lblStartD);

                        Label lblGoalNum = new Label();
                        lblGoalNum.AutoSize = true;
                        lblGoalNum.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblGoalNum.Location = new System.Drawing.Point(330, 106);
                        lblGoalNum.Name = "lblGoalNum";
                        lblGoalNum.Size = new System.Drawing.Size(81, 23);
                        lblGoalNum.TabIndex = 4;
                        lblGoalNum.Text = "$" + reader["goal"].ToString();
                        panelEvent.Controls.Add(lblGoalNum);

                        PictureBox pbSport = new PictureBox();
                        pbSport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(152)))));
                        pbSport.Location = new System.Drawing.Point(551, 7);
                        pbSport.Name = "pbSport";
                        pbSport.Size = new System.Drawing.Size(100, 100);
                        pbSport.TabIndex = 1;
                        pbSport.TabStop = false;
                        pbSport.Image = iconSelector(reader["sport"].ToString());
                        panelEvent.Controls.Add(pbSport);

                        Panel panelStatus = new Panel();
                        string colorHex = "";
                        colorHex = getEventStatus(reader["startDate"].ToString(), reader["endDate"].ToString());
                        panelStatus.BackColor = System.Drawing.ColorTranslator.FromHtml(colorHex);
                        panelStatus.Location = new System.Drawing.Point(523, 131);
                        panelStatus.Name = "panelStatus";
                        panelStatus.Size = new System.Drawing.Size(135, 22);
                        panelStatus.TabIndex = 7;
                        panelEvent.Controls.Add(panelStatus);

                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("The event list is empty", "No Data");
                    }
                    panelList.Size = new System.Drawing.Size(700, (101 + 25 + panelItr));    //101(top padding) + 25(bottom) + panelItr(all panels + spacing)
                    panelSeperatorBtm.Location = new System.Drawing.Point(20, (101 + 25 + panelItr + 33)); //101(top padding) + 25(bottom) + panelItr(all panels + spacing) + 33(speratorePanel spacing)
                    conn.Close();
                }
            }
            conT.Close();
        }

        public string  getEventStatus(String startD, String endD)
        {
            String colorStatus = "";
            DateTime todayDatee = DateTime.Today;
            var startDateF = DateTime.Parse(startD);
            var endDateF = DateTime.Parse(endD);
            Console.WriteLine("Start: " + startDateF + " ,End: " + endDateF + ", Today: " + todayDatee);

            int startResult = DateTime.Compare(startDateF, todayDatee);
            int endResult = DateTime.Compare(endDateF, todayDatee);

            
            //checks if the same date as start-date or going forward in the future
            if ((startResult == 0 || startResult < 0))
            {
                //checks if the same date as end-date or going backwards in the past
                if ((endResult == 0 || endResult > 0))
                {
                    //"Yellow, event is ongoing"
                    colorStatus = "#ff9900";

                } else
                {
                    //"Green, Completed"
                    colorStatus = "#00ff00";
                }
            } else
            {
                //"Gray, event is up-and-coming"
                colorStatus = "#646464";
            }

            return colorStatus;
        }

        public Image iconSelector(String sport)
        {
            Image icon = null;

            switch (sport)
            {
                case "Cross Country":
                    icon = Properties.Resources.trackfieldImage;
                    break;
                case "Field Hockey":
                    icon = Properties.Resources.fieldHockeyImage;
                    break;
                case "Football":
                    icon = Properties.Resources.footballImage;
                    break;
                case "Girls Golf":
                    icon = Properties.Resources.golfingImage;
                    break;
                case "Girls Tennis":
                    icon = Properties.Resources.tennisImage;
                    break;
                case "Girls Volleyball":
                    icon = Properties.Resources.volleyballImage;
                    break;
                case "Boys Waterpolo":
                    icon = Properties.Resources.waterpoloImage;
                    break;
                case "Boys Basketball":
                    icon = Properties.Resources.basketballImage;
                    break;
                case "Girls Basketball":
                    icon = Properties.Resources.basketballImage;
                    break;
                case "Boys Soccer":
                    icon = Properties.Resources.soccerImage;
                    break;
                case "Girls Soccer":
                    icon = Properties.Resources.soccerImage;
                    break;
                case "Girls Waterpolo":
                    icon = Properties.Resources.waterpoloImage;
                    break;
                case "Wrestling":
                    icon = Properties.Resources.wrestlingImage;
                    break;
                case "Baseball":
                    icon = Properties.Resources.baseballImage;
                    break;
                case "Boys Golf":
                    icon = Properties.Resources.golfingImage;
                    break;
                case "Gymnastics":
                    icon = Properties.Resources.gymnasticsImage;
                    break;
                case "Boys Lacrosse":
                    icon = Properties.Resources.lacrosseImage;
                    break;
                case "Girls Lacrosse":
                    icon = Properties.Resources.lacrosseImage;
                    break;
                case "Swim and Dive":
                    icon = Properties.Resources.swimmingImage;
                    break;
                case "Boys Tennis":
                    icon = Properties.Resources.tennisImage;
                    break;
                case "Track and Field":
                    icon = Properties.Resources.trackImage;
                    break;
                case "Boys Volleyball":
                    icon = Properties.Resources.volleyballImage;
                    break;
                default:
                    break;
            }

            return icon;
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.Text = "Delete Event";
            btnDelete.Size = new Size(130, 30);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.Text = "";
            btnDelete.Size = new Size(45, 30);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = true;
            panelCompleted.Visible = true;
            panelCurrent.Visible = true;
            panelFuture.Visible = true;
        }

        private void btnDeleteClose_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = false;
            panelCompleted.Visible = false;
            panelCurrent.Visible = false;
            panelFuture.Visible = false;
            tbIDnumber.Text = "";
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AK16H71\SQLEXPRESS;Initial Catalog=EFDatabase;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("");
            cmd.CommandText = ("Select * from EventList");
            cmd.Connection = conn;
            bool flag = false;

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if(rd["id"].ToString() == tbIDnumber.Text)
                {
                    flag = true;
                    break;
                }
            }

            //conditionally if Event w/ valid ID exists
            if (flag == true)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AK16H71\SQLEXPRESS;Initial Catalog=EFDatabase;Integrated Security=True");
                con.Open();
                SqlCommand cmdD = new SqlCommand("Delete from EventList where id=@id", con);
                cmdD.Parameters.AddWithValue("id", tbIDnumber.Text);
                cmdD.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Event #" + tbIDnumber.Text + " has been deleted.", "Successfully Deleted");

                //Resets/Updates the panel-interface
                panelList.Controls.Clear();
                refreshPage();
                panelItr = 0;
                loadPage();
            } else
            {
                MessageBox.Show("Event #" + tbIDnumber.Text + " does not exist.", "Error: Delete Event");
                flag = false;
            }
        }

        //adds back a missing panel after the form reloads
        private void refreshPage()
        {
            panelList.Controls.Add(this.panelListBG);
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all?", "--- Delete All! ---", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                SqlConnection conT = new SqlConnection(@"Data Source=DESKTOP-AK16H71\SQLEXPRESS;Initial Catalog=EFDatabase;Integrated Security=True");
                string query = "Select * from EventList";
                SqlCommand cmdT = new SqlCommand();
                cmdT.Connection = conT;
                cmdT.CommandText = query;
                conT.Open();

                SqlDataReader rdr = cmdT.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AK16H71\SQLEXPRESS;Initial Catalog=EFDatabase;Integrated Security=True");
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("Delete from EventList where id=@id", conn);
                        cmd.Parameters.AddWithValue("id", rdr["id"]);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                conT.Close();

                //This resets/updates the panel-interface
                panelList.Controls.Clear();
                refreshPage();
                panelItr = 0;
                loadPage();
                panelDelete.Visible = false;
                MessageBox.Show("All events have been deleted.", "Deletion Confirmation");
            }
        }
    }
}
