using SDM.CompulsoryAssignment1.Exercise1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Xunit;
using Xunit.Sdk;

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

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2.5, 2)]
        [InlineData(4, 3)]
        public void TestAverageScoreById(double expAverage, int reviewerId)
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie { Reviewer = 1,Grade = 1},
                new Movie { Reviewer = 1, Grade = 1},
                new Movie { Reviewer = 2, Grade = 2},
                new Movie { Reviewer = 2,Grade = 3},
                new Movie { Reviewer = 3,Grade = 4}
            };
            MovieSystem ms = new MovieSystem(movies);
            Assert.Equal(expAverage,ms.AverageScoreById(reviewerId));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-500)]
        public void TestExceptionThrownByAverageScoreById(int reviewerId)
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie { Reviewer = 1,Grade = 1},
                new Movie { Reviewer = 1, Grade = 1},
                new Movie { Reviewer = 2, Grade = 2},
                new Movie { Reviewer = 2,Grade = 3},
                new Movie { Reviewer = 3,Grade = 4}
            };
            MovieSystem ms = new MovieSystem(movies);
            Assert.Throws<InvalidDataException>(() => ms.AverageScoreById(reviewerId));
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(1, 2, 2)]
        [InlineData(1, 3, 4)]
        public void TestAmountOfGradesById(int expAmount, int reviewerId, int grade)
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie { Reviewer = 1,Grade = 1},
                new Movie { Reviewer = 1, Grade = 1},
                new Movie { Reviewer = 2, Grade = 2},
                new Movie { Reviewer = 2,Grade = 3},
                new Movie { Reviewer = 3,Grade = 4}
            };
            MovieSystem ms = new MovieSystem(movies);
            int amount = ms.AmountOfGradesById(reviewerId, grade);
            Assert.Equal(expAmount, amount);
        }

        [Theory]
        [InlineData(-100, 5)]
        [InlineData(10, 4)]
        [InlineData(1, 2)]
        public void TestExceptionThrownByAmountOfGradesById(int reviewerId, int grade)
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie { Reviewer = 1,Grade = 1},
                new Movie { Reviewer = 1, Grade = 1},
                new Movie { Reviewer = 2, Grade = 2},
                new Movie { Reviewer = 2,Grade = 3},
                new Movie { Reviewer = 3,Grade = 4}
            };
            MovieSystem ms = new MovieSystem(movies);
            Assert.Throws<InvalidDataException>(() => ms.AmountOfGradesById(reviewerId, grade));
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(2, 3)]
        public void TestMovieReviews(int expAmount, int movieId)
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie { Reviewer = 1, Grade = 1,MovieId = 1},
                new Movie { Reviewer = 1, Grade = 1,MovieId = 2},
                new Movie { Reviewer = 2, Grade = 2, MovieId = 3},
                new Movie { Reviewer = 2, Grade = 3, MovieId = 3},
                new Movie { Reviewer = 3, Grade = 4, MovieId = 2}
            };
            MovieSystem ms = new MovieSystem(movies);
            Assert.Equal(expAmount,ms.MovieReviews(movieId));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1002)]
        [InlineData(-2)]
        public void TestExceptionThrownByMovieReviews(int movieId)
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie { Reviewer = 1, Grade = 1,MovieId = 1},
                new Movie { Reviewer = 1, Grade = 1,MovieId = 2},
                new Movie { Reviewer = 2, Grade = 2, MovieId = 3},
                new Movie { Reviewer = 2, Grade = 3, MovieId = 3},
                new Movie { Reviewer = 3, Grade = 4, MovieId = 2}
            };
            MovieSystem ms = new MovieSystem(movies);
            Assert.Throws<InvalidDataException>(() => ms.MovieReviews(movieId));
        }
        
        [Theory]
        [InlineData(1,1)]
        [InlineData(2.5, 2)]
        [InlineData(2.5, 3)]
        public void TestAverageGradeOfMovie(double expRate, int movieId)
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie { Reviewer = 1, Grade = 1,MovieId = 1},
                new Movie { Reviewer = 1, Grade = 1,MovieId = 2},
                new Movie { Reviewer = 2, Grade = 2, MovieId = 3},
                new Movie { Reviewer = 2, Grade = 3, MovieId = 3},
                new Movie { Reviewer = 3, Grade = 4, MovieId = 2}
            };
            MovieSystem ms = new MovieSystem(movies);
            Assert.Equal(expRate,ms.AverageGradeOfMovie(movieId));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-234)]
        public void TestExceptionThrownByAverageGradeOfMovie(int movieId)
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie { Reviewer = 1, Grade = 1,MovieId = 1},
                new Movie { Reviewer = 1, Grade = 1,MovieId = 2},
                new Movie { Reviewer = 2, Grade = 2, MovieId = 3},
                new Movie { Reviewer = 2, Grade = 3, MovieId = 3},
                new Movie { Reviewer = 3, Grade = 4, MovieId = 2}
            };
            MovieSystem ms = new MovieSystem(movies);
            Assert.Throws<InvalidDataException>(() => ms.AverageGradeOfMovie(movieId));
        }

        [Theory]
        [InlineData(1,2,1)]
        [InlineData(1, 2, 4)]
        [InlineData(1, 1, 1)]
        [InlineData(2, 3, 2)]
        public void TestAmountOfGradesGivenById(double expAmount, int movieId, int grade)
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie { Reviewer = 1, Grade = 1, MovieId = 1},
                new Movie { Reviewer = 1, Grade = 1, MovieId = 2},
                new Movie { Reviewer = 2, Grade = 2, MovieId = 3},
                new Movie { Reviewer = 2, Grade = 2, MovieId = 3},
                new Movie { Reviewer = 3, Grade = 4, MovieId = 2}
            };
            MovieSystem ms = new MovieSystem(movies);
            Assert.Equal(expAmount,ms.AmountOfGradesGivenById(movieId,grade));
        }

        public void TestExceptionThrownByAmountOfGradesGivenById(int movieId, int grade)
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie { Reviewer = 1, Grade = 1, MovieId = 1},
                new Movie { Reviewer = 1, Grade = 1, MovieId = 2},
                new Movie { Reviewer = 2, Grade = 2, MovieId = 3},
                new Movie { Reviewer = 2, Grade = 2, MovieId = 3},
                new Movie { Reviewer = 3, Grade = 4, MovieId = 2}
            };
            MovieSystem ms = new MovieSystem(movies);
            Assert.Throws<InvalidDataException>(() => ms.AmountOfGradesById(movieId, grade));
        }

        [Fact]
        public void TestMoviesWithTopRate5()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie { Reviewer = 1, Grade = 1, MovieId = 1},
                new Movie { Reviewer = 1, Grade = 1, MovieId = 2},
                new Movie { Reviewer = 2, Grade = 5, MovieId = 3},
                new Movie { Reviewer = 2, Grade = 2, MovieId = 3},
                new Movie { Reviewer = 3, Grade = 4, MovieId = 2},
                new Movie { Reviewer = 3, Grade = 4, MovieId = 2},
                new Movie { Reviewer = 3, Grade = 5, MovieId = 3},
                new Movie { Reviewer = 3, Grade = 4, MovieId = 2},
                new Movie { Reviewer = 2, Grade = 5, MovieId = 3},
                new Movie { Reviewer = 3, Grade = 4, MovieId = 2},
                new Movie { Reviewer = 3, Grade = 5, MovieId = 2}
            };
            MovieSystem ms = new MovieSystem(movies);
            List<Movie> expList = new List<Movie>()
            {
                new Movie
                {
                    Reviewer = 3, Grade = 5,MovieId = 3
                }
            };
            Assert.Equal(expList,ms.MoviesWithTopRate5());
        }
    }
}
