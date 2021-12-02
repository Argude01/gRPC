using System;
using System.Threading.Tasks;
using Grpc.Core;

namespace Accounts
{
    class AccountsImpl : AccountService.AccountServiceBase
    { 
        // Server side handler of the GetEmployeeName RPC
        public override Task<EmployeeName> GetEmployeeName(EmployeeNameRequest request, ServerCallContext context)
        {
            EmployeeData employeeData = new EmployeeData();
            return Task.FromResult(employeeData.GetEmployeeName(request));
        }

    }
}