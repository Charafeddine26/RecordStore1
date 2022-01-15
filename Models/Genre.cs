using RecordStore.Data;
using System.ComponentModel.DataAnnotations;

namespace RecordStore.Models
{
    public class Genre
    {

        [Key]
        public int Id { get; set; }

        public DisqueGenre DisqueGenre { get; set; }

        public List<Disque> Disques { get; set; }

    }
}
