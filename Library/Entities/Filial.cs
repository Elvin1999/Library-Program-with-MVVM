using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
   public class Filial
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }

        public Filial Clone()
        {
            Filial newFilial = new Filial();
            newFilial.Id = this.Id;
            newFilial.No = this.No;
            newFilial.Name = this.Name;
            newFilial.Address = this.Address;
            return newFilial;
        }
    }
}
