﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BankBranchApi.Models
{
    public class BankBranchModel
    {

        [Required]
        public int Id { get; set; }
        [Required]
        public string LocationName { get; set; }
        [Required]
        public string LocationURL { get; set; }
        [Required]
        public string BranchManager { get; set; }
        [Required]
        public int EmployeeCount { get; set; }
        public List<EmployeeModel> Employees { get; set; } = new();
    }


}

