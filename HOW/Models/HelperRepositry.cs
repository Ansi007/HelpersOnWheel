using System.Data.SqlClient;
using System.Net.Mail;

namespace HOW.Models
{
    public class HelperRepositry
    {
        static public int AddHelper(Helper h)
        {
            var context = new HelpersOnWheelContext();
            context.Helpers.Add(h);
            return context.SaveChanges();
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
        }
        static public bool ValidateHelper(Login l)
        {
            var context = new HelpersOnWheelContext();
            foreach(Helper h in context.Helpers)
            {
                if(h.Email == l.Email && h.Password == l.Password)
                {
                    SessionManagement.currentUserName = h.FirstName + " " + h.LastName;
                    return true;
                }
            }
            return false;
        }

        public string ValidateEmail(String email)
        {
            if (email == "" || email == null)
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
            foreach (Helper seeker in context.Helpers)
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
