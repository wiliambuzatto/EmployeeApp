

using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeApp.API.Models
{
    public class Employee
    {
        public Employee() {  }
        public Employee(string fullName, string email, decimal salary) 
        {  
            FullName = fullName;
            Email = email;
            Salary = salary;
            TaxRangeAppliedCalc();
            TaxDeductionSalaryCalc();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }

        public decimal TaxRangeApplied { get; private set; }
        public decimal TaxDeductionSalary { get; private set; }

        private void TaxRangeAppliedCalc(){
            TaxRangeApplied = 0;
            if (Salary >= 3000 && Salary < 5000) TaxRangeApplied = 10; else
            if (Salary >= 5000 && Salary < 7000) TaxRangeApplied = 15; else
            if (Salary >= 7000) TaxRangeApplied = 25;
        }

        private void TaxDeductionSalaryCalc(){
            TaxDeductionSalary = Salary * (1 - (TaxRangeApplied / 100));
        }
        

    }
}