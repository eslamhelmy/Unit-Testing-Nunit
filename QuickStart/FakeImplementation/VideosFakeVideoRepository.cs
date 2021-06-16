using QuickStart.Models;
using System.Collections.Generic;
using System.Linq;

namespace QuickStart
{
    public class VideosFakeVideoRepository : IVideoRepository
    {
        public IEnumerable<Video> GetUnprocessedVideos()
        {
            return new List<Video>
            {
                new Video
                {
                    Id = 1
                },
                new Video
                {
                    Id = 2
                }
            };
        }
    }
}
