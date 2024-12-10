using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgopiSek_Desktop_App_V2.App.Core
{
    public static class Session
    {
        public static int CurrentUserId { get; set; }
        public static int CurrentUserRole { get; set; }
        public static string CurrentUsername { get; set; }

        public static void ClearSession()
        {
            CurrentUserId = 0;
            CurrentUserRole = 0;
            CurrentUsername = string.Empty;
        }
    }
}
