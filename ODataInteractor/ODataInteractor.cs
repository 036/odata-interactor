using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataInteractor
{
    public class ODataInteractor : IODataInteractor
    {
        #region Private Fields
        private const string RootDomain = "services.odata.org";

        private const string RootUrl = "/V4/(S(a4eqlx4cj3fh5ofkdry4ps0f))/TripPinServiceRW/";

        private static ODataInteractor _instance;
        #endregion

        /// <summary>
        /// Get the instance of ODataInteractor
        /// </summary>
        /// <returns></returns>
        public static ODataInteractor GetInstance()
        {
            if (_instance == null)
                _instance = new ODataInteractor();
            return _instance;
        }
    }
}
