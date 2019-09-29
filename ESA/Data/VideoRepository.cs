using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using ESA.Models;
using SQLite;

namespace ESA.Data
{
    // Author: Wen Loong Lee, Rodrigo Echeverria

    // This class handles the database controller for videos. The controller can grab a list of videos
    // or video based on ID. It can also delete video or save new video.

    public class VideoRepository : IVideoRepository
    {

        readonly SQLiteAsyncConnection database;
        string path;

        // Constructor creates path to database with a given name then establishes connection to it. 
        // A table containing Video objects is then created.
        public VideoRepository(string dbPath)
        {
            Console.WriteLine("Create database because empty");
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbPath);
            database = new SQLiteAsyncConnection(path);
            database.CreateTableAsync<Video>().Wait();
        }

        // Get a video based on id
        public Task<Video> GetVideoAsync(int id)
        {
            return database.Table<Video>()
                                    .Where(i => i.ID == id)
                                    .FirstOrDefaultAsync();
        }

        // Get list of videos
        public Task<List<Video>> GetVideosAsync()
        {
            return database.Table<Video>().ToListAsync();
        }

        public Task<int> DeleteVideoAsync(Video item)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveVideoAsync(Video item)
        {
            throw new NotImplementedException();
        }
    }
}
