using System.ComponentModel.DataAnnotations;

namespace SpacDYNa.ViewModels
{
    public class LoginVM
    {
        [Required,MaxLength(5)]
        public string UserName { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
