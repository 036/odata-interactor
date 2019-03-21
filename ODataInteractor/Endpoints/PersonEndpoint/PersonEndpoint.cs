﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODataInteractor.Endpoints;

namespace ODataInteractor.Endpoints.PersonEndpoint
{

    class PersonEndpoint : ODataEndpointHandler
    {
        private const string EndpointUrl = "Person";
        override public List<string> AvailableExpansions { get; set; }

        override public List<string> SelectedExpansions { get; set; }

        public PersonEndpoint()
        {
            AvailableExpansions = new List<string>()
            {
                "Trips",
                "Friends",
                "Photo"
            };

            SelectedExpansions = new List<string>();
        }

        public void GetSelectedExpansions()
        {
            foreach (string expansion in SelectedExpansions)
            {
                Console.WriteLine(expansion);
            }
        }

    }
}
