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
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password  { get; set; }
        public string Hash { get; set; }
       

        public Person()
        {
                
        }
  
        
        //SHA_256 adresi
        public static string CalculateHash(string usernamehash,string paswordhash)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] inbytes = Encoding.ASCII.GetBytes($"{usernamehash}-{paswordhash}");
            byte[] outbytes = sha256.ComputeHash(inbytes);
            return Convert.ToBase64String(outbytes);
        }

        public override string ToString()
        {
            return firstname +" " + lastname;
        }

    }
}
