using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management
{
    class flow
    {
        state s;
        usertype ut;
        string username;
        string password;
      
        List<studentdetails> mylist = new List<studentdetails>();

        public flow()
        {
            s = state.fail;
        }

        public void register(usertype ut)
        {
            if (ut == usertype.admin)
            {
                mylist.Add(new studentdetails
                {
                    name = "andal",
                    phonenumber = 8608024778,
                    course = "C#",
                    higherqualification = "B.E,EIE",
                    username = "Andal07",
                    password = "Andalvidhun",





                });
            }
            else
            {
                Console.WriteLine("an user can't register");
            }
           
            
            
        }

        private bool is_exist(string username)
        {
            bool ans = false;
            if (mylist[0].username.Contains(username))
            {
                ans = true;
            }
            return ans;
        }

        public bool login(string username)
        {
            bool ans = false;
            if (is_exist(username))
            {
                ans = true;
                Console.WriteLine("yes");
            }
            return ans;

        }

        private usertype determineusertype()
        {
            if (ut == usertype.user)
            {
                ut = usertype.user;
            }
            else
            {
                ut = usertype.admin;
            }
            return ut;
        }



      






    }
}
