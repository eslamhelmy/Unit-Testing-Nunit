using QuickStart.Models;
using System.Collections.Generic;
using System.Linq;

namespace QuickStart
{
    public class VideoRepository : IVideoRepository
    {
        public IEnumerable<Video> GetUnprocessedVideos()
        {
            using (var context = new VideoContext())
            {
                var videos = (from video in context.Videos
                              where !video.IsProcessed
                              select video).ToList();

                return videos;
            }
        }
    }
}
