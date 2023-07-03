﻿using System.ComponentModel.DataAnnotations;

namespace HumanResourceApi.DTO.EmployeeLoanLog
{
    public class LoanLogDto
    {
        [Required]
        public string LoanId { get; set; }
        [Required]
        public string EmployeeId { get; set; }
        [Required]
        public string LoanType { get; set; }
        [Required]
        public decimal? Amount { get; set; }
        [Required]
        public decimal? InstallmentAmount { get; set; }
        [Required]
        public string InstallmentFrequency { get; set; }
        [Required]
        public DateTime? LoanStartDate { get; set; }
        [Required]
        public DateTime? LoanEndDate { get; set; }
        [Required]
        public string LoanProvider { get; set; }
        [Required]
        public string ApprovalStatus { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
