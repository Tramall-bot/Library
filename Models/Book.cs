using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
     public class Book
     {
      public int Bk_ID {get; set;}
      public stringBk_Name {get; set;}
      public string Bk_Author {get; set;}
      public DateTime Bk_Realise_Date {get; set;}
      public int Pub_ID {get; set;}
      public int Gen_ID {get; set;}

      public Publisher Publisher {get; set;}
      public Genre Genre {get; set;}
      public Book_On_Hand Book_On_Hand {get; set;}
     }
}