using Moq;
using NUnit.Framework;
using QuickStart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickStart.Tests
{
    class MoqVideoServiceTests
    {
        [Test]
        public void GetUnprocessedVideosAsCsv_AllVideosIsProcessed_ReturnEmptyString()
        {
            //arrange
            var fakeVideoRepository = new Mock<IVideoRepository>();
            var videoService = new VideoServiceV2(fakeVideoRepository.Object);

            //act
            var result = videoService.GetUnprocessedVideosAsCsv();

            //assert
            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void GetUnprocessedVideosAsCsv_GetUnProcessedVideos_ReturnVideoIdsAsString()
        {
            //arrange
            var fakeVideoRepository = new Mock<IVideoRepository>();
            fakeVideoRepository.Setup(fk => fk.GetUnprocessedVideos())
                               .Returns(new List<Video>
                               {
                                   new Video
                                   {
                                       Id = 1
                                   },
                                   new Video
                                   {
                                       Id = 2
                                   }
                               });
            var videoService = new VideoServiceV2(fakeVideoRepository.Object);

            //act
            var result = videoService.GetUnprocessedVideosAsCsv();

            //assert
            Assert.That(result, Is.EqualTo("1,2"));
        }

    }
}
