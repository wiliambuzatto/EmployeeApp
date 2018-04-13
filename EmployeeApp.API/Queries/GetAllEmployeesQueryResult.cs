namespace EmployeeApp.API.Queries
{
    public class GetAllEmployeesQueryResult
    {
        public int Id { get;  set; }
        public string FullName { get;  set; }
        public string Email { get;  set; }
        public decimal Salary { get;  set; }
         public decimal TaxRangeApplied { get;  set; }
        public decimal TaxDeductionSalary { get;  set; }
    }
}