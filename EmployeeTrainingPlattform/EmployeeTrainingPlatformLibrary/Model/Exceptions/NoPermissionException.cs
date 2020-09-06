using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTrainingPlatformLibrary.Model
{
    public class NoPermissionException : Exception
    {
        public NoPermissionException()
        {
        }

        public NoPermissionException(string message)
            : base(message)
        {
        }

        public NoPermissionException(string message, Exception inner)
            : base(message, inner)
        {
        }


    }
}
