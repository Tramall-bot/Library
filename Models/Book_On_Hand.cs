using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
     public class Book_On_Hand
     {
       public DateTime Rb_Return_Date {get; set;}
       public DateTime Rb_GiveOut_Date {get; set;}
       public boolRb_Return_Flag {get; set;}
       public int Emp_ID {get; set;}
       public int Rd_ID {get; set;}
       public int Bk_ID {get; set;}
       public Employee Employee {get; set}
       public Reader Reader {get; set}
       public ICollection<Book> Books {get; set;}
     }
}