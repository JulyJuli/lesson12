using System.Collections.Generic;
using Task4.Interfaces;


namespace Task4
{
    public class Storage
    {
        public Storage()
        {
            Products = new List<IInfo>();
        }
        public List<IInfo> Products { get; set; }
    }
}