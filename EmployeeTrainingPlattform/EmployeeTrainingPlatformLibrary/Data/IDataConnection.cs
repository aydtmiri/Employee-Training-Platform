using EmployeeTrainingPlatformLibrary.Logic;
using EmployeeTrainingPlatformLibrary.Model;
using EmployeeTrainingPlattformLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace EmployeeTrainingPlatformLibrary.Data

{
    public interface IDataConnection
    {
        //------------- USER ACCOUNT -------------
        //GET
        UserAccountEntry GetUserAccountCredentials(string emailAddress);
        //CREATE
        void CreateEmployeeUserAccount(Employee employee, UserAccountEntry userCredentials);

        //UPDATE
        void UpdateUserAccount(UserAccountEntry userAccount);
        void UpdateUserAccountEmailAddress(string EmailAddress, int employeeId);
        void UpdateUserAccountPassword(UserAccountEntry userAccount);



        //------------- DEPARTMENT -------------
        //CREATE
        Model.Department CreateDepartment(Model.Department department);
        //GET
        List<string> GetDepartmentNames();

        //------------- EMPLOYEE -------------
        //CREATE

        Employee CreateEmployee(Employee employee);

        //UPDATE

        void UpdateEmployee(Employee employee);
        void UpdateEmployeeRole(int employeeId, int roleId);

        //GET
        Employee GetEmployeeById(int id);
        Role GetEmployeeRole(int employeeId);

        List<Employee> GetAllEmployees();


        //------------- TRAINING -------------
        //CREATE
        Training CreateTraining(Training training);
        TrainingStatus CreateTrainingstatus(TrainingStatus training);

 

        //GET
        List<Training> GetTrainings();
        Training GetTrainingById(int id);
        List<Training> GetTrainingToRequirement(string requirement);

        //UPDATE
        void UpdateTraining(Training training);

        //DELETE
        void DeleteTraining(int trainingId);

        //------------- TRAINING BOOKING -------------
        //GET
        Dictionary<string, TrainingStatus> GetTrainingBooking(int employeeId);
        List<TrainingBookingEntry> GetBookingsWithStatus(int trainingId, int trainingStatus);

        //CREATE
        void CreateTrainingBooking(int employeeId, int trainingId, int trainingStatus);

        //UPDATE
         void UpdateTrainingBookingStatus(int employeeID, int trainingId, int trainingStatus);

        //DELETE

        void DeleteTrainingBookingEntryOfEmployee(int employeeId, int trainingId);

        //------------- ROLE -------------
        //GET
        List<Role> GetAllRoleNames();

        //------------- PermissionAssignment -------------
        //GET
        Permission GetRolePermissionById(int roleId, int permissionId);

  


    }
}
