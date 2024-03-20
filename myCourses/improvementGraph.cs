using System.Data;

namespace myCourses
{
    public partial class improvementGraph : Form
    {
        DataTable data = new DataTable();

        Dictionary<string, int> monthlyProgress = new Dictionary<string, int>()

            {
            {"January", 0},
            {"February", 0},
            {"March", 0},
            {"April", 0},
            {"May", 0},
            {"June", 0},
            {"July", 0},
            {"August", 0},
            {"September", 0},
            {"October", 0},
            {"November", 0},
            {"December", 0}  };

        Dictionary<int, Dictionary<string, int>> course;

        public improvementGraph()
        {
            InitializeComponent();

        }

        // get data from database, create data for graph
        public void database_connection()
        {
            // create dictionary to count completed courses
            course = new Dictionary<int, Dictionary<string, int>>();

            course.Add(2024, monthlyProgress);


            main database_builder = new main();
            // get DataTable(data) from main.cs file and create appropriate data for graph
            data = database_builder.connect_database();
            System.Data.DataRowCollection dataRows = data.Rows; // assign all rows to dataRows


            foreach (System.Data.DataRow row in dataRows)
            {
                string name = Convert.ToString(row["User Name"]);
                if ((row["Completed Time"] == null) || (row["Completed Time"].ToString() == ""))
                {   // continue if course is not completed.
                    continue;
                }
                string time = row["Completed Time"].ToString();
                // get completion time data for each course
                DateTime completionTime = Convert.ToDateTime(time);
                int month = completionTime.Month;

                switch (month) // count completed courses for each month
                {
                    case 1:
                        course[2024]["January"] = course[2024]["January"] + 1;
                        break;
                    case 2:
                        course[2024]["February"] = course[2024]["February"] + 1;
                        break;
                    case 3:
                        course[2024]["March"] = course[2024]["March"] + 1;
                        break;
                    case 4:
                        course[2024]["April"] = course[2024]["April"] + 1;
                        break;
                    case 5:
                        course[2024]["May"] = course[2024]["May"] + 1;
                        break;
                    case 6:
                        course[2024]["June"] = course[2024]["June"] + 1;
                        break;
                    case 7:
                        course[2024]["July"] = course[2024]["July"] + 1;
                        break;
                    case 8:
                        course[2024]["August"] = course[2024]["August"] + 1;
                        break;
                    case 9:
                        course[2024]["September"] = course[2024]["September"] + 1;
                        break;
                    case 10:
                        course[2024]["October"] = course[2024]["October"] + 1;
                        break;
                    case 11:
                        course[2024]["November"] = course[2024]["November"] + 1;
                        break;
                    case 12:
                        course[2024]["December"] = course[2024]["December"] + 1;

                        break;
                }


            }

        }

        private void improvementGraph_Load(object sender, EventArgs e)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            database_connection();

            foreach (string month in months)
            {

                improvement_chrt.Series["Completed Courses"].Points.Add(course[2024][month]);
                // get index of the added point 
                int new_index = improvement_chrt.Series["Completed Courses"].Points.Count - 1;
                // assign index of the added point to the XValue
                improvement_chrt.Series["Completed Courses"].Points[new_index].XValue = new_index + 1;
                // label the point
                improvement_chrt.Series["Completed Courses"].Points[new_index].AxisLabel = month;
                improvement_chrt.Series["Completed Courses"].Points[new_index].Color = Color.Teal;
            }











        }
    }
}
