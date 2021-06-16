using Moq;
using NUnit.Framework;
using QuickStart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickStart.Tests
{
    class VideoServiceTests
    {
        [Test]
        public void GetUnprocessedVideosAsCsv_AllVideosIsProcessed_ReturnEmptyString()
        {
            //arrange
            var videoService = new VideoServiceV2(new EmptyVideosFakeVideoRepository());

            //act
            var result = videoService.GetUnprocessedVideosAsCsv();

            //assert
            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void GetUnprocessedVideosAsCsv_GetUnProcessedVideos_ReturnVideoIdsAsString()
        {
            //arrange
            var videoService = new VideoServiceV2(new VideosFakeVideoRepository());

            //act
            var result = videoService.GetUnprocessedVideosAsCsv();

            //assert
            Assert.That(result, Is.EqualTo("1,2"));
        }
    }
}
