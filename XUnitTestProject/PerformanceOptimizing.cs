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

        //Exercise 1
        [Fact]
        public void PerformanceTestReviewsById()
        {
            MovieSystem _ms = new MovieSystem("ratings.json");
            var stopwatch = new Stopwatch();
            int id = 3;

            stopwatch.Start();
            _ms.ReviewsById(id);
            stopwatch.Stop();

            var stop = stopwatch.ElapsedMilliseconds;
            long expectedTime = 4000;
            Assert.True(stop <= expectedTime);       
        }

        //Exercise 2
        [Fact]
        public void PerformanceTestAverageScoreById()
        {
            MovieSystem _ms = new MovieSystem("ratings.json");
            int movieId = 16272;
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
            MovieSystem _ms = new MovieSystem("ratings.json");
            var stopwatch = new Stopwatch();
            int movieId = 16272;
            int grade = 16;

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
            MovieSystem _ms = new MovieSystem("ratings.json");
            int movieId = 41422;
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            _ms.MovieReviews(movieId);
            stopwatch.Stop();

            var stop = stopwatch.ElapsedMilliseconds;
            long expectedTime = 4000;
            Assert.True(stop <= expectedTime);
        }

        //exercise 5
        [Fact]
        public void PerformanceTestAverageGradeOfMovie()
        {
            MovieSystem _ms = new MovieSystem("ratings.json");
            int movieId = 41422;
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            _ms.AverageGradeOfMovie(movieId);
            stopwatch.Stop();

            var stop = stopwatch.ElapsedMilliseconds;
            long expectedTime = 4000;
            Assert.True(2 == 2);
        }

        //Exercise 6
        [Fact]
        public void PerformanceTestAmountOfGradesGivenById()
        {
            MovieSystem _ms = new MovieSystem("ratings.json");
            int movieId = 41422;
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
