using EmployeeTrainingPlattformLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTrainingPlatformLibrary.Model
{
    public class TrainingBookingEntry
    {
        public int EmployeeId { get; set; }
        public int Training { get; set; }
        public TrainingStatus TrainingStatus { get; set; }

    }
}
