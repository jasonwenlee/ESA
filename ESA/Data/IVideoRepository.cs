using ESA.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ESA.Data
{
    // Author: Wen Loong Lee, Rodrigo Echeverria

    // This is the interface for video repository
    public interface IVideoRepository
    {
        Task<List<Video>> GetVideosAsync();
        Task<Video> GetVideoAsync(int id);
        Task<int> SaveVideoAsync(Video item);
        Task<int> DeleteVideoAsync(Video item);
    }
}
