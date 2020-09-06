using Autofac.Extras.Moq;
using Autofac.Features.ResolveAnything;
using Castle.Core.Smtp;
using EmployeeTrainingPlatformLibrary.Data;
using EmployeeTrainingPlatformLibrary.Logic;
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
    public class LoginLogicTest
    {
        LoginLogic loginClass = new LoginLogic();



        [Fact]
        public void Login_LoginSuccessfull_RoleAdmin()
        {
            using (var mock = AutoMock.GetLoose())
            {

                //mock for GetUserAccountCredentials
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetUserAccountCredentials("test@yahoo.de"))
                    .Returns(GetSampleUserAccount("test@yahoo.de"));

                //mock for GetEmployeeById
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetEmployeeById(1))
                    .Returns(GetSampleEmployee_RoleAdmin());
                //mock for GetTraining
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetTrainings())
                    .Returns(GetSampleTrainings());

                //mock for GetTrainingBookings
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetTrainingBooking(1))
                    .Returns(GetSampleTrainingBookings());

                //mock for GetAllEmployees
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetAllEmployees())
                    .Returns(GetSampleEmployees());


          

                var cls = mock.Create<LoginLogic>();

                var expected = true;

                var actual = cls.Login("test@yahoo.de", "password");

                Assert.Equal(expected, actual);



            }

     
        }
        [Theory]
        [InlineData("test@yahoo.de", "paswort")]
        [InlineData("testos@yahoo.de", "paswort")]
        [InlineData("jane@yahoo.de", "janePassword")]
        [InlineData("test@yahoo.de", "passwort")]
        [InlineData("", "password")]
        [InlineData("test@yahoo.de", "")]
        [InlineData("", "")]
        public void Login_LoginNotSuccessfull_RoleAdmin(string emailAddress, string password)
        {
            using (var mock = AutoMock.GetLoose())
            {

                //mock for GetUserAccountCredentials
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetUserAccountCredentials(emailAddress))
                    .Returns(GetSampleUserAccount(emailAddress));

                //mock for GetEmployeeById
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetEmployeeById(1))
                    .Returns(GetSampleEmployee_RoleAdmin());
                //mock for GetTraining
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetTrainings())
                    .Returns(GetSampleTrainings());

                //mock for GetTrainingBookings
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetTrainingBooking(1))
                    .Returns(GetSampleTrainingBookings());

                //mock for GetAllEmployees
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetAllEmployees())
                    .Returns(GetSampleEmployees());




                var cls = mock.Create<LoginLogic>();

                var expected = false;

                var actual = cls.Login(emailAddress, password);

                Assert.Equal(expected, actual);



            }

        }

        [Theory]
        [InlineData("test@yahoo.de", "paswort")]
        [InlineData("testos@yahoo.de", "paswort")]
        [InlineData("jane@yahoo.de", "janePassword")]
        [InlineData("test@yahoo.de", "passwort")]
        [InlineData("", "password")]
        [InlineData("test@yahoo.de", "")]
        [InlineData("", "")]
        public void Login_LoginNotSuccessfull_RoleEmployee(string emailAddress, string password)
        {
            using (var mock = AutoMock.GetLoose())
            {

                //mock for GetUserAccountCredentials
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetUserAccountCredentials(emailAddress))
                    .Returns(GetSampleUserAccount(emailAddress));

                //mock for GetEmployeeById
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetEmployeeById(1))
                    .Returns(GetSampleEmployee_RoleAdmin());
                //mock for GetTraining
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetTrainings())
                    .Returns(GetSampleTrainings());

                //mock for GetTrainingBookings
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetTrainingBooking(1))
                    .Returns(GetSampleTrainingBookings());



                var cls = mock.Create<LoginLogic>();

                var expected = false;

                var actual = cls.Login(emailAddress, password);

                Assert.Equal(expected, actual);



            }

        }

        [Fact]
        public void Login_LoginSuccessfull_RoleEmployee()
        {
            using (var mock = AutoMock.GetLoose())
            {

                //mock for GetUserAccountCredentials
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetUserAccountCredentials("test@yahoo.de"))
                    .Returns(GetSampleUserAccount("test@yahoo.de"));

                //mock for GetEmployeeById
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetEmployeeById(1))
                    .Returns(GetSampleEmployee_RoleEmployee());
                //mock for GetTraining
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetTrainings())
                    .Returns(GetSampleTrainings());

                //mock for GetTrainingBookings
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetTrainingBooking(1))
                    .Returns(GetSampleTrainingBookings());




                var cls = mock.Create<LoginLogic>();

                var expected = true;

                var actual = cls.Login("test@yahoo.de", "password");

                Assert.Equal(expected, actual);



            }

        }

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

        private Employee GetSampleEmployee_RoleAdmin()
        {
            Employee output = new Employee
            {
                Id = 1,
                FirstName ="John",
                LastName = "Doe",
                Department = Department.IT,
                EmailAddress ="test@yahoo.de",
                Role = Role.ROLE_ADMIN
            };
            return output;
        }

        private Employee GetSampleEmployee_RoleEmployee()
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
        private Dictionary<string, TrainingStatus> GetSampleTrainingBookings()
        {
            Dictionary<string, TrainingStatus> output = new Dictionary<string, TrainingStatus>();
            output.Add("Test Training 1", TrainingStatus.Booked);
            output.Add("Test Training 2", TrainingStatus.Completed);
            output.Add("Test Training 3", TrainingStatus.InProcess);

            return output;


        }

        private UserAccountEntry GetSampleUserAccount(string emailAddress)
        {
            if (!emailAddress.Equals(""))
            {
                UserAccountEntry userAccount = new UserAccountEntry("test@yahoo.de", "password");
                userAccount.Id = 1;
                userAccount.EmployeeId = 1;

                return userAccount;
            }
            else
            {
                return null;
            }

        }

        private List<Training> GetSampleTrainings()
        {
            List<Training> output = new List<Training>
            {
                new Training
                {
                    Id = 1,
                    Title = "Test Training 1",
                    Department = Department.HR,
                    Description= "This is a test description"
                },
                  new Training
                {
                    Id = 2,
                    Title = "Test Training 2",
                    Department = Department.IT,
                    Description= "This is a test description"
                },
                 new Training
                {
                    Id = 3,
                    Title = "Test Training 3",
                    Department = Department.Marketing,
                    Description= "This is a test description"
                },
                new Training
                {
                    Id = 4,
                    Title = "Test Training 4",
                    Department = Department.IT,
                    Description= "This is a test description"
                }
            };

            return output;


        }
    }
}
