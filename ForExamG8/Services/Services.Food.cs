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
        public static string GetFoodsPath()
        {
            string currentPath=Directory.GetCurrentDirectory();
            currentPath += @"\foods.json";
            return currentPath;
        }
        public void ClearFFile()
        {
            File.WriteAllText(GetFoodsPath(), string.Empty);
            Console.WriteLine("Food List Are Cleaned!");
        }
        public void SaveFoods(List<Foods> foods)
        {
            string serialized = JsonSerializer.Serialize(foods);
            File.WriteAllText(GetFoodsPath(), serialized);
        }
        public void AddFood()
        {
            List<Foods> foods = GetFoods();
            Console.Write("Enter Food Name: ");
            string foodName = Console.ReadLine();

            Foods newFoods = new Foods
            {
                Name = foodName,
            };
            foods.Add(newFoods);
            SaveFoods(foods);
            Console.WriteLine("Food Added successfully!");
        }
        public List<Foods> GetFoods()
        {
            if(!File.Exists(GetFoodsPath()))
            {
                Console.WriteLine("There is no foods yet!");
            }
            if(!File.Exists(GetFoodsPath()))
            {
                return new List<Foods>();
            }
            string jsonFromFile=File.ReadAllText(GetFoodsPath());
            var foods=string.IsNullOrEmpty(jsonFromFile)?new List<Foods>():JsonSerializer.Deserialize<List<Foods>>(jsonFromFile);

            Console.WriteLine("List of Foods:");
            foreach(var food in foods)
            {
                Console.WriteLine($"Name:{ food.Name}");
            }
            return foods;
        }
    }
}
