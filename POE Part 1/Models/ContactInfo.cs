using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace POE_Part_1.Models
{
    public class ContactInfo : Controller
    {
        public static string con_string = "Server=tcp:10037533-server.database.windows.net,1433;Initial Catalog=CloudDev-SQL-Server;Persist Security Info=False;User ID=taylorfebruary;Password=February#15;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public static SqlConnection con = new SqlConnection (con_string);
        public IActionResult Index()
        {
            return View();
        }
    }
}
