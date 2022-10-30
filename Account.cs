using System;
using System.Collections.Generic;
using System.Text;

namespace yaz.sın_4
{
   public  class Account
    {
        public Person person;
        public Account(Person person)
        {
            this.person = person;
        }
       public void transfer( Person reciever, double _transferAmount)
        {
            this.recycleCoin -= _transferAmount ;
            reciever.account.recycleCoin += _transferAmount;

            //person alıp hash'ine gönderme 
        }

        public double recycleCoin { get; set; }
        public  double transferAmount { get; set; }
        
        
       
        
        
        public int quantityOfCarbon { get; set; }





    }
}
