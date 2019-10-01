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

        public double AverageScoreById(int reviewerId)
        {
            throw new NotImplementedException();
        }


    }
}
