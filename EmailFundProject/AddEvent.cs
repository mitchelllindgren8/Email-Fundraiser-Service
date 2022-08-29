using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailFundProject
{
    public partial class AddEvent : Form
    {
        public string gStartD = "";
        public string gtempStarD = "";
        public string gEndD;
        public string gSport;
        public string gLevel;
        public int gGoal;
        public int gID;
        public bool gReady = false;
        public Image icon;

        private List<EventCreator> EventList = new List<EventCreator>();
        List<Panel> listPanel = new List<Panel>();
        int index;

        private string conStr = @"Data Source=DESKTOP-AK16H71\SQLEXPRESS;Initial Catalog=EFDatabase;Integrated Security=True";

        public AddEvent()
        {
            InitializeComponent();
            setUp();
        }

        private void setUp()
        {
            
            DateTime todayDate = DateTime.Today;
            DateTime tempDate = todayDate.AddDays(14);  //is the minimum recommended amount of time to fundraise 
            dpStartDate.Value = todayDate;
            dpStartDate.MinDate = todayDate;
            dpStartDate.MaxDate = todayDate.AddYears(2);    //only allow planning for 2 years out
            dpEndDate.Value = tempDate;
            dpEndDate.MinDate = tempDate;
            dpEndDate.MaxDate = todayDate.AddYears(2);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            gReady = false;

            if(index >= 4)
            {
                index = 4;
            }

            if(index == 4)
            {
                tbGoal.BorderColor = Color.Black;
                pbRevIcon.FillColor = Color.White;
            }

            if (index > 0)
            {
                btnNext.Text = "Next";

                if (index == 1)
                {
                    index--;
                    AEpage1.Show();
                    AEpage1.BringToFront();
                    btnBack.Visible = false;
                }
                else
                {
                    listPanel[--index].BringToFront();
                }
            }
            else
            {
                AEpage1.BringToFront();
            }
            
            AddEvent_PageSetup();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(index == 0)
            {
                AEpage1.Hide();
                btnBack.Visible = true;
            }

            //Checks if missing fields before creating event
            if(index >= 4)
            {
                if (lblRevLevel.Text == "" || lblRevLevel.Text == "Missing")
                {
                    lblRevLevel.Text = "Missing";
                    lblRevLevel.ForeColor = Color.Red;
                }

                if (lblRevSport.Text == "" || lblRevSport.Text == "Missing")
                {
                    lblRevSport.Text = "Missing";
                    lblRevSport.ForeColor = Color.Red;
                    pbRevIcon.FillColor = Color.FromArgb(255, 128, 128);
                }

                if (tbGoal.Text == "")
                {
                    tbGoal.BorderColor = Color.Red;
                }


                //IF all fields are entered properly, we then pass ready boolean
                if(lblStartDate.Text != "" && lblEndDate.Text != "" && lblRevSport.Text != "" && lblRevSport.Text != "Missing" && lblRevLevel.Text != "" && lblRevLevel.Text != "Missing" && tbGoal.Text != "")
                {
                    gReady = true;
                }

                if (gReady == true)
                {
                    EventCreator ent = new EventCreator(gStartD, gEndD, gSport, gLevel, gGoal);
                    EventList.Add(new EventCreator(gStartD, gEndD, gSport, gLevel, gGoal));

                    using (SqlConnection sqlCon = new SqlConnection(conStr))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("FundraiserEvent", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@startDate", gStartD);
                        sqlCmd.Parameters.AddWithValue("@endDate", gEndD);
                        sqlCmd.Parameters.AddWithValue("@sport", gSport);
                        sqlCmd.Parameters.AddWithValue("@sportLevel", gLevel);
                        sqlCmd.Parameters.AddWithValue("@goal", gGoal);
                        sqlCmd.ExecuteNonQuery();
                        ViewEvent obj = new ViewEvent();
                    }

                    reset();
                    btnNext.Text = "Next";
                    AEpage1.BringToFront();
                    AEpage1.Show();
                    btnBack.Visible = false;
                    pbRevIcon.FillColor = Color.White;
                    index = 0;
                    System.Windows.Forms.MessageBox.Show("The event has been created", "Event Created");
                }

            } else {
                if (index < listPanel.Count - 1)
                    listPanel[++index].BringToFront();
            }

            if (index == 4)
            {
                btnNext.Text = "Create";
                lblRevStartD.Text = gStartD;
                lblRevEndD.Text = gEndD;
                lblRevLevel.Text = gLevel;
                lblRevSport.Text = gSport;
                pbRevIcon.Image = icon;
                index++;

            } else {
                //this resets the event creation boolen, user must confirm money again
                gReady = false;
            }

            AddEvent_PageSetup();
        }

        private void reset()
        {
            tbGoal.BorderColor = Color.Black;
            lblRevSport.Text = "";
            lblRevLevel.Text = "";
            tbGoal.Text = "";
            btnFreshman.FillColor = Color.White;
            btnFreshman.ForeColor = Color.FromArgb(6, 53, 152);
            btnFreshman.BorderColor = Color.FromArgb(104, 104, 105);
            btnJV.FillColor = Color.White;
            btnJV.ForeColor = Color.FromArgb(6, 53, 152);
            btnJV.BorderColor = Color.FromArgb(104, 104, 105);
            btnVarsity.FillColor = Color.White;
            btnVarsity.ForeColor = Color.FromArgb(6, 53, 152);
            btnVarsity.BorderColor = Color.FromArgb(104, 104, 105);
            gLevel = "";
            gSport = "";
            gGoal = 0;
        }

        private void AddEvent_PageSetup()
        {
            switch (index)
            {
                //AEPage1 Main Page
                case 0:
                    //do nothing
                    break;

                //AEPage2 Choosing dates
                case 1:
                    pbPagelogo.Image = Properties.Resources.calendarL;
                    pbCircle1.Image = Properties.Resources.CcircleImage;
                    pbCircle2.Image = Properties.Resources.OcircleImage;
                    pbCircle3.Image = Properties.Resources.OcircleImage;
                    pbCircle4.Image = Properties.Resources.OcircleImage;
                    lblHeader.Text = "Let's start planning";
                    lblHeader.Location = new Point(243, 93);
                    break;

                //AEPage3 Choosing a sport
                case 2:
                    pbPagelogo.Image = Properties.Resources.sportsL;
                    pbCircle1.Image = Properties.Resources.CcircleImage;
                    pbCircle2.Image = Properties.Resources.CcircleImage;
                    pbCircle3.Image = Properties.Resources.OcircleImage;
                    pbCircle4.Image = Properties.Resources.OcircleImage;
                    lblHeader.Text = "Select a sport";
                        lblHeader.Location = new Point(282, 93);
                    break;

                //AEPage4 Choosing a money goal
                case 3:
                    pbPagelogo.Image = Properties.Resources.levelsL;
                    pbCircle1.Image = Properties.Resources.CcircleImage;
                    pbCircle2.Image = Properties.Resources.CcircleImage;
                    pbCircle3.Image = Properties.Resources.CcircleImage;
                    pbCircle4.Image = Properties.Resources.OcircleImage;
                    lblHeader.Text = "Choose a level of play";
                    lblHeader.Location = new Point(230, 93);
                    break;

                //AEPage5 Review Event
                case 4:
                    pbPagelogo.Image = Properties.Resources.reviewL;
                    pbCircle1.Image = Properties.Resources.CcircleImage;
                    pbCircle2.Image = Properties.Resources.CcircleImage;
                    pbCircle3.Image = Properties.Resources.CcircleImage;
                    pbCircle4.Image = Properties.Resources.CcircleImage;
                    lblHeader.Text = "What is our fundraising goal?";
                    lblHeader.Location = new Point(176, 93);
                    break;

                //AEPage5 Review Event
                case 5:
                    pbPagelogo.Image = Properties.Resources.reviewL;
                    pbCircle1.Image = Properties.Resources.CcircleImage;
                    pbCircle2.Image = Properties.Resources.CcircleImage;
                    pbCircle3.Image = Properties.Resources.CcircleImage;
                    pbCircle4.Image = Properties.Resources.CcircleImage;
                    lblHeader.Text = "What is our fundraising goal?";
                    lblHeader.Location = new Point(176, 93);
                    break;

                default:
                    break;
            }
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {
            listPanel.Add(AEpage1);
            listPanel.Add(AEpage2);
            listPanel.Add(AEPage3);
            listPanel.Add(AEPage4);
            listPanel.Add(AEPage5);
            listPanel[index].BringToFront();
        }

        private void btnStartDate_Click(object sender, EventArgs e)
        {
            dpEndDate.Visible = false;

            if(dpStartDate.Visible)
                dpStartDate.Visible = false;
            else
                dpStartDate.Visible = true;
        }

        private void btnEndDate_Click(object sender, EventArgs e)
        {
            dpStartDate.Visible = false;

            if (dpEndDate.Visible)
                dpEndDate.Visible = false;
            else
                dpEndDate.Visible = true;
        }

        private void dpStartDate_ValueChanged(object sender, EventArgs e)
        {

            if (gtempStarD == "")
            {
                gtempStarD = dpStartDate.Value.ToString("d");
            } else
            {
                gtempStarD = gStartD;
            }

            btnStartDate.Text = dpStartDate.Value.ToString("D");
            gStartD = dpStartDate.Value.ToString("d");

            //this stores the current date into a temp string
            var originalDate = DateTime.Parse(gtempStarD);
            var newDate = DateTime.Parse(gStartD);
            int result = DateTime.Compare(newDate, originalDate);

            //if increasing
            if(result < 0)
            {
                Console.WriteLine("Decreasing");
                dpEndDate.MinDate = dpStartDate.Value.AddDays(1);
                dpEndDate.MaxDate = dpStartDate.Value.AddYears(1);
            }
            else {  //decreasing
                Console.WriteLine("Increasing");
                dpEndDate.MaxDate = dpStartDate.Value.AddYears(1);
                dpEndDate.MinDate = dpStartDate.Value.AddDays(1);
            }
        }

        private void AEpage2_MouseClick(object sender, MouseEventArgs e)
        {
            dpStartDate.Visible = false;
            dpEndDate.Visible = false;
        }

        private void dpEndDate_ValueChanged(object sender, EventArgs e)
        {

            btnEndDate.Text = dpEndDate.Value.ToString("D");
            gEndD = dpEndDate.Value.ToString("d");
        }

        // ************** Sport-Levels AEPage4 ********************
        private void resetLevels()
        {
            //resets unclicked buttons
            btnFreshman.FillColor = Color.White;
            btnFreshman.BorderColor = Color.FromArgb(104, 104, 105);
            btnFreshman.ForeColor = Color.FromArgb(6, 53, 152);
            btnJV.FillColor = Color.White;
            btnJV.BorderColor = Color.FromArgb(104, 104, 105);
            btnJV.ForeColor = Color.FromArgb(6, 53, 152);
            btnVarsity.FillColor = Color.White;
            btnVarsity.BorderColor = Color.FromArgb(104, 104, 105);
            btnVarsity.ForeColor = Color.FromArgb(6, 53, 152);
        }

        private void btnFreshman_Click(object sender, EventArgs e)
        {
            resetLevels();
            btnFreshman.FillColor = Color.FromArgb(6, 53, 152);
            btnFreshman.BorderColor = Color.FromArgb(6, 53, 152);
            btnFreshman.ForeColor = Color.White;
            lblRevLevel.ForeColor = Color.Black;
            gLevel = "Freshman";
        }

        private void btnJV_Click(object sender, EventArgs e)
        {
            resetLevels();
            btnJV.FillColor = Color.FromArgb(6, 53, 152);
            btnJV.BorderColor = Color.FromArgb(6, 53, 152);
            btnJV.ForeColor = Color.White;
            lblRevLevel.ForeColor = Color.Black;
            gLevel = "Jr. Varsity";
        }

        private void btnVarsity_Click(object sender, EventArgs e)
        {
            resetLevels();
            btnVarsity.FillColor = Color.FromArgb(6, 53, 152);
            btnVarsity.BorderColor = Color.FromArgb(6, 53, 152);
            btnVarsity.ForeColor = Color.White;
            lblRevLevel.ForeColor = Color.Black;
            gLevel = "Varsity";
        }

        // ************** Sports AEPage3 ********************
        private void btnWinter_Click(object sender, EventArgs e)
        {
            panelWinter.BringToFront();
        }

        private void btnSpring_Click(object sender, EventArgs e)
        {
            panelSpring.BringToFront();
        }

        private void btnFall_Click(object sender, EventArgs e)
        {
            panelFall.BringToFront();
        }

        //Spring Sports
        private void btnBaseball_Click(object sender, EventArgs e)
        {
            String sport = "Baseball";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.baseballImage;
            gSport = sport;
        }

        private void btnBgolf_Click(object sender, EventArgs e)
        {
            String sport = "Boys Golf";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.golfingImage;
            gSport = sport;
        }

        private void btnBlacrosse_Click(object sender, EventArgs e)
        {
            String sport = "Boys Lacrosse";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.lacrosseImage;
            gSport = sport;
        }

        private void btnBvolleyball_Click(object sender, EventArgs e)
        {
            String sport = "Boys Volleyball";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.volleyballImage;
            gSport = sport;
        }

        private void btnGlacrosse_Click(object sender, EventArgs e)
        {
            String sport = "Girls Lacrosse";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.lacrosseImage;
            gSport = sport;
        }

        private void btnTrackField_Click(object sender, EventArgs e)
        {
            String sport = "Track and Field";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.trackImage;
            gSport = sport;
        }

        private void btnSwimming_Click(object sender, EventArgs e)
        {
            String sport = "Swim and Dive";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.swimmingImage;
            gSport = sport;
        }

        private void btnGymnastics_Click(object sender, EventArgs e)
        {
            String sport = "Gymnastics";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.gymnasticsImage;
            gSport = sport;
        }

        //Winter Sports
        private void btnGwaterpolo_Click(object sender, EventArgs e)
        {
            String sport = "Girls Waterpolo";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.waterpoloImage;
            gSport = sport;
        }

        private void btnBsoccer_Click(object sender, EventArgs e)
        {
            String sport = "Boys Soccer";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.soccerImage;
            gSport = sport;
        }

        private void btnWrestling_Click(object sender, EventArgs e)
        {
            String sport = "Wrestling";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.wrestlingImage;
            gSport = sport;
        }

        private void btnGsoccer_Click(object sender, EventArgs e)
        {
            String sport = "Girls Soccer";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.soccerImage;
            gSport = sport;
        }

        private void btnGbasketball_Click(object sender, EventArgs e)
        {
            String sport = "Girls Basketball";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.basketballImage;
            gSport = sport;
        }

        private void btnBbasketball_Click(object sender, EventArgs e)
        {
            String sport = "Boys Basketball";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.basketballImage;
            gSport = sport;
        }

        //Fall Sports
        private void btnCrossCountry_Click(object sender, EventArgs e)
        {
            String sport = "Cross Country";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.trackfieldImage;
            gSport = sport;
        }

        private void btnFieldHockey_Click(object sender, EventArgs e)
        {
            String sport = "Field Hockey";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.fieldHockeyImage;
            gSport = sport;
        }

        private void btnFootball_Click(object sender, EventArgs e)
        {
            String sport = "Football";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.footballImage;
            gSport = sport;
        }

        private void btnGgolf_Click(object sender, EventArgs e)
        {
            String sport = "Girls Golf";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.golfingImage;
            gSport = sport;
        }

        private void btnGtennis_Click(object sender, EventArgs e)
        {
            String sport = "Girls Tennis";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.tennisImage;
            gSport = sport;
        }

        private void btnGVolleyball_Click(object sender, EventArgs e)
        {
            String sport = "Girls Volleyball";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.volleyballImage;
            gSport = sport;
        }

        private void btnBwaterpolo_Click(object sender, EventArgs e)
        {
            String sport = "Boys Waterpolo";
            lblRevSport.ForeColor = Color.Black;
            icon = Properties.Resources.waterpoloImage;
            gSport = sport;
        }

        //Converts money goal from string -> int, and int -> string, display version includes "$" and ".00"
        private void getGoalValue(int num)
        {
            String goalNumm = tbGoal.Text;

            if(goalNumm != "")
            {
                if (goalNumm[0] == '$')
                {
                    string newtemp = "";
                    for (int i = 1; i < goalNumm.Length - 3; i++)
                    {
                        newtemp += goalNumm[i];
                    }
                    goalNumm = newtemp;
                }
            } else
            {
                goalNumm = "0";
            }

            int goall = 0;

            try
            {
                goall = Convert.ToInt32(goalNumm);
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Please enter a real number", "Format Error");
            }


            String tempStr = "";
            switch (num)
            {
                //Confirm Goal
                case 1:
                    gGoal = goall;
                    tempStr = goall.ToString();
                    tempStr = "$" + tempStr + ".00";
                    tbGoal.Text = tempStr;
                    gReady = false;
                    break;

                //Increase Goal
                case 2:
                    goall += 1000;
                    tempStr = goall.ToString();
                    tbGoal.Text = tempStr;
                    gReady = false;
                    break;

                //Decrease Goal
                case 3:
                    if(goall >= 1000)
                    {
                        goall -= 1000;
                        tempStr = goall.ToString();
                        tbGoal.Text = tempStr;
                        gReady = false;
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            getGoalValue(1);
            tbGoal.BorderColor = Color.FromArgb(0, 64, 0);
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            getGoalValue(2);
            tbGoal.BorderColor = Color.FromArgb(94, 148, 255);
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            getGoalValue(3);
            tbGoal.BorderColor = Color.FromArgb(94, 148, 255);
        }

        private void tbGoal_TextChanged(object sender, EventArgs e)
        {
            String goal = tbGoal.Text;
            gReady = false;

            if (goal != "")
            {
                if (goal[goal.Length - 1] == '$' || goal[goal.Length - 1] == '.' || goal[goal.Length - 1] == '1' || goal[goal.Length - 1] == '2' || goal[goal.Length - 1] == '3' || goal[goal.Length - 1] == '4' || goal[goal.Length - 1] == '5' || goal[goal.Length - 1] == '6' || goal[goal.Length - 1] == '7' || goal[goal.Length - 1] == '8' || goal[goal.Length - 1] == '9' || goal[goal.Length - 1] == '0')
                {
                    Console.WriteLine("Here " + goal[goal.Length - 1]);
                } else
                {
                    Thread.Sleep(500);
                    String temp = "";
                    for(int i=0; i<goal.Length-1; i++)
                    {
                        temp += goal[i];
                    }
                    goal = temp;
                    tbGoal.Text = goal;
                    tbGoal.SelectionStart = tbGoal.Text.Length;
                }
            }
            tbGoal.Text = goal;
        }

        private void tbGoal_Click(object sender, EventArgs e)
        {
            if(tbGoal.Text == "")
            {
                tbGoal.Text = "$0.00";
            }
        }
    }
}
