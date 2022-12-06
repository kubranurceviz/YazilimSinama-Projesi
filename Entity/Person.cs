using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace yaz.sın_4
{
   public class Person

    {
        Account _account;
        public Account account
        {
            get { return _account; }

            set { _account = value; }
        }
        
        public string username { get; set; }
        public string password  { get; set; }

        private string hash;
        public string Hash {
            get
            {
                return this.hash;
            } 
            set 
            {
                this.hash = CalculateHash();
            }
        }
        public Person()
        {
                
        }
        public Person(string username, string password, Account account)
        {
            this.password = password;
            this.username = username;
            this.account = account;
        }
        
        //SHA_256 adresi
        public string CalculateHash()
        {
            SHA256 sha256 = SHA256.Create();
            byte[] inbytes = Encoding.ASCII.GetBytes($"{username}-{password}");
            byte[] outbytes = sha256.ComputeHash(inbytes);
            return Convert.ToBase64String(outbytes);
        }

    }
}
