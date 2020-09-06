using Autofac.Extras.Moq;
using EmployeeTrainingPlatformLibrary.Data;
using EmployeeTrainingPlatformLibrary.Logic;
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
    public  class GeneralTrainingBookingLogicTest
    {
        public GeneralTrainingBookingLogicTest()
        {
            Global.employee = new Employee();
            Global.employee.Id = 1;
        }

        [Theory]
        [InlineData("Test Training 1", TrainingStatus.Booked)]
        [InlineData("Test Training 2", TrainingStatus.Completed)]
        [InlineData("Test Training 3", TrainingStatus.InProcess)]
        public void HasTrainingStatus_True(string title, TrainingStatus status)
        {

            using (var mock = AutoMock.GetLoose())
            { 

                //mock for GetTrainingBooking
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetTrainingBooking(1))
                    .Returns(GetSampleTrainingBookings());


                var cls = mock.Create<GeneralTrainingBookingLogic>();

                var expected = true;

                var actual = cls.HasTrainingStatus(title, status);

                Assert.Equal(expected, actual);



            }
        }

        [Theory]
        [InlineData("Test Training 1", TrainingStatus.Completed)]
        [InlineData("Test Training 2", TrainingStatus.InProcess)]
        [InlineData("Test Training 3", TrainingStatus.Booked)]
        [InlineData("Test", TrainingStatus.Booked)]
        public void HasTrainingStatus_False(string title, TrainingStatus status)
        {

            using (var mock = AutoMock.GetLoose())
            {

                //mock for GetTrainingBooking
                mock.Mock<IDataConnection>()
                    .Setup(x => x.GetTrainingBooking(1))
                    .Returns(GetSampleTrainingBookings());


                var cls = mock.Create<GeneralTrainingBookingLogic>();

                var expected = false;

                var actual = cls.HasTrainingStatus(title, status);

                Assert.Equal(expected, actual);



            }
        }

        //[Theory]
        //[InlineData("Test Training 1")]
        //public void DeleteBookingEntry_DeletionSuccessful(string title)
        //{
        //    using (var mock = AutoMock.GetLoose())
        //    {

        //        //mock for GetTrainings
        //        mock.Mock<IDataConnection>()
        //            .Setup(x => x.GetTrainings())
        //            .Returns(GetSampleTrainings());


        //        //mock for GetTrainingBooking
        //        mock.Mock<IDataConnection>()
        //            .Setup(x => x.GetTrainingBooking(1))
        //            .Returns(GetSampleTrainingBookings());

        //        //mock DeleteTrainingBookingEntryOfEmployee
        //        mock.Mock<IDataConnection>()
        //            .Setup(x => x.DeleteTrainingBookingEntryOfEmployee(1,1));


        //        var cls = mock.Create<GeneralTrainingBookingLogic>();
        //        var cls_training = mock.Create<GeneralTrainingLogic>();


        //        cls.DeleteBookingEntry(title);

        //        mock.Mock<IDataConnection>()
        //        .Verify(x => x.DeleteTrainingBookingEntryOfEmployee(1,1), Times.Exactly(1));




        //    }

        //}

        [Fact]
        public void Dispose()
        {
            Global.employee = null;
        }

        private Dictionary<string, TrainingStatus> GetSampleTrainingBookings()
        {
            Dictionary<string, TrainingStatus> output = new Dictionary<string, TrainingStatus>();
            output.Add("Test Training 1", TrainingStatus.Booked);
            output.Add("Test Training 2", TrainingStatus.Completed);
            output.Add("Test Training 3", TrainingStatus.InProcess);

            return output;


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
