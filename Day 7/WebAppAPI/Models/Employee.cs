﻿namespace WebAppAPI.Models
{
    public class Employee
    {
        public int EmployeeId {  get; set; }
        public string Name { get; set; }
        public DateTime DOJ {  get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }
    }
}
