using Autofac.Extras.Moq;
using EmployeeTrainingPlatformLibrary.Data;
using EmployeeTrainingPlatformLibrary.Logic.General;
using EmployeeTrainingPlatformLibrary.Model;
using EmployeeTrainingPlattformLibrary.Model;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EmployeeTrainingPlattform.Tests
{
    public class AdminEditUserLogicTest
    {

        //[Fact]
        //public void AssignAdminRoleTest_Successfull()
        //{
        //    using (var mock = AutoMock.GetLoose())
        //    {

            

        //        //mock for GetEmployeeById
        //        mock.Mock<IDataConnection>()
        //            .Setup(x => x.GetEmployeeById(1))
        //            .Returns(GetSampleEmployee());

        //        //mock for GetAllEmployees
        //        mock.Mock<IDataConnection>()
        //            .Setup(x => x.GetAllEmployees())
        //            .Returns(GetSampleEmployees());

        //        //mock for UpdateEmployeeRole
        //        mock.Mock<IDataConnection>()
        //            .Setup(x => x.UpdateEmployeeRole(1,1));



        //        var cls = mock.Create<AdminEditUserLogic>();

        //        cls.AssignAdminRole(1);

        //        mock.Mock<IDataConnection>()
        //            .Verify(x => x.GetEmployeeById(1), Times.Exactly(1));



        //    }
        //}

        private List<Employee> GetSampleEmployees()
        {
            List<Employee> output = new List<Employee>
            {
                new Employee
                {
                      Id = 1,
                    FirstName ="John",
                    LastName = "Doe",
                    Department = Department.IT,
                        EmailAddress ="test@yahoo.de",
                    Role = Role.ROLE_ADMIN

                },
                new Employee
                {
                    Id = 2,
                    FirstName ="Jane",
                    LastName = "Doe",
                    Department = Department.Marketing,
                    EmailAddress ="jane@yahoo.de",
                    Role = Role.ROLE_EMPLOYEE
                },
                new Employee
                {
                    Id = 3,
                    FirstName ="Miriam",
                    LastName = "Aydt",
                    Department = Department.HR,
                    EmailAddress ="miriam@yahoo.de",
                    Role = Role.ROLE_EMPLOYEE
                }
            };

            return output;
        }

        private Employee GetSampleEmployee()
        {
            Employee output = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Department = Department.IT,
                EmailAddress = "test@yahoo.de",
                Role = Role.ROLE_EMPLOYEE
            };
            return output;
        }


    }
}
