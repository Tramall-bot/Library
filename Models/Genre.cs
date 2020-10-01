using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
     public class Genre
     {
      public int Gen_ID {get; set;}
      public string Gen_Name {get; set;}
      public string Gen_Description {get; set;}
      public ICollection<Book> Books {get; set;}
     }
}