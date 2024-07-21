using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromJSONFile.Tasks
{
    public class LongestDuration
    {
        public static void longestDeuration()
        {
            string filepath = Path.Combine(Environment.CurrentDirectory, "data/MagicLandData.json");
            string json = File.ReadAllText(filepath);
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);


            var sdsd = categories
                .SelectMany(c => c.destinations) //SelectMany to flatten the list of categories into a single list of destinations.
                .Where(d => d.duration != null && int.TryParse(d.duration.Split(' ')[0], out _)) //Where: Filter out destinations with a null duration and ensure the duration can be parsed to an integer.
                .Select(d => new
                {
                    Destination = d,
                    DurationMunite = int.Parse(d.duration.Split(' ')[0])
                })
                .OrderByDescending(d=> d.DurationMunite)
                .FirstOrDefault();

            if (sdsd != null)
            {
                Console.WriteLine($"The destination with the longest duration is: {sdsd.Destination.name}");
            }
            else
            {
                Console.WriteLine("No valid destinations found.");
            }








        }
    }
}
