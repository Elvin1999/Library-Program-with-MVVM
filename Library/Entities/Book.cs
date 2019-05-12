using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
   public class Book
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
        public Filial Filial { get; set; }
        public Genre Genre { get; set; }
        public int PageCount { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public Book()
        {
     
        }
        public Book Clone()
        {
            Book newbook = new Book();
            newbook.Id = this.Id;
            newbook.Author = this.Author;
            newbook.Filial = this.Filial;
            newbook.Genre = this.Genre;
            newbook.Name = this.Name;
            newbook.No = this.No;
            newbook.PageCount = this.PageCount;
            newbook.PurchasePrice = this.PurchasePrice;
            newbook.SalePrice = this.SalePrice;
            return newbook;
        }
    }
}
