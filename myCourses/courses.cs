using System.Data;

namespace myCourses
{
    public partial class courses : Form
    {
        public courses()
        {
            InitializeComponent();
        }

        main database = new main();
        improvementGraph graph = new improvementGraph();
        private void bttn_allCourses_Click(object sender, EventArgs e)
        {
            // fill dataGridView1 with data from SQL
            DataTable all_courses = database.connect_database();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.DataSource = all_courses;
            dataGridView1.Columns["Course Name"].Width = 290;

        }

        private void progress_bttn_Click(object sender, EventArgs e)
        {
            //graph.database_connection();
            using (var progressForm = new improvementGraph())
            {
                progressForm.ShowDialog();
            }

        }
        private void bttn_clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender; //  get the button name which is clicked by user
            string button_name = button.Text;


            string userName = txtBx_userName.Text; // get value from userName textBox
            string academy = txtBx_courseAcademy.Text; // get value from Course Academy textBox
            string courseName = txtBx_courseName.Text; // get value from Course Name textBox
            DateTime deadline;
            // check if user entered the deadline or not. If user did not enter the deadline, assign a default deadline
            if (txtBx_dueDate.Text != "")
            {
                deadline = DateTime.Parse(txtBx_dueDate.Text);
            }
            else
            {
                deadline = DateTime.Parse("01-01-2025");
            }
            // get value of the checkBox
            bool is_finished = chckBx_isFinished.Checked;

            if (button_name == "UPDATE") // if update button clicked, update the data
            {
                string update_courseName;

                string courseAcademy;

                DateTime completeTime;

                using (var updateForm = new updateCourse()) // open update form
                {
                    updateForm.ShowDialog(); // show form as modal window (you cannot do anything on main form before closing the update form)
                    update_courseName = updateForm.courseName_update; // course name to update
                    completeTime = updateForm.courseCompletedTime; // complete time of course
                    courseAcademy = updateForm.courseAcademy_update;
                }
                if ((update_courseName != null) && (completeTime != null))
                {
                    database.CourseOperations("update", "", courseAcademy, update_courseName, completeTime, true);
                }

            }
            else if (button_name == "DELETE") // if delete button clicked, delete the data
            {
                string delete_courseName;

                string delete_academyName;

                using (var deleteForm = new deleteCourse())
                {
                    deleteForm.ShowDialog();
                    delete_courseName = deleteForm.deleteCourseName;
                    delete_academyName = deleteForm.deleteAcademyName;

                }
                if ((delete_courseName != null) && (delete_academyName != null))
                {
                    database.CourseOperations("delete", "", delete_academyName, delete_courseName, deadline, true);
                }
            }
            else if (button_name == "REGISTER") // if register button clicked, add the data
            {
                database.CourseOperations("register", userName, academy, courseName, deadline, is_finished);
            }

            // clear textBoxes

            txtBx_userName.Text = "";
            txtBx_dueDate.Text = "";
            txtBx_courseName.Text = "";
            txtBx_courseAcademy.Text = "";
            chckBx_isFinished.Checked = false;

        }


    }
}
