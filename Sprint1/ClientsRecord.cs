using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sprint1
{
    public class ClientsRecord
    {
        public static int count = 1201;
        public static int inc = 1;
        public static bool is_login(int id)
        {
            
            bool login = false;
            foreach(client c in ClientsRecord.clients)
            {
                if(c.Id_client == id)
                {
                    //Utility.curr_client = c;
                    login = true;
                }
            }
            return login;
        }
        public static List<client> clients = new List<client>();
        public static int Add_Clients(string name,string problem,string addres,string cellno,string device,string mail)
        { 
            client c = new client();
            c.Name_client = name;
            c.Address = addres;
            c.Cell_client = cellno;
            c.Device = device;
            c.Problem = problem;
            c.Mail = mail;
            //c.Id_client = count.ToString();//
            count = count + (3 * inc);
            inc = inc + 1;
            c.Id_client = count;
            clients.Add(c);
            //Utility.curr_reg_client = c;
            return count;
        }
        public static bool Search_Clients(int id)
        {
            bool exist = false;
            foreach (client c in ClientsRecord.clients)
            {
                if (c.Id_client == id)
                {
                    exist= true;
                }
            }
            return exist;
        }

    }

}