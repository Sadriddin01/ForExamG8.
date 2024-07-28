using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ForExamG8.Services
{
    public partial class Services
    {
        public static string GetAboutPath()
        {
            string currentPath=Directory.GetCurrentDirectory();
            currentPath += @"\aboutRestaurant.json";
            return currentPath;
        }
        public void SaveAbout(List<About>abouts)
        {
            string serialized=JsonSerializer.Serialize(abouts);
            File.WriteAllText(GetAboutPath(), serialized);
        }
        public void DeleteAbout()
        {
            File.WriteAllText(GetAboutPath(), string.Empty);
            Console.WriteLine("Info Cleaned!");
        }
        public void AddAbout()
        {
            List<About> abouts = GetAbout();

            if(abouts.Count > 0)
            {
                Console.Write("Reference already exists . No new info is added.");
                return;
            }
            Console.Write("Enter the Restaurant Information and Press 'ENTER' after entering");
            string aboutName=Console.ReadLine();

            int newId = 1;

            About newAbout = new About
            {
                Id=newId,
                Name=aboutName
            };
            abouts.Add(newAbout);
            SaveAbout(abouts);
            Console.WriteLine("Information Added Successfully!");
        }
        public List<About> GetAbout()
        {
            if(!File.Exists(GetFoodsPath()))
            {
                Console.WriteLine("No Data Aviable!");
            }
            if(!File.Exists(GetFoodsPath()))
            {
                return new List<About>();
            }

            string jsonFromFile=File.ReadAllText(GetFoodsPath());
            var abouts = string.IsNullOrEmpty(jsonFromFile) ? new List<About>() : JsonSerializer.Deserialize<List<About>>(jsonFromFile);
            foreach(var about in abouts)
            {
                Console.WriteLine($"Reference:{about.Name}");
            }
            return abouts;
        }
        public void ClearIFile()
        {
            List<About> abouts= GetAbout();
            if(abouts.Count>0)
            {
                Console.WriteLine("No Data Aviable!");
                return;
            }
            abouts.Clear();
            SaveAbout(abouts);
            Console.WriteLine("Informations cleared successfully!");
        }
        public void UpdateAbout()
        {
            List<About> abouts = GetAbout();
            if(abouts.Count==0)
            {
                Console.WriteLine("No Data aviable!");
                return;
            }

            About aboutToUpdate = abouts[0];

            Console.Write("Enter New Inforation");
            string newName=Console.ReadLine();
            if(!string.IsNullOrEmpty(newName))
            {
                aboutToUpdate.Name = newName;
            }
            SaveAbout(abouts);
            Console.WriteLine("Info updated successfully!");
        }
    }
}
