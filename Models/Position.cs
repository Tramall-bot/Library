using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
    public class Position
     {
      public int Pos_ID {get; set;}
      public string Pos_Name {get; set;}
      public int Pos_Salary {get; set;}
      public string Pos_Duties {get; set;}
      public string Pos_Requirements {get; set;}
      public ICollection<Employee> Employes {get; set;}
     }
}