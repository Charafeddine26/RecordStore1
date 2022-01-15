using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecordStore.Models
{
    public class Disque
    {
        [Key]
        public int Id { get; set; }

        public string Album { get; set; }
        public double Prix { get; set; }
        public int Annee { get; set; }
        public string Cover { get; set; }
        public string Format { get; set; }
        public string Pressing { get; set; }


        public List<JointDisqueArtiste> JointDisqueArtistes { get; set; }
        
        
        public int LabelId { get; set; }
        [ForeignKey("LabelId")]
        public Label Label { get; set; }


        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }
    }
}
