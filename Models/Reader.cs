using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
     public class Reader
     {
      public int Rd_ID {get; set;}
      public string First Name {get; set;}
      public string Last Name {get; set;}
      public string Middle Name {get; set;}
      public DateTime Rd_BD_Date {get; set;}
      public char Rd_Sex {get; set;}
      public string Rd_Address {get; set;}
      public string Rd_Phone_Number {get; set;}
      public string Rd_Passport_Data {get; set;}
      public ICollection<Book_On_Hand> Book_On_Hands {get; set;}
     }
}