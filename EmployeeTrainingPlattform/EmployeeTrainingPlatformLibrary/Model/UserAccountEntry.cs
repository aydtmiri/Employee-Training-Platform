using EmployeeTrainingPlattformLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EmployeeTrainingPlatformLibrary.Logic
{
    public class UserAccountEntry
    {
        

        public UserAccountEntry()
        {

        }
        public UserAccountEntry(string emailAddress, string password)
        {
            this.PasswordSalt = PasswordCryptoLogic.GenerateSalt();
            this.PasswordHash = PasswordCryptoLogic.ComputeHash(password, this.PasswordSalt);
            this.EmailAddress = emailAddress;

        }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string EmailAddress { get; set; }
        public int EmployeeId { get; set; }
        public int Id { get; set; }


    }
}
