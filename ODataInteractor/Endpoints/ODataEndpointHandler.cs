using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataInteractor.Endpoints
{
    abstract class ODataEndpointHandler
    {
        public abstract List<string> AvailableExpansions { get; set; }

        public abstract List<string> SelectedExpansions { get; set; }

        public void AddExpansions(string expansions)
        {
            var expansionsSplit = expansions.Split(',');
            foreach (string expansion in expansionsSplit)
            {
                if (!AvailableExpansions.Contains(expansion))
                {
                    throw new Exception(string.Format("Invalid expansion {0} supplied", expansion));
                }

                SelectedExpansions.Add(expansion);
            }
        }
    }
}
