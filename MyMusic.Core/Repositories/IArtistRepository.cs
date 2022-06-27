using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMusic.Core;
using MyMusic.Core.Models;

namespace MyMusic.Core.Repositories
{
    public interface IArtistRepository : IRepository<Artist>
    {
        Task<IEnumerable<Artist>> GetAllWithMusicsAsync();
        Task<Artist> GetWithMusicsByIdAsync(int id);
    }
}
