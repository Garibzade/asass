using System.ComponentModel.DataAnnotations;

namespace SpacDYNa.ViewModels
{
    public class UpdateCardsVM
    {
        public int Id { get; set; }

        [MaxLength(24, ErrorMessage = "adin uzunlugunu cox daxil etmisiz")]
        public string Name { get; set; }

        [MaxLength(64, ErrorMessage = " uzunlugunu cox daxil etmisiz")]

        public string? SubTitle { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
