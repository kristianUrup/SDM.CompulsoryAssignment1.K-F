using SDM.CompulsoryAssignment1.Exercise1;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 2)]
        [InlineData(3, 1)]
        public void TestReviewsById(int id, int expResult)
        {
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
            Assert.Equal(result, expResult);
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
