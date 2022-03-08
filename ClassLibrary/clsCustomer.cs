using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool CustomerMembership { get; set; }
        public DateTime CustomerDOB { get; set; }
        public int CustomerID { get; set; }
        public string CustomerForename { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerTel { get; set; }

        public bool Find(int addressNo)
        {
            //always return true
            return true;
        }
    }
}