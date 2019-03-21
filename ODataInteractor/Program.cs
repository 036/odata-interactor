using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODataInteractor.Endpoints.PersonEndpoint;

namespace ODataInteractor
{
    class Program
    {
        static void Main(string[] args)
        {
            var personEndpoint = new PersonEndpoint();
            personEndpoint.AddExpansions("Trips,Friends");

            Console.ReadLine();
        }
    }
}
