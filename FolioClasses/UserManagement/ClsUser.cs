using System;

namespace FolioClasses.UserManagement
{
    public class User
    {
        private int Id;
        private Name Name;
        private string Password;
        private string Dob;
        private string Email;
        private string Telephone;
        private int NumOfBooksBought;

        public User(int id, Name name, string password, string dob, string email, string telephone, int numOfBooksBought)
        {
            Id = id;
            Name = name;
            Password = password;
            Dob = dob;
            Email = email;
            Telephone = telephone;
            NumOfBooksBought = numOfBooksBought;
        }

        public bool Find(string userID)
        {
            throw new NotImplementedException();
        }
    }
}