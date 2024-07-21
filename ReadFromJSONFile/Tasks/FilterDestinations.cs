using Newtonsoft.Json;
using ReadFromJSONFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromJSONFile.Tasks
{
    public class FilterDestinations :Category
    {
        public static void filterDestinations()
        {
            string filepath = Path.Combine(Environment.CurrentDirectory, "data/MagicLandData.json");
            string json = File.ReadAllText(filepath);
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);


            var asasasas = from category in categories
                           from destination in category.destinations 
                           where destination.duration != null &&
                                 int.TryParse(destination.duration.Split(' ')[0], out int DrMunite) &&
                                 DrMunite <100
                           select destination.name;

            // Execute the query

            foreach (var item in asasasas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
//var shortDurationDestinations = from category in categories
//                                from destination in category.destinations
//                                where destination.duration != null &&
//                                      int.TryParse(destination.duration.Split(' ')[0], out int durationMinutes) &&
//                                      durationMinutes < 100
//                                select destination.name;
