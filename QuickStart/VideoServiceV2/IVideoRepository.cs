using QuickStart.Models;
using System.Collections.Generic;

namespace QuickStart
{
    public interface IVideoRepository
    {
        IEnumerable<Video> GetUnprocessedVideos();
    }
}