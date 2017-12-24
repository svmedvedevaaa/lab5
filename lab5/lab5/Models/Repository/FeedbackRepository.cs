using lab5.Models.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab5.Models.Repository
{
    public class FeedbackRepository
    {
        private PhotoModel _context;
        public FeedbackRepository(PhotoModel context)
        {
            _context = context;
        }

        public int InsertFeedback(Feedback fback)
        {
            var newFeedback = new Feedback
            {
                Email = fback.Email,
                 Id = Guid.NewGuid(),
                 Message = fback.Message,
                 Name = fback.Name,
                 Phone = fback.Phone
            };
            _context.Feedback.Add(newFeedback);
           return _context.SaveChanges();
        }
    }
}