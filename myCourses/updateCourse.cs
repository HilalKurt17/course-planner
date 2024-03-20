namespace myCourses
{
    public partial class updateCourse : Form
    {
        public updateCourse()
        {
            InitializeComponent();

        }

        public string courseName_update { get; set; }
        public DateTime courseCompletedTime { get; set; }

        public string courseAcademy_update { get; set; }
        public void update_bttn_Click(object sender, EventArgs e)
        {

            courseName_update = update_txtBx.Text;
            courseCompletedTime = Convert.ToDateTime(completedDateTime_txtBx.Text);
            courseAcademy_update = completedAcademyName_txtBx.Text;

            this.Close();

        }
    }
}
