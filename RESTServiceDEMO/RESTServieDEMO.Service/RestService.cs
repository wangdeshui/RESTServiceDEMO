﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using RESTServiceDEMO.DataContract;

namespace RESTServieDEMO.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class RestService : IRestService
    {
        public GetPersonReponse GetPersons(GetPresonRequest request)
        {
            return new GetPersonReponse
            {
                Persons = GeneratePersons().Skip(request.StartIndex).Take(request.PageSize).ToArray()
            };
        }

        private List<Person> GeneratePersons()
        {
            List<Person> persons=new List<Person>();

            for (int i = 0; i < 100; i++)
            {
                persons.Add(new Person
                    {
                        Name = "Test"+i.ToString(),
                        Age = i,
                        Birthday = DateTime.Now.AddDays(i)
                    });
            }

            return persons;
        }
    }
}