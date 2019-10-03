using SDM.CompulsoryAssignment1.Exercise1;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void TestReviewsById()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie { Reviewer = 1},
                new Movie { Reviewer = 1},
                new Movie { Reviewer = 2},
                new Movie { Reviewer = 2},
                new Movie { Reviewer = 3}
            };
            MovieSystem ms = new MovieSystem(movies);
        }

        [Theory]
        [InlineData(0)]
        public void TestExceptionThrownByReviewsById(int reviewer)
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie { Reviewer = 1},
                new Movie { Reviewer = 1},
                new Movie { Reviewer = 2},
                new Movie { Reviewer = 2},
                new Movie { Reviewer = 3}
            };
            MovieSystem ms = new MovieSystem(movies);
            Assert.Throws<InvalidDataException>(() => ms.ReviewsById(reviewer));
        }
    }
}
