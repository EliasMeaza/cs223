using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gui_ex
{
    internal class propertis
    {
            static List<propertis> prop = new List<propertis>();
        
            public int number { get; set; }
            public string? date { get; set; }
            public int sku { get; set; }
            public string? item_name { get; set; }
            public int quantity { get; set; }
            public double price { get; set; }
            
            public void save()
                {
                    Console.WriteLine ("db saved");
                    prop.Add(this);
                   
                }
            public  static List<propertis> GetAllProp()
            {
                return prop;
            }

    }
    }

