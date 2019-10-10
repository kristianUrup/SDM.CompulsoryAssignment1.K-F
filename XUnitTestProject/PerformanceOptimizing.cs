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
        [Fact]
        public void PerformanceTestReviewsById()
        {
            Stopwatch.StartNew();
            int id = 1;

            List<Movie> movies = new List<Movie>()
            {
                new Movie { Reviewer =  1},
                new Movie { Reviewer =  1},
                new Movie { Reviewer =  2},
                new Movie { Reviewer =  2},
                new Movie { Reviewer =  3},
            };
            MovieSystem ms = new MovieSystem(movies);
            int result = ms.ReviewsById(id);
            var stop = Stopwatch.GetTimestamp();
            Assert.True(stop <= 4);
        }
    }
}
