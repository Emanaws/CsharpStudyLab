using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    internal class Person
    {
        //private property
        private string pfname { get; set; }
        private string plname { get; set; }
        private string  gender { get; set; }
        private DateTime pldob { get; set; }
        public readonly string ssn = "123456789";
        //To Access private property
            public string PFName {
                    get { return pfname; }
                    set { pfname = value; }
            }

            public string PLName {
                get { return plname; }
                set { plname = value; }
            }

            public string Gender {
                get { return gender; }
                set { gender = value; }
            }
            public DateTime PLDOB {
                get { return pldob; }
                set { pldob = value; }
            }
            public int GetAge()
            {
                var dob = pldob.Year;
                var thisyear = DateTime.Now.Year;
                return thisyear - dob;
            }
    }
}
