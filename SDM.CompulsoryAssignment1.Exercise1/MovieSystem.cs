using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SDM.CompulsoryAssignment1.Exercise1
{
    public class MovieSystem
    {
        private List<Movie> _movies;
        public MovieSystem(string fileName)
        {
            //TODO
        }

        public MovieSystem(List<Movie> movies)
        {
            _movies = movies;
        }
        //Exercise 1
        public int ReviewsById(int reviewerId)
        {
            int numOfReview = 0;
            foreach(Movie movie in _movies)
            {
                if (movie.Reviewer == reviewerId)
                {
                    numOfReview++;
                }
            }
            if (numOfReview == 0)
            {
                throw new InvalidDataException("Reviewer not found");
            } else
            {
                return numOfReview;
            } 
        }
        //Exercise 2
        public double AverageScoreById(int reviewerId)
        {
            double sumRating = 0;
            double amountOfRatings = 0;
            foreach (var movie in _movies)
            {
                if (reviewerId == movie.Reviewer)
                {
                    sumRating = sumRating + movie.Grade;
                    amountOfRatings++;
                }
            }

            if (sumRating <= 0)
            {
                throw new InvalidDataException("Id not found");
            }
            return sumRating / amountOfRatings;

        }

        //Exercise 3
        public int AmountOfGradesById(int reviewerId)
        {
            int gradesById = 0;
            foreach (var movie in _movies)
            {
                if (movie.Reviewer == reviewerId)
                {
                    gradesById++;
                }
            }

            if (gradesById == 0)
            {
                throw new InvalidDataException("The id was not found");
            }

            return gradesById;
        }

        //Exercise 4
        public int ReviewedMovie(int movieId)
        {
            throw new NotImplementedException();
        }
        
        //Exercise 5
        public double RateOfMovie(int movieId)
        {
            throw new NotImplementedException();
        }

        //Exercise 6
        public int MovieRecievedSpecificRate(int movieId, int Rate)
        {
            throw new NotImplementedException();
        }

        //Exercise 7
        public int MoviesWithTopRate5()
        {
            throw new NotImplementedException();
        }

        //Exercise 8 
        public int ReviewerWatchedMostMovies()
        {
            throw new NotImplementedException();
        }

        //Exercise 9
        public int TopXMovies(int numberOfMovies)
        {
            throw new NotImplementedException();
        }

        //Exercise 10
        public List<Movie> SortedRateAndDateById()
        {
            throw new NotImplementedException();
        }

        //Exercise 11
        public List<Movie> SortedReviewerReviewedMovieById()
        {
            throw new NotImplementedException();
        }
    }
}
