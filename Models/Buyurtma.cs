using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Buyurtma
    {
        public int Id { get; set; }
        public List<Foods> foods { get; set; }
        public decimal FullPrice {  get; set; }
        public DateTime Date { get; set; }
    }
}
