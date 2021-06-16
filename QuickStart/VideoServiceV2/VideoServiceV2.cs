using System;
using System.Collections.Generic;

namespace QuickStart
{
    public class VideoServiceV2
    {
        private IVideoRepository _repo;

        public VideoServiceV2(IVideoRepository repo)
        {
            _repo = repo;
        }


        public string GetUnprocessedVideosAsCsv()
        {
            var videoIds = new List<int>();

            var videos = _repo.GetUnprocessedVideos();

            foreach (var v in videos)
                videoIds.Add(v.Id);

            return String.Join(",", videoIds);
        }

    }
}