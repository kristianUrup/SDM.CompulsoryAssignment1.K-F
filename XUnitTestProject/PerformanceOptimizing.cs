using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Timers;
using SDM.CompulsoryAssignment1.Exercise1;
using Xunit;

namespace XUnitTestProject
{
    public class PerformanceOptimizing
    {
        private static MovieSystem _ms;

        public PerformanceOptimizing()
        {
            _ms = new MovieSystem("ratings.json");
        }

        [Fact]
        public void PerformanceTestReviewsById()
        {
            var stopwatch = new Stopwatch();
            int id = 1;

            stopwatch.Start();
            int result = _ms.ReviewsById(id);
            stopwatch.Stop();

            var stop = stopwatch.ElapsedMilliseconds;
            long expectedTime = 4000;
            Assert.True(stop <= expectedTime);       
        }

        [Fact]
        public void PerformanceTestAmountOfGradesGivenById()
        {
            var stopwatch = new Stopwatch();
            int movieId = 2;
            int grade = 3;

            stopwatch.Start();
            _ms.AmountOfGradesById(movieId, grade);
            stopwatch.Stop();

            var stop = stopwatch.ElapsedMilliseconds;
            long expectedTime = 4000;
            Assert.True(stop <= expectedTime);
        }

        [Fact]
        public void TestMovieReviews()
        {
            int movieId = 3;
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            _ms.MovieReviews(3);
            stopwatch.Stop();

            var stop = stopwatch.ElapsedMilliseconds;
            long expectedTime = 4000;
            Assert.True(stop <= expectedTime);
        }
    }
}
