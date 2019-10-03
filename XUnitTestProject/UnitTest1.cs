using SDM.CompulsoryAssignment1.Exercise1;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void TestReviewsById()
        {
            List<Movie> movies = 
            {
                new Movie { Reviewer = 1},
                new Movie { Reviewer = 1},
                new Movie { Reviewer = 1},
                new Movie { Reviewer = 1},
                new Movie { Reviewer = 1}
            };
            MovieSystem ms = new MovieSystem(movies);
        }
    }
}
