using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTrainingPlatformLibrary.Model
{
    public enum Permission
    {
        PERM_DELETE_TRAINING = 1,
        PERM_DELETE_BOOKING_ENTRY = 2,
        PERM_CREATE_TRAINING = 3,
        PERM_EDIT_TRAINING= 4,
        PERM_ASSIGN_ROLE = 5,
        PERM_UPDATE_SETTINGS = 6,
        PERM_BOOK_TRAINING = 7,
        PERM_OPEN_USER_DETAILS = 8,
        PERM_START_TRAINING = 9,
        PERM_COMPLETE_TRAINING= 10,
        NO_PERMISSION= 11

    }
}
