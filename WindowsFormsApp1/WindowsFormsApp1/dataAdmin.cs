using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class AdminData
    {
        private string name;
        private int id;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }

        /*public Repairer Check_account(int id)
        {
            throw new System.NotImplementedException();
        }*/

        public void Issue_Warning(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Change_Password(string s)
        {
            throw new System.NotImplementedException();
        }
    }
}
