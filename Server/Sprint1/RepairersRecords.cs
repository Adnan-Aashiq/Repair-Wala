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
            bool status=false;
            if(r.Appointment_name == null)
            {
                status = true;
            }
            return status;
        }
        public static bool Assign_client(client c)      //***
        {
            bool msg = false;
            foreach(Repairer r in repairers)
            {
                if(r.Orders.Count() < 3)
                {
                    if(Repairer_NotBusy(r)== true)
                    {
                        r.Orders.Add(c);
                        msg = true;
                        break;
                    }
                }
            }
            return msg;
        }
        
        public static bool edit(Repairer r)
        {
            bool status = false;
            foreach (Repairer rep in repairers)
            {
                if (rep.Person_id1 == r.Person_id1)
                {
                    repairers.Remove(rep);
                    repairers.Add(r);
                    status = true;
                    break;
                }
            }
            return status;
        }
        public static Repairer Search_Repairer(int id)
        {
            Repairer rp = new Repairer();
            foreach(Repairer r in repairers)
            {
                if (r.Id == id)
                {
                    rp = r;
                }
            }
            return rp;
        }
        public static void appoint_client(client c,int id)
        {
            Repairer r = Search_Repairer(id);
            r.Appointment_name = c.Name_client;
            edit(r);

        }
        public static bool pay_amount(client c,int am)
        {
            bool stat = false;
            foreach(Repairer r in repairers)
            {
                if(r.Appointment_name == c.Name_client)
                {
                    r.Account = r.Account + am;
                    stat = true;
                }
            }
            return stat;
        }
    }
}