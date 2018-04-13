using System.ComponentModel.DataAnnotations;

namespace EmployeeApp.API.Commands
{
    public class CreateEmployeeCommand
    {
        [Required(ErrorMessage="Nome deve ser informado")]
        public string FullName { get; set; }
        
        [Required(ErrorMessage="E-mail deve ser informado")]
        [EmailAddress(ErrorMessage="E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage="Salário deve ser informado")]
        public decimal Salary { get; set; }
    }
}