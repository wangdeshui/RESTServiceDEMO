using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace RESTServiceDEMO.DataContract
{
    [ServiceContract]
    public interface IRestService
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "GetXX", Method = "POST")]
        GetPersonReponse GetPersons(GetPresonRequest request);
    }
}
