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

        public Rent Clone()
        {
            Rent newRent = new Rent()
            {

                Id = this.Id,
                No = this.No,
                Client = this.Client,
                Note = this.Note,
                Price_Per_Day = this.Price_Per_Day

            };
            return newRent;
        }
    }
}
