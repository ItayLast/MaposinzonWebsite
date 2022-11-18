using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using System;

namespace Maposinzon.Pages
{

    public class RegisterModel : PageModel
    {
        public string table = "";
        public string list = "";
        public string st = "";
        public string msg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            userExisit.Text = ("");
            string fileName = "AnimalsDB.mdf";
            string tableName = "[User]";
            string sqlSelect = "";

            if (Request.Form["submit"] != null)
            {
                //--- שליפת המידע שהגיע מהטופס לתוך משתנים ---
                string uName = Request.Form["uName"];
                //validate userName
                sqlSelect = "SELECT * FROM " + tableName + " where uName = '" + uName + "'";
                DataTable dt = Helper.ExecuteDataTable(fileName, sqlSelect);
                if (dt.Rows.Count != 0)
                {
                    userExisit.Text = ("שם המשתמש קיים, נא להחליף");
                    return;
                }

                string pwd = Request.Form["pwd"];
                string fName = Request.Form["fName"];
                string lName = Request.Form["lName"];
                string email = Request.Form["email"];

                string phoneNumber = Request.Form["phone"];
                string className = Request.Form["classType"];
                string classNumber = Request.Form["class"];
                string gender = Request.Form["gender"];
                string bDay = Request.Form["birthday"];
                string maijors = Request.Form["megama"];

                table = "<table border='1' dir='ltr'>";

                table += "<tr><th colspan='2'>הפרטים שהתקבלו מהשרת</th></tr>";
                table += "<tr><td>" + uName + "</td><td>:שם משתמש</td></tr>";
                table += "<tr><td>" + pwd + "</td><td>:סיסמה</td></tr>";
                table += $"<tr><td>{fName}</td><td>:שם פרטי</td></tr>";
                table += $"<tr><td>{lName}</td><td>:שם משפחה</td></tr>";
                table += $"<tr><td>{email}</td><td>:אימייל</td></tr>";

                table += "<tr><td>" + phoneNumber + "</td><td>:מספר טלפון</td></tr>";
                table += "<tr><td>" + className + "</td><td>:שכבה</td></tr>";
                table += $"<tr><td>{classNumber}</td><td>:כיתה</td></tr>";
                table += $"<tr><td>{gender}</td><td>:מגדר</td></tr>";
                table += $"<tr><td>{bDay}</td><td>:תאריך לידה</td></tr>";
                table += $"<tr><td>{maijors}</td><td>:מגמות</td></tr>";

                table += "</table>";

                sqlSelect = $"INSERT INTO[dbo].[User](uName, pwd, fName, lName, email, " +
                            $"phone, classType, class, gender, birthday, megama) " +
                           $"VALUES('{uName}', '{pwd}', N'{fName}', N'{lName}', '{email}'," +
                           $"'{phoneNumber}', N'{className}', '{classNumber}' , N'{gender}', " +
                           $"'{bDay}', N'{maijors}')";

                dt = Helper.ExecuteDataTable(fileName, sqlSelect);
            }
            */
        }

    }
}
