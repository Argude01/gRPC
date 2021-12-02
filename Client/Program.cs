using Grpc.Core;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);
                var client = new AccountService.AccountServiceClient(channel);
                EmployeeName employeeName = client.GetEmployeeName(new EmployeeNameRequest { EmpId = "1" });

                if (employeeName == null || string.IsNullOrWhiteSpace(employeeName.FirstName) || string.IsNullOrWhiteSpace(employeeName.LastName))
                {
                    Console.WriteLine("Employee not found.");
                }
                else
                {
                    Console.WriteLine($"The employee name is {employeeName.FirstName} {employeeName.LastName}.");
                }
                channel.ShutdownAsync().Wait(); 
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            catch (Exception ex)
            { 
                Console.WriteLine($"Exception encountered: {ex}"); 
            }
        }
    }
}