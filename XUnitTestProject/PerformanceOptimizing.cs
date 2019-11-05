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

        //Exercise 1
        [Fact]
        public void PerformanceTestReviewsById()
        {
            var stopwatch = new Stopwatch();
            int id = 3;

            stopwatch.Start();
            int result = _ms.ReviewsById(id);
            stopwatch.Stop();

            var stop = stopwatch.ElapsedMilliseconds;
            long expectedTime = 4000;
            Assert.True(stop <= expectedTime);       
        }

        //Exercise 2
        [Fact]
        public void PerformanceTestAverageScoreById()
        {
            int movieId = 3;
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            _ms.AverageScoreById(movieId);
            stopwatch.Stop();

            var stop = stopwatch.ElapsedMilliseconds;
            long expectedTime = 4000;
            Assert.True(stop <= expectedTime);
        }

        //Exercise 3
        [Fact]
        public void PerformanceTestAmountOfGradesById()
        {
            var stopwatch = new Stopwatch();
            int movieId = 3;
            int grade = 3;

            stopwatch.Start();
            _ms.AmountOfGradesById(movieId, grade);
            stopwatch.Stop();

            var stop = stopwatch.ElapsedMilliseconds;
            long expectedTime = 4000;
            Assert.True(stop <= expectedTime);
        }

        //Exercise 4
        [Fact]
        public void PerformanceTestMovieReviews()
        {
            
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            _ms.MovieReviews(3);
            stopwatch.Stop();

            var stop = stopwatch.ElapsedMilliseconds;
            long expectedTime = 4000;
            Assert.True(stop <= expectedTime);
        }

        //exercise 5
        [Fact]
        public void PerformanceTestAverageGradeOfMovie()
        {
            int movieId = 2567280;
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            _ms.AverageGradeOfMovie(movieId);
            stopwatch.Stop();

            var stop = stopwatch.ElapsedMilliseconds;
            long expectedTime = 4000;
            Assert.True(stop <= expectedTime);
        }

        //Exercise 6
        [Fact]
        public void PerformanceTestAmountOfGradesGivenById()
        {
            int movieId = 2;
            int grade = 4;
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            _ms.AmountOfGradesGivenById(movieId, grade);
            stopwatch.Stop();

            var stop = stopwatch.ElapsedMilliseconds;
            long expectedTime = 4000;
            Assert.True(stop <= expectedTime);
        }
    }
}
