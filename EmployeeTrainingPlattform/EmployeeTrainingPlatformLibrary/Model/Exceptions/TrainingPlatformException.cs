using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTrainingPlatformLibrary.Model
{
    public class TrainingPlatformException :Exception
    {
        public TrainingPlatformException()
        {
        }

        public TrainingPlatformException(string message)
            : base(message)
        {
        }

        public TrainingPlatformException(string message, Exception inner)
            : base(message, inner)
        {
        }


    }
}
