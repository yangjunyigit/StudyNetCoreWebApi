using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyNetCoreWebApi.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public Guid ConpanyId { get; set; }
        public Guid EmployeeNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Company Company { get; set; }
    }
}