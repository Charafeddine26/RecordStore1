using System.ComponentModel.DataAnnotations;

namespace RecordStore.Models
{
    public class Artiste
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Veuillez saisir le nom complet")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Veuillez saisir un nom entre 3 et 50 caractères")]
        public string FullName { get; set; }
        

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "La biography is requise")]
        public string Bio { get; set; }

        public List<JointDisqueArtiste> JointDisqueArtistes { get; set; }
        

    }
}
