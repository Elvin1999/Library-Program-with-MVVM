using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
   public class Sale
    {
        public int Id { get; set; }
        public int No { get; set; }
        public Client Client { get; set; }
        public double Real_Price { get; set; }
        public double Sale_Price { get; set; }
        public string Note { get; set; }
    }
}

