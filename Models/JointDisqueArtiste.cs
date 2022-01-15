using System.ComponentModel.DataAnnotations;
using RecordStore.Data;

namespace RecordStore.Models
{
    public class JointDisqueArtiste
    {   
        public int DisqueId { get; set; }
        public Disque Disque { get; set; }
        public int ArtisteId { get; set; }
        public Artiste Artiste { get; set; }
    }
}
