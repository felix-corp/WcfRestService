using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RestWCFServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class RestWCFService : IRestWCFService
    {
        public string GetData(string id)
        {
            return Data(id);
        }

        private string Data(string id)
        {
            return "Data: " + id; 
        }
    }
}
