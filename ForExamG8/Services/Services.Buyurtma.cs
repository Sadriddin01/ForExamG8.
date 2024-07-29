using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForExamG8.Services
{
    public partial class Services
    {
        public static string GetBuyurtmaPath()
        {
            string currentPath=Directory.GetCurrentDirectory();
            currentPath += @"\buyurtmalar.json";
            return currentPath;
        }

        public void AddFoods()
        {
            
        }
    }
}
