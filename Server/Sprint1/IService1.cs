using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Sprint1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void Add_Repairer(string name, string addres, string cellno, string cnic, int id);
        [OperationContract]
        bool is_login(int id);

        [OperationContract]
        int Add_Clients(string name, string problem, string addres, string cellno, string device, string mail);   //***
        [OperationContract]
        client Search_Client(int id);
        [OperationContract]
        bool Repairer_NotBuzy(Repairer r);
        [OperationContract]
        bool Assign_client(client c);       //***
        [OperationContract]
        bool Appoint_client(int id);       //***
        [OperationContract]
        List<Repairer> Get_repairers_list();        //Step4
        [OperationContract]
        List<client> Get_client_list();
        [OperationContract]
        void make_admin(Admin a);

        [OperationContract]
        void fix_app(client c, int id);
        [OperationContract]
        Repairer Search_Repairer(int id);
        [OperationContract]
        void remove_order(client c,int id);

        [OperationContract]
        void del_repairer(int id);
        [OperationContract]
        bool edit_repairer(Repairer r);
        /*[OperationContract]
        bool Change_Password(string s);
        Repairer Get_id_repairer(int id);
        [OperationContract]
        int Give_Bonus(Repairer r);
        [OperationContract]
        bool Remove_account(Repairer r);
       
        
        [OperationContract]
        Repairer Check_account(int id);
        [OperationContract]
        void Issue_Warning(int id);
        [OperationContract]
        bool Add_order(client c);
        [OperationContract]
        bool Appoint_Client(client c);
        [OperationContract]
        int Get_monthly_income();
        [OperationContract]
        void Remove_order(client c);*/


        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
