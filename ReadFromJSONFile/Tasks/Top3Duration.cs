using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromJSONFile.Tasks
{
    public class Top3Duration
    {
        public static void top3Duration()
        {
            
            string filepath = Path.Combine(Environment.CurrentDirectory, "data/MagicLandData.json");
            string json = File.ReadAllText(filepath);
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);


            var top3Destinations = categories
                .SelectMany(c => c.destinations)
                .Where(d => d.duration != null && int.TryParse(d.duration.Split(' ')[0], out _)) //Filters out destinations with a null duration and ensures the duration can be parsed to an integer.
                .Select(d => new   // Projects each destination into an anonymous object containing the destination and its parsed duration in minutes.
                {
                    Destination = d,
                    DurationMinutes = int.Parse(d.duration.Split(' ')[0])
                })
                .OrderByDescending(d => d.DurationMinutes)  // Orders the destinations by duration in descending order.
                .Take(3);

            int counter = 1;
            foreach (var item in top3Destinations)
            {
                Console.WriteLine($"{counter}- {item.Destination.name}: {item.DurationMinutes} minutes");
                counter++;
            }

        }
    }
}
