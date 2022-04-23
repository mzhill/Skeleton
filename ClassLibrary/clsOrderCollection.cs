using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member thisStock
        clsOrder mThisOrder = new clsOrder();
       
        //public property for the order list
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        public List<clsOrder> OrderList { get; set; }
        public int Count { get; set; }
        public clsOrder ThisOrder { get; set; }
    }
}