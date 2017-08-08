using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataEntity;

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
            string firstName = "";
            using (BetaDBEntities context = new BetaDBEntities())
            {
                var empQuery = from emp in context.Departments select emp;

                List<Department> employeelist = empQuery.ToList();
                int index = -1;
                int.TryParse(id, out index);
                firstName = employeelist[index].Location;
            }

            return "FirstName: " + firstName ; 


        }
    }
}
