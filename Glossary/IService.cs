using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Glossary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Word
    {
        public Int64 ID { get; set; }
        public string English { get; set; }
        public string Persian { get; set; }
        public string Description { get; set; }
        public List<Word_Details> Details { get; set; }
    }
    public class Word_Details
    {
        public Int64 DetailId { get; set; }
        public string Body { get; set; }
        public Int64 WId { get; set; }
        public int Kind { get; set; }
    }
}
