using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Availability { get; set; }
        public DateTime InitialReleaseDate { get; set; }
        public int ShoeID { get; set; }
        public string ShoeDescription { get; set; }
        public string ShoeColour { get; set; }
        public int Quantity { get; set; }
    }
}