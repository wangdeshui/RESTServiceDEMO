using System;
using System.Runtime.Serialization;

namespace RESTServiceDEMO.DataContract
{
    [DataContract]
    public class GetPersonReponse
    {
        [DataMember]
       public Person[] Persons { get; set; }
        
    }

    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public DateTime Birthday { get; set; }
         
    }
}