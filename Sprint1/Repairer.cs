using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace Sprint1
{
    [DataContract]
    public class Repairer
    {
        private string name;
        private string address;
        private int account=0;
        private client appointment;
        private int id;
        
        private string Person_id;
        private string Phone_number;
        private List<client> orders = new List<client>();
        /*public static bool Add_order(client c)
        {
            
        }
        public static bool Appoint_Client(client c)
        {

        }
        public static int Get_monthly_income(client c)
        {

        }
        public static void Remove_oredr(client c)
        {

        }*/

        [DataMember]
        public int Account
        {
            get
            {
                return account;
            }

            set
            {
                account = value;
            }
        }
        [DataMember]
        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
        [DataMember]
        public client Appointment
        {
            get
            {
                return appointment;
            }

            set
            {
                appointment = value;
            }
        }


        [DataMember]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        [DataMember]
        public string Person_id1
        {
            get
            {
                return Person_id;
            }

            set
            {
                Person_id = value;
            }
        }
        [DataMember]
        public string Phone_number1
        {
            get
            {
                return Phone_number;
            }

            set
            {
                Phone_number = value;
            }
        }
        [DataMember]
        public int Id { get => id; set => id = value; }
        [DataMember]
        public List<client> Orders1 { get => orders; set => orders = value; }
    }
}