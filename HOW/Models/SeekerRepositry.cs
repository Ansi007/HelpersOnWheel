using System.Data.SqlClient;
using System.Net.Mail;
using HOW.Migrations;
using HOW.Models.Interfaces;

namespace HOW.Models
{
    public class SeekerRepositry : ISeekerRepository
    {
        public int AddSeeker(Seeker s)
        {
            var context = new HelpersOnWheelContext();
            context.Seekers.Add(s);
            return context.SaveChanges();
        }
        public List<Seeker> GetSeekers()
        {
            var context = new HelpersOnWheelContext();
            return context.Seekers.ToList();
        }

        public bool ValidateSeeker(Login l)
        {
            var context = new HelpersOnWheelContext();
            foreach(Seeker seeker in context.Seekers)
            {
                if(seeker.Email == l.Email && seeker.Password == l.Password)
                {
                    SessionManagement.currentUserName = seeker.FirstName + " " + seeker.LastName;
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
