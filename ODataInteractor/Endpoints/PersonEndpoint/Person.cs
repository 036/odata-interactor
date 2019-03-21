using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataInteractor.Endpoints.PersonEndpoint
{
    class Person
    {
        public string UserName { get; set; }

        public string FirstName { get; set; }

        public List<String> Emails { get; set; }

        public string AddressInfo { get; set; }

        public GenderEnum Gender { get; set; }

        public int Concurrency { get; set; }
    }
}
