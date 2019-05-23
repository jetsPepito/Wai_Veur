using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wai_Veur
{
    class Request
    {
        private string id;
        private string city;
        private string temp_k;
        
        public Request( string uneCity)
        {
            this.city = uneCity;
        }  
        public string getcity()
        {
            return this.city;
        }

    }
}
