using System.ComponentModel.DataAnnotations;

namespace SpacDYNa.ViewModels
{
    public class RegisterVM
    {
        [Required,MinLength(3)]
        public string Name { get; set; }
        [Required, MinLength(5)]

        public string Surname { get; set; }
        [Required,DataType(DataType.EmailAddress) ]

        public string @gmail { get; set; }
        [Required, MinLength(5)]
       public string UserName { get; set; }

        [Required, DataType(DataType.Password)]

        public string Password { get; set; }

    }
}
