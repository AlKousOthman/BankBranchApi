using System.ComponentModel.DataAnnotations;

namespace BankBranchApi.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CivilId { get; set; }
        public string Position { get; set; }
        public BankBranchModel BankBranch { get; set; }
    }
}
