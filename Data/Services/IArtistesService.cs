using RecordStore.Models;

namespace RecordStore1.Data.Services
{
    public interface IArtistesService
    {
        IEnumerable<Artiste> GetAll();

        Artiste GetById(int id);

        void Add(Artiste artiste);

        Artiste Update(int id, Artiste newArtiste);

        void Delete(int id);
    }
}
