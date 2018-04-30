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
        private string id = "12345";
        private string name = "Syed Junaid Ali";
        [DataMember]
        public string Id
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
    }
}