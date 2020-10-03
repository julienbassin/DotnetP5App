using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetP5App.Services
{
    public class ReviewRepository
    {
        CarDBContext _context;
        public ReviewRepository(CarDBContext context)
        {
            _context = context;
        }
        public void SaveReview(string comments, string name, string IdTraining, string rating)
        {
            int iidTraining = -1;
            if (!Int32.TryParse(IdTraining, out iidTraining))
            {
                return;
            }

            double dRating = -1;
            if (!double.TryParse(rating, NumberStyles.Any, CultureInfo.InvariantCulture, out dRating))
            {
                return;
            }

            var CurrentReview = new Review();
            CurrentReview.UserName = name;
            CurrentReview.Comments = comments;
            CurrentReview.CarId = iidTraining;
            CurrentReview.Rating = dRating;
            _context.Reviews.Add(CurrentReview);
            _context.SaveChanges();
        }
    }
}
