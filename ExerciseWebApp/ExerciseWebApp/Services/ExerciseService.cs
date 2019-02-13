using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ExerciseWebApp.Models;
using Newtonsoft.Json;

namespace ExerciseWebApp.Services
{
    public class ExerciseService : IExerciseService
    {
        public IEnumerable<Image> GetImages()
        {
            FileStream fileStream = null;
            Dictionary<string, IEnumerable<Image>> data = null;
            try
            {
                fileStream = new FileStream("data.json", FileMode.Open);
                string line = "";
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    line = reader.ReadToEnd();
                }
                data = JsonConvert.DeserializeObject<Dictionary<string, IEnumerable<Image>>>(line);
            }
            catch (Exception e) {
                return Enumerable.Empty<Image>();
            }

            return data["data"];
        }
    }
}
