﻿using System;
using System.Collections.Generic;

namespace HumanResourceApi.Models
{
    public partial class EmployeeLoanLog
    {
        public string LoanId { get; set; }
        public string EmployeeId { get; set; }
        public string LoanType { get; set; }
        public decimal? Amount { get; set; }
        public decimal? InstallmentAmount { get; set; }
        public string InstallmentFrequency { get; set; }
        public DateTime? LoanStartDate { get; set; }
        public DateTime? LoanEndDate { get; set; }
        public string LoanProvider { get; set; }
        public string ApprovalStatus { get; set; }
        public string Status { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
