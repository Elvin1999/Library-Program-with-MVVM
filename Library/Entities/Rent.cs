using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
   public class Rent
    {
        public int Id { get; set; }
        public int No { get; set; }
        public Client Client { get; set; }
        public double Price_Per_Day { get; set; }
        public string Note { get; set; }
       
    }
}
