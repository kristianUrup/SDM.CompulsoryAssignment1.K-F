using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;

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
        public int AmountOfGradesById(int reviewerId, int grade)
        {
            int gradesById = 0;
            foreach (var movie in _movies)
            {
                if (movie.Reviewer == reviewerId && movie.Grade == grade) 
                {
                    gradesById++;
                }
            }

            if (gradesById == 0)
            {
                throw new InvalidDataException("Could not find reviews by this ID or grade");
            }

            return gradesById;
        }

        //Exercise 4
        public int MovieReviews(int movieId)
        {
            int amountOfReviews = 0;
            foreach (var movie in _movies)
            {
                if (movieId == movie.MovieId)
                {
                    amountOfReviews++;
                }
            }

            if (amountOfReviews == 0)
            {
                throw new InvalidDataException("Movie not watched yet,or the movie does not exists, pick another movie");
            }

            return amountOfReviews;
        }
        
        //Exercise 5
        public double AverageGradeOfMovie(int movieId)
        {
            double sumRating = 0;
            double amountOfRates = 0;
            foreach (var movie in _movies)
            {
                if (movie.MovieId == movieId)
                {
                    sumRating = sumRating + movie.Grade;
                    amountOfRates++;
                }
            }
            if (sumRating == 0) throw new InvalidDataException
                ("The movie has not given a grade yet or the movie doesnt exist");

            return sumRating / amountOfRates;
        }

        //Exercise 6
        public int AmountOfGradesGivenById(int movieId, int grade)
        {
            int amount = 0;
            foreach (var movie in _movies)
            {
                if (movie.MovieId == movieId && movie.Grade == grade)
                {
                    amount++;
                }
            }

            if (amount == 0) throw new InvalidDataException("No movie with that grade is found");

            return amount;
        }

        //Exercise 7
        public List<Movie> MoviesWithTopRate5()
        {
            //List<Movie> tempList = _movies.Where(m => m.Grade == 5).OrderBy(m => m.MovieId).ToList();
            //int[] listToSort = new int[tempList.Count()];
            //int[] anotherList = new int[tempList.];
            //for (int i = 0; i < UPPER; i++)
            //{

            //}

            //foreach (var movie in tempList)
            //{
            //    for (int i = 1; i < tempList.Count()-1; i++)
            //    {
            //        if (movie.MovieId == i)
            //        {
            //            count++;
            //        }
            //        else
            //        {
            //            listToSort = new int[i,movie.MovieId];
            //        }
            //    }
            //}

            //for (int i = 0; i < listToSort.Length; i++)
            //{
            //    for (int j = 1; j < listToSort[i,1]; j++)
            //    {
            //        if (i < j)
            //        {
            //            listToSort = new int[i,j];
            //        }
            //    }
            //}
            //List<object> addingList = new List<object>();
            //foreach (var movie in tempList)
            //{
            //    foreach (var movie1 in tempList)
            //    {
            //        if (movie.MovieId != movie1.MovieId)
            //        {
            //            addingList.Add(new 
            //            {
            //                MovieId = movie1.MovieId,
            //                count = count
            //            });
            //            count = 0;

            //        }
            //        else
            //        {
            //            count++;
            //        }

            //    }
            //}


            //return tempList;
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
