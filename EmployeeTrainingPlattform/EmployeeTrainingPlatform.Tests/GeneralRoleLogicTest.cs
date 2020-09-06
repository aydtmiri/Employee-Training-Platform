using Autofac.Extras.Moq;
using EmployeeTrainingPlatformLibrary.Data;
using EmployeeTrainingPlatformLibrary.Logic;
using EmployeeTrainingPlatformLibrary.Model;
using EmployeeTrainingPlattformLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EmployeeTrainingPlattform.Tests
{
    public class GeneralRoleLogicTest
    {
        public GeneralRoleLogicTest()
        {
            Global.employee = new Employee();
            Global.employee.Id = 1;
        }

        [Fact]
        public void IsAdmin_True()
        {
            using (var mock = AutoMock.GetLoose())
            {

               
                //mock for GetEmployeeById
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetEmployeeRole(1))
                    .Returns(Role.ROLE_ADMIN);
               




                var cls = mock.Create<GeneralRoleLogic>();

                var expected = true;

                var actual = cls.IsAdmin();

                Assert.Equal(expected, actual);



            }

        }

        [Theory]
        [InlineData(Role.ROLE_EMPLOYEE)]
        [InlineData(Role.NO_ROLE)]
        public void IsAdmin_False(Role role)
        {
            using (var mock = AutoMock.GetLoose())
            {


                //mock for GetEmployeeById
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetEmployeeRole(1))
                    .Returns(role);

                var cls = mock.Create<GeneralRoleLogic>();

                var expected = false;

                var actual = cls.IsAdmin();

                Assert.Equal(expected, actual);



            }

        }


        [Fact]
        public void Dispose()
        {
            Global.employee = null;
        }

    }
}
