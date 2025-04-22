using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Courier_Management_System.Entity;
using Courier_Management_System.Exception;

namespace Courier_Management_System.DAO
{
    public class CourierAdminServiceImpl : CourierUserServiceImpl, ICourierAdminService
    {
        public CourierAdminServiceImpl(CourierCompanyCollection companyObj) : base(companyObj) { }

        public int AddCourierStaff(Employee obj)
        {
            for (int i = 0; i < companyObj.EmployeeDetails.Count; i++)
            {
                if (companyObj.EmployeeDetails[i] == null)
                {
                    companyObj.EmployeeDetails[i] = obj;
                    return obj.EmployeeID;
                }
            }
            throw new InvalidEmployeeIdException("Employee storage full. Cannot add more staff.");
        }
    }
}

