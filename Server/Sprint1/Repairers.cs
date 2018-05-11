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
        private string Person_id;
        private string Phone_number;
        private string address;
        private string appointment_name;
        private int id;
        private int account = 0;


        private List<client> orders = new List<client>();
        [DataMember]
        public string Name { get => name; set => name = value; }
        [DataMember]
        public string Person_id1 { get => Person_id; set => Person_id = value; }
        [DataMember]
        public string Phone_number1 { get => Phone_number; set => Phone_number = value; }
        [DataMember]
        public string Address { get => address; set => address = value; }
        [DataMember]
        public string Appointment_name { get => appointment_name; set => appointment_name = value; }
        [DataMember]
        public int Id { get => id; set => id = value; }
        [DataMember]
        public int Account { get => account; set => account = value; }
        [DataMember]
        public List<client> Orders { get => orders; set => orders = value; }
    }
}