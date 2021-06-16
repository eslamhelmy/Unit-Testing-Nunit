using QuickStart.Models;
using System.Collections.Generic;
using System.Linq;

namespace QuickStart
{
    public class EmptyVideosFakeVideoRepository : IVideoRepository
    {
        public IEnumerable<Video> GetUnprocessedVideos()
        {
            return new List<Video>();
        }
    }
}
