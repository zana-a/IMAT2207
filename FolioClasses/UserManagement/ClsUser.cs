using System;

namespace FolioClasses.UserManagement
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public DateTime Dob { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public int NumOfBooksBought { get; set; }

        public bool IsEmailVerified { get; set; }

        public bool Find(int id)
        {
            Id = 1;
            Name = "Barry Bones";
            Password = "pass123";
            Dob = Convert.ToDateTime("08/04/1999");
            Email = "someone@email.com";
            Telephone = "+447727184747";
            NumOfBooksBought = 123;
            IsEmailVerified = true;

            return true;
        }
    }
}
