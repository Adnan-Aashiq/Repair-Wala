using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sprint1
{
    public class RepairersRecords
    {
        public static List<Repairer> repairers = new List<Repairer>();

        public static void Add_Repairer(string name,string addres,string cellno,string cnic,int id)
        {
            Repairer r = new Repairer();
            r.Name = name;
            r.Address = addres;
            r.Phone_number1 = cellno;
            r.Person_id1 = cnic;
            r.Id = id;
            repairers.Add(r);
        }
        /*public static Repairer Get_id_repairer(int id)
        {

        }
        public static int Give_bonus(Repairer r)
        {

        }
        public static bool Remove_account(Repairer r)
        {

        }*/
        public static bool Repairer_NotBusy(Repairer r)
        {
            return true;
        }
        public static bool Assign_client(client c)      //***
        {
            bool msg = false;
            
            return msg;
        }
        public static bool Appoint_client(int id)
        {
            bool msg=false;
            
            return msg;
        }

    }
}