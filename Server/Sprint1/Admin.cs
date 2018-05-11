using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace Sprint1
{
    [DataContract]
    public class Admin
    {
        private static bool start = false;
        private static string id = "12345";
        private static string name = "Sir Awais";
        [DataMember]
        public static string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        [DataMember]
        public static string Name
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
        public static bool Start { get => start; set => start = value; }
    }
}