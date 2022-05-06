using System.Data.SqlClient;

namespace HOW.Models
{
    public class SeekerRepositry
    {
        static string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HelpersOnWheel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static public int AddSeeker(Seeker s)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string query = "INSERT INTO SEEKER(FIRSTNAME,LASTNAME,AGE,GENDER,EMAIL,PASSWORD,PHONENUMBER) VALUES(@F,@L,@A,@G,@E,@P,@PH)";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter p1 = new SqlParameter("F",s.FirstName);
            SqlParameter p2 = new SqlParameter("L",s.LastName);
            SqlParameter p3 = new SqlParameter("A",s.Age);
            SqlParameter p4 = new SqlParameter("G",s.Gender);
            SqlParameter p5 = new SqlParameter("E",s.Email);
            SqlParameter p6 = new SqlParameter("P",s.Password);
            SqlParameter p7 = new SqlParameter("PH",s.PhoneNumber);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            int r = 0;
            try { r = cmd.ExecuteNonQuery(); }
            catch (SqlException ex)
            {
                r = -1;
            }
            con.Close();
            return r;
        }
        static public List<Seeker> GetSeekers()
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string query = "SELECT * FROM SEEKER";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            List<Seeker> seekers = new List<Seeker>();
            while (sqlDataReader.Read())
            {
                Seeker seeker = new Seeker();
                seeker.FirstName = (String)sqlDataReader.GetString(1);
                seeker.LastName = (String)sqlDataReader.GetString(2);
                seeker.Age = (int)sqlDataReader.GetInt32(3);
                seeker.Gender = (String)sqlDataReader.GetString(4);
                seeker.Email = (String)sqlDataReader.GetString(5);
                seeker.Password = (String)sqlDataReader.GetString(6);
                seeker.PhoneNumber = (String)sqlDataReader.GetString(7);
                seekers.Add(seeker);
            }
            con.Close();
            return seekers;
        }

        static public bool ValidateSeeker(Login l)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string query = "SELECT * FROM SEEKER WHERE EMAIL = @E AND PASSWORD = @P";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter p1 = new SqlParameter("E", l.Email);
            SqlParameter p2 = new SqlParameter("P", l.Password);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            bool rows = sqlDataReader.HasRows;
            con.Close();
            return rows;
        }
    }
}
