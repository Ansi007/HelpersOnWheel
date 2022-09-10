using Microsoft.AspNetCore.Mvc;
using HOW.Models;
using HOW.Controllers;

namespace HOW.Models
{
    public class SessionManagement
    {
        public static string currentUserEmail = "";
        public static string currentUserName = "";

        public void GetSession(HttpContext httpContext)
        {
            if (httpContext.Session.Keys.Contains("LOGIN_SUCCESS_EMAIL"))
            {
                currentUserEmail = httpContext.Session.GetString("LOGIN_SUCCESS_EMAIL");
                currentUserName = httpContext.Session.GetString("LOGIN_SUCCESS_NAME");
            }
        }

        public void SetSession(HttpContext httpContext)
        {
            httpContext.Session.SetString("LOGIN_SUCCESS_EMAIL", currentUserEmail);
            httpContext.Session.SetString("LOGIN_SUCCESS_NAME", currentUserName);
        }

        public void Remove(HttpContext httpContext)
        {
            httpContext.Session.Remove("LOGIN_SUCCESS_EMAIL");
            httpContext.Session.Remove("LOGIN_SUCCESS_NAME");
        }

        public void Logout(HttpContext httpContext)
        {
            currentUserEmail = "";
            currentUserName = "";
            Remove(httpContext);
        }
    }
}
