using System;
using System.Collections.Generic;
using System.Text;

namespace yaz.sın_4
{
    public class RecycleObject
    {
        public int carbonAmount{ get; set; }

        public int quantityOfRecycleObject { get; set; }

        public string recycleObjectName { get; set; }
        public string typeOfRecycle { get; set; }
        public double recycleCoin { get; set; }
       
        private const double VALUE_OF_RECYCLECOIN = 0.00000001;
        double conversionFromCtoRC(RecycleObject recycleObject)
        {
            recycleObject.recycleCoin = recycleObject.quantityOfRecycleObject * recycleObject.carbonAmount * VALUE_OF_RECYCLECOIN;
           return recycleCoin; 
        
        }
        //Düzeltilecek



    }
}
