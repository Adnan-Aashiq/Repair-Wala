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
        private string id;
        private string name;
        [DataMember]
        public string Id { get => id; set => id = value; }
        [DataMember]
        public string Name { get => name; set => name = value; }
    }
}