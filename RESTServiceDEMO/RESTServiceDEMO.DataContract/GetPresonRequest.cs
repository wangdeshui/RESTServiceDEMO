using System.Runtime.Serialization;

namespace RESTServiceDEMO.DataContract
{
    [DataContract]
    public class GetPresonRequest
    {
        [DataMember]
        public int StartIndex { get; set; }

        [DataMember]
        public int PageSize { get; set; }
    }
}