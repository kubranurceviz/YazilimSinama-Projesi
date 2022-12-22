

namespace yaz.sın_4
{
   public  class Account
    {
        Person _person;
        public Person person {
            get
            {
                return _person;
            }
            set
            {
                _person = value;
            }
        }
        public Account()
        {

        }
        public Account(Person person)
        {
            this.person = person;
        }
       public void transfer( Person reciever, double _transferAmount)
        {  

            recycleCoin -= _transferAmount ;
            reciever.account.recycleCoin += _transferAmount;

            //person alıp hash'ine gönderme 
        }
        
        public double recycleCoin { get; set; }
       
       

    }
}
