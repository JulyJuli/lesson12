using System.Collections.Generic;
using Task_4.Interfaces;

namespace Task_4
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


