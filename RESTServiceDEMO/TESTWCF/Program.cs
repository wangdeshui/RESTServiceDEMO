using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWCF.TESTService;

namespace TESTWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            TESTService.RestServiceClient client=new RestServiceClient();
            GetPersonReponse result = client.GetPersons(new GetPresonRequest {PageSize = 10, StartIndex = 0});
            foreach (var s in result.Persons)
            {
                Console.WriteLine(s.Name);
            }
            Console.ReadLine();

        }
    }
}
