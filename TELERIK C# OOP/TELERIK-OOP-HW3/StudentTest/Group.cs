using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest
{
    class Group
    {
        private int groupNumber;
        private string departmentName;

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;            
            }
            set
            {
                this.groupNumber = value;
            }
        }

        public string DepartmentName
        {
            get { return this.departmentName; }
            set { this.departmentName = value; }
        }

        public Group(int groupNumber, string departmentname)
        {
            this.DepartmentName = departmentname;
            this.GroupNumber = groupNumber;
        }


    }
}
