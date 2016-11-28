using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(Credentials value);

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

    [DataContract]
    public class Credentials
    {
        [DataMember(IsRequired = false, Name = "UserName")]
        public string UserName { get; set; }

        [DataMember(IsRequired = false, Name = "Password")]
        public string Password { get; set; }

        [DataMember(IsRequired = false, Name = "SessionId")]
        public string SessionId { get; set; }

        public override string ToString()
        {
            StringBuilder response = new StringBuilder();

            response.Append(UserName);
            response.Append(" - ");
            response.Append(Password);
            response.Append(" - ");
            response.Append(SessionId);

            return response.ToString();
        }
    }
}
