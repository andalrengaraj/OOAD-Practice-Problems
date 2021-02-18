using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management
{
    class Program
    {
        static void Main(string[] args)
        {
            flow f = new flow();
            usertype t = usertype.admin;
            f.register(t);
            f.login("Andal07");
            
            
        }
    }
     public class studentdetails
    {
      public  string name;

       public long phonenumber;

      public  string course;

       public string higherqualification;

       public string username;

      public  string password;

      public  usertype t;



        



       


    }
}
