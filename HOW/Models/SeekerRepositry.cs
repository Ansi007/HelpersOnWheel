using System.Data.SqlClient;
using System.Net.Mail;

namespace HOW.Models
{
    public class SeekerRepositry
    {
        //static string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HelpersOnWheel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static public int AddSeeker(Seeker s)
        {
            var context = new HelpersOnWheelContext();
            context.Seekers.Add(s);
            return context.SaveChanges();
        }
        static public List<Seeker> GetSeekers()
        {
            var context = new HelpersOnWheelContext();
            return context.Seekers.ToList();
        }

        static public bool ValidateSeeker(Login l)
        {
            var context = new HelpersOnWheelContext();
            foreach(Seeker seeker in context.Seekers)
            {
                if(seeker.Email == l.Email && seeker.Password == l.Password)
                {
                    return true;
                }
            }
            return false;
        }
        public string ValidateEmail(String email)
        {
            if(email == "" || email == null)
            {
                return "NOT_AVAILABLE";
            }
            try
            {
                MailAddress m = new MailAddress(email);
            }
            catch (FormatException)
            {
                return "NOT_AVAILABLE";
            }

            var context = new HelpersOnWheelContext();
            foreach (Seeker seeker in context.Seekers)
            {
                if (seeker.Email == email)
                {
                    return email;
                }
            }
            return "";
        }
    }
}
