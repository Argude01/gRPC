using System;

namespace Accounts
{
    public class EmployeeData
    {
        public EmployeeName GetEmployeeName(EmployeeNameRequest request)
        {
            EmployeeName employeeName = new EmployeeName();

            switch (request.EmpId)
            {
                case "1":
                    employeeName.FirstName = "Deyanira";
                    employeeName.LastName = "Gutierrez";
                    break ;
                case "2":
                    employeeName.FirstName = "Paty";
                    employeeName.LastName = "Arteaga";
                    break ;
                default:
                break ;
            }
            return employeeName;
        }
    }
}