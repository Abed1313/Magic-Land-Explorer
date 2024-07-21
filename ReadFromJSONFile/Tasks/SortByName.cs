using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromJSONFile.Tasks
{
    public class SortByName
    {
        public static void sortByName()
        {
            string filepath = Path.Combine(Environment.CurrentDirectory, "data/MagicLandData.json");
            string json = File.ReadAllText(filepath);
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);

            var ffff= from category in categories
                      from destination in category.destinations
                      orderby destination.name
                      select destination;

            foreach (var item in ffff)
            {
                Console.WriteLine(item.name);
            }
        }
    }
}
