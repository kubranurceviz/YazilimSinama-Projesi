using System;
using System.Collections.Generic;
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
       
        public string hash { get; set; }
        //SHA_256 adresi
      

    }
}
