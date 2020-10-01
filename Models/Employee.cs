using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
    public class Employee
     {
       public int Emp_ID {get; set;}
       public string First_Name {get; set;}
       public string Last_Name {get; set;}
       public string Middle_Name {get; set;}
       public int Emp_Age {get; set;}
       public char Emp_Sex {get; set;}
       public string Emp_Address {get; set;}
       public string Emp_Phone_Number {get; set;}
       public string Emp_Passport_Data {get; set;}
       public int Pos_ID {get; set;}
       public ICollection<Position> Positions {get; set;}
       public ICollection<Book_On_Hand> Book_On_Hands {get;set;}
     }
}