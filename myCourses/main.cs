using System.Data;
using System.Data.SqlClient;

namespace myCourses
{
    public class main
    {
        SqlConnection connect = new SqlConnection();
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

        public DataTable connect_database()
        {
            // build the connection string
            builder.DataSource = ".";
            builder.InitialCatalog = "Courses";
            builder.UserID = "sa";
            builder.Password = "1";


            connect.ConnectionString = builder.ConnectionString;
            //// write the command which is select all in this case
            //SqlCommand command = new SqlCommand("Select * from myCourses", connect);

            connect.Open(); // open c#-SQL connection

            // write command and get all values from the specified SQL table

            SqlDataAdapter adapter = new SqlDataAdapter("Select * from myCourses", connect);
            DataTable table = new DataTable();
            adapter.Fill(table); // fill a datatable object with data


            connect.Close(); // close connection

            return table;

        }


        public void CourseOperations(string operation, string userName, string academy, string courseName, DateTime? deadline, bool courseState)
        {
            // build connection string
            builder.DataSource = ".";
            builder.InitialCatalog = "Courses";
            builder.UserID = "sa";
            builder.Password = "1";


            connect.ConnectionString = builder.ConnectionString;


            connect.Open();
            if (operation == "update")
            {
                // perform update operation with updateCourse store procedure
                SqlCommand update_command = new SqlCommand("updateCourse", connect);
                update_command.CommandType = CommandType.StoredProcedure;

                update_command.Parameters.Add("@courseName", SqlDbType.NVarChar).Value = courseName;
                update_command.Parameters.Add("@academy", SqlDbType.NVarChar).Value = academy;
                update_command.Parameters.Add("@completionTime", SqlDbType.SmallDateTime).Value = deadline;
                update_command.Parameters.AddWithValue("@courseState", courseState ? 1 : 0);
                update_command.ExecuteNonQuery();
            }

            else if (operation == "delete")
            {
                // perform delete operation with deleteCourse store procedure
                SqlCommand delete_command = new SqlCommand("deleteCourse", connect);
                delete_command.CommandType = CommandType.StoredProcedure;

                delete_command.Parameters.Add("@academy", SqlDbType.NVarChar).Value = academy;
                delete_command.Parameters.Add("@courseName", SqlDbType.NVarChar).Value = courseName;

                delete_command.ExecuteNonQuery();

            }

            else if (operation == "register")
            {

                // perform register operation with written command below
                SqlCommand command = new SqlCommand("insert into myCourses ([User Name], Academy, [Course Name], Deadline,[Course State]) values (@userName, @academy, @courseName, @deadline, @courseState)", connect);

                command.Parameters.Add("@userName", SqlDbType.NVarChar).Value = userName;
                command.Parameters.Add("@courseName", SqlDbType.NVarChar).Value = courseName;
                command.Parameters.Add("@academy", SqlDbType.NVarChar).Value = academy;
                command.Parameters.Add("@deadline", SqlDbType.SmallDateTime).Value = deadline;
                command.Parameters.AddWithValue("@courseState", courseState ? 1 : 0);
                ;
                command.ExecuteNonQuery();
            }

            connect.Close();

        }
    }
}
