namespace myCourses
{
    public partial class deleteCourse : Form
    {
        public deleteCourse()
        {
            InitializeComponent();
        }
        public string deleteCourseName { get; set; }

        public string deleteAcademyName { get; set; }
        private void deleteCourse_bttn_Click(object sender, EventArgs e)
        {
            deleteCourseName = deleteCourse_txtBx.Text;

            deleteAcademyName = deleteAcademyName_txtBx.Text;

            this.Close();
        }
    }
}
