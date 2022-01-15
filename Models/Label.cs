using System.ComponentModel.DataAnnotations;

namespace RecordStore.Models
{
    public class Label
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Veuillez saisir le nom complet")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Veuillez saisir un nom entre 3 et 50 caractères")]
        public string Nom { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "La pfp est requise")]
        public string PictureURL { get; set; }


        [Display(Name = "La description")]
        [Required(ErrorMessage = "La description est requise")]
        public string Description { get; set; }


        public List<Disque> Disques { get; set; }
    }
}
