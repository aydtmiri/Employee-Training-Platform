using Autofac.Extras.Moq;
using EmployeeTrainingPlatformLibrary.Data;
using EmployeeTrainingPlatformLibrary.Logic;
using EmployeeTrainingPlatformLibrary.Logic.General;
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
    public class GeneralPermissionLogicTest
    {

        public GeneralPermissionLogicTest()
        {
            Global.employee = new Employee();
            Global.employee.Role = Role.ROLE_ADMIN;
        }

        [Fact]

        public void HasUserPermission_HasPermission()
        {
            using (var mock = AutoMock.GetLoose())
            {

                //mock for GetUserAccountCredentials
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetRolePermissionById(1, (int)Permission.PERM_ASSIGN_ROLE))
                    .Returns(GetPermissionById());


                var cls = mock.Create<GeneralPermissionLogic>();

                var expected = true;

                var actual = cls.HasUserPermission(Permission.PERM_ASSIGN_ROLE);

                Assert.Equal(expected, actual);



            }
        }
        [Theory]
        [InlineData(Permission.PERM_COMPLETE_TRAINING)]
        [InlineData(Permission.NO_PERMISSION)]

        public void HasUserPermission_DoesNotHavePermission(Permission perm)
        {
            using (var mock = AutoMock.GetLoose())
            {

                //mock for GetUserAccountCredentials
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetRolePermissionById(1, (int)Permission.PERM_ASSIGN_ROLE))
                    .Returns(GetPermissionById());


                var cls = mock.Create<GeneralPermissionLogic>();

                var expected = false;

                var actual = cls.HasUserPermission(perm);

                Assert.Equal(expected, actual);



            }
        }

        private Permission GetPermissionById()
        {
            return Permission.PERM_ASSIGN_ROLE;
        }

        [Fact]
        public void Dispose()
        {
            Global.employee = null;
        }
    }
}
