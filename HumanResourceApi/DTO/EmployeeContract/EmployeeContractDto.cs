﻿namespace HumanResourceApi.DTO.EmployeeContract
{
    public class EmployeeContractDto
    {
        public string ContractId { get; set; }
        public string EmployeeId { get; set; }
        public string ContractFile { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Job { get; set; }
        public decimal? BaseSalary { get; set; }
        public string Status { get; set; }
        public double? PercentDeduction { get; set; }
        public string SalaryType { get; set; }
        public string ContractType { get; set; }
    }
}
