using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Worker
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public int Salary { get; set; }
        public Filial Filial { get; set; }

        internal Worker Clone()
        {
            Worker newWorker = new Worker()
            {
                Id = this.Id,
                No = this.No,
                Name = this.Name,
                Surname = this.Surname,
                PhoneNumber = this.PhoneNumber,
                Salary = this.Salary
            };
            return newWorker;
        }
    }
}


