using QuanLyKhachSan.receptionist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Mainformreceptionist : Form
    {
        public Mainformreceptionist()
        {
            InitializeComponent();
        }
        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checkinlabor  check = new Checkinlabor();
            check.ShowDialog();
        }
        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //StudentListForm SdtList = new StudentListForm();
            //SdtList.Show(this);
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            if (Global.Globalrole.ToString() == "Labor")
            {
                checkInOutReceptoinistToolStripMenuItem.Visible = false;
                employeesToolStripMenuItem.Visible = false;
                managementGuestToolStripMenuItem.Visible = false;
                managementFoodToolStripMenuItem.Visible = false;
                managementFoodToolStripMenuItem.Visible = false;
                roomToolStripMenuItem.Visible = false;
                ReservationToolStripMenuItem.Visible = false;
            }
            
            else
            {

            }    
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //StaticsForm StF = new StaticsForm();
            //StF.Show(this);
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ManageStudentForm MSF = new ManageStudentForm();
            //MSF.Show(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UpdateDeleteStudentForm Udstf = new UpdateDeleteStudentForm();
            //Udstf.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Print pt = new Print();
            //pt.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddCourse acourse   = new AddCourse();
            //acourse.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //RemoveCourseForm rmvCourse = new RemoveCourseForm();
            //rmvCourse.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EditCourseForm edtCourse = new EditCourseForm();
            //edtCourse.Show(this);
        }

        private void managerCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ManageCourseForm mngC = new ManageCourseForm();
            //mngC.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //PrintCourse prtcourse = new PrintCourse();
            //prtcourse.Show(this);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddScoreForm addScore= new AddScoreForm();
            //addScore.Show(this);
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //RemoveScoreForm rmscore = new RemoveScoreForm();
            //rmscore.Show(this);
        }
        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.BackColor != Color.Blue)
                e.ClickedItem.BackColor = Color.Blue;
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ManageScoreForm manageScore = new ManageScoreForm();
            //manageScore.Show(this);
        }

        private void avgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AvgScoreByCourseId avg = new AvgScoreByCourseId();
            //avg.Show(this);
        }

        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //ScorebySubject print = new ScorebySubject();
            //print.Show(this);
        }

        private void aVGResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Studentresult stdre = new Studentresult();
            //stdre.Show(this);
        }

        private void staticResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //StaticsResult sre  = new StaticsResult();
            //sre.Show(this);
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Management mnglabor = new Management();
            mnglabor.ShowDialog();
        }

        private void checkInoutReceptionistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void checkInoutReceptionistToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void checkinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void managementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void checkInoutReceptionistToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            
        }

        private void managementGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagementGuest guest = new ManagementGuest();
            guest.ShowDialog();
        }

        private void managementFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagementFood food = new ManagementFood();
            food.ShowDialog();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagementRoom room = new ManagementRoom();
            room.ShowDialog();
        }

        private void checkInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checkinlabor check = new Checkinlabor();
            check.ShowDialog();
        }

        private void managementLaborToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Management labor = new Management();
            labor.ShowDialog();
        }

        private void managementReceptionistToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkInOutReceptoinistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checkinreception checkinrecep = new Checkinreception();
            checkinrecep.ShowDialog();
        }
    }
}
