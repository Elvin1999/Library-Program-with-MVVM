﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
   public class Client
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime ConnectionDT { get; set; }

        public Client Clone()
        {
            Client newClient = new Client();
            newClient.Id = this.Id;
            newClient.No = this.No;
            newClient.Name = this.Name;
            newClient.PhoneNumber = this.PhoneNumber;
            newClient.Surname = this.Surname;
            newClient.ConnectionDT = this.ConnectionDT;
            return newClient;
        }
    }
}
