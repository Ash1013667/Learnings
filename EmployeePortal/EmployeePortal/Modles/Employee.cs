﻿namespace EmployeePortal.Modles
{
    public class Employee
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public string? Mobile { get; set; }

        public int  Age { get; set; }

        public int Salary { get; set; }

        public bool Status { get; set; }
    }
}
