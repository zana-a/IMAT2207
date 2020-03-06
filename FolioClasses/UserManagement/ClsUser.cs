using System;

namespace FolioClasses.UserManagement
{
    public class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public DateTime Dob { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public int NumOfBooksBought { get; set; }

        public bool IsEmailVerified { get; set; }

        public bool Find(int id)
        {
            //UserId = 1;
            //Name = "Barry Bones";
            //Password = "pass123";
            //Dob = Convert.ToDateTime("08/04/1999");
            //Email = "someone@email.com";
            //Telephone = "+447727184747";
            //NumOfBooksBought = 123;
            //IsEmailVerified = true;

            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@UserID", UserId);
            db.Execute("sproc_tblUser_FindByUserId");

            if(db.Count == 1)
            {
                UserId = Convert.ToInt32(db.DataTable.Rows[0]["user_id"]);
                Name = Convert.ToString(db.DataTable.Rows[0]["user_fullname"]);
                Password = Convert.ToString(db.DataTable.Rows[0]["user_password"]); ;
                Dob = Convert.ToDateTime(db.DataTable.Rows[0]["user_dob"]);
                Email = Convert.ToString(db.DataTable.Rows[0]["user_email"]);
                Telephone = Convert.ToString(db.DataTable.Rows[0]["user_telephone"]);
                NumOfBooksBought = Convert.ToInt32(db.DataTable.Rows[0]["user_numof_books_bought"]);
                IsEmailVerified = Convert.ToBoolean(db.DataTable.Rows[0]["user_is_email_verified"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
