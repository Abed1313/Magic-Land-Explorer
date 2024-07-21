using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromJSONFile
{
    public class Category
    {
        public string category { get; set; }
        public List<Destination> destinations { get; set; }
    }
}
