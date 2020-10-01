using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
     public class Publicher
      {
       public int Pub_ID {get; set;}
       public string Pub_Name {get; set;}
       public string Pub_City {get; set;}
       public string Pub_Address {get; set;}
       public ICollection<Book> Books {get; set;}
      }
}