using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Department
    {
        public int departmentId { get; set; }
        public string departmentName { get; set; }


        public Department(int DepartmentId, string DepartmentName)
        {
            departmentName = DepartmentName;
            departmentId = DepartmentId;
        }
    }
}
