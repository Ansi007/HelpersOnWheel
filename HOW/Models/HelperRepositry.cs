using System.Data.SqlClient;
namespace HOW.Models
{
    public class HelperRepositry
    {
        static string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HelpersOnWheel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static public int AddHelper(Helper h)
        {
            var context = new HelpersOnWheelContext();
            context.Helpers.Add(h);
            return context.SaveChanges();

/*            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string query = "INSERT INTO HELPER(FIRSTNAME,LASTNAME,AGE,GENDER,PROFESSION,EMAIL,PASSWORD,PHONENUMBER,ADDRESS,CITY,ZIP) VALUES(@F,@L,@A,@G,@PR,@E,@P,@PH,@AD,@C,@Z)";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter p1 = new SqlParameter("F", h.FirstName);
            SqlParameter p2 = new SqlParameter("L", h.LastName);
            SqlParameter p3 = new SqlParameter("A", h.Age);
            SqlParameter p4 = new SqlParameter("G", h.Gender);
            SqlParameter p5 = new SqlParameter("E", h.Email);
            SqlParameter p6 = new SqlParameter("P", h.Password);
            SqlParameter p7 = new SqlParameter("PH", h.PhoneNumber);
            SqlParameter p8 = new SqlParameter("PR", h.Profession);
            SqlParameter p9 = new SqlParameter("AD", h.Address);
            SqlParameter p10 = new SqlParameter("C", h.City);
            SqlParameter p11 = new SqlParameter("Z", h.Zip);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);
            cmd.Parameters.Add(p9);
            cmd.Parameters.Add(p10);
            cmd.Parameters.Add(p11);
            int r = 0;
            try { r = cmd.ExecuteNonQuery(); }
            catch (SqlException ex) {
                r = -1;
            }
            con.Close();
            return r;*/
        }
        static public List<Helper> GetHelpers()
        {
            List<Helper> helpers = new List<Helper>();
            var context = new HelpersOnWheelContext();
            foreach(Helper h in context.Helpers)
            {
                helpers.Add(h);
            }
            return helpers;

            /*SqlConnection con = new SqlConnection(connString);
            con.Open();
            string query = "SELECT * FROM HELPER";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            List<Helper> helpers = new List<Helper>();
            while (sqlDataReader.Read())
            {
                Helper helper = new Helper();
                helper.FirstName = (String)sqlDataReader.GetString(1);
                helper.LastName = (String)sqlDataReader.GetString(2);
                helper.Age = (int)sqlDataReader.GetInt32(3);
                helper.Gender = (String)sqlDataReader.GetString(4);
                helper.Profession = (String)sqlDataReader.GetString(5);
                helper.Email = (String)sqlDataReader.GetString(6);
                helper.Password = (String)sqlDataReader.GetString(7);
                helper.PhoneNumber = (String)sqlDataReader.GetString(8);
                helper.Address = (String)sqlDataReader.GetString(9);
                helper.City = (String)sqlDataReader.GetString(10);
                helper.Zip = (int)sqlDataReader.GetInt32(11);
                helpers.Add(helper);
            }
            con.Close();
            return helpers;*/
        }
        static public bool ValidateHelper(Login l)
        {
            var context = new HelpersOnWheelContext();
            foreach(Helper h in context.Helpers)
            {
                if(h.Email == l.Email && h.Password == l.Password)
                {
                    return true;
                }
            }
            return false;
/*            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string query = "SELECT * FROM HELPER WHERE EMAIL = @E AND PASSWORD = @P";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter p1 = new SqlParameter("E", l.Email);
            SqlParameter p2 = new SqlParameter("P", l.Password);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            bool rows = sqlDataReader.HasRows;
            con.Close();
            return rows;*/
        }
    }
}
