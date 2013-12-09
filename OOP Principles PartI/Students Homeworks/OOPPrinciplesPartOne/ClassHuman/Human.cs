using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public abstract class Human
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }

       protected Human(string firstname, string secondname)
       {
           this.FirstName = firstname;
           this.LastName = secondname;
       }
       public override string ToString()
       {
           StringBuilder sb = new StringBuilder();
           sb.AppendFormat("{0} {1}",this.FirstName,this.LastName);
           return Convert.ToString(sb);
       }

    }

