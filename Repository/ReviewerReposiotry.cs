using AutoMapper;
using Backend.Data;
using Backend.Interfaces;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repository
{
    public class ReviewerReposiotry : IReviewRepository
    {
        private readonly DataContext _context;
        public ReviewerReposiotry(DataContext context, IMapper mapper)
        {
            _context = context;
        }

        public Reviewer GetReviewer(int reviewerId)
        {
            return _context.Reviewers.Where(r => r.Id == reviewerId).Include(e => e.Reviews).FirstOrDefault();
        }

        public ICollection<Reviewer> GetReviewers()
        {
            return _context.Reviewers.ToList();
        }

        public ICollection<Review> GetReviewsByReviewer(int reviewerId)
        {
            return _context.Reviews.Where(r => r.Reviewer.Id == reviewerId).ToList();
        }

        public bool ReviewerExists(int reviewerId)
        {
            return _context.Reviewers.Any(r => r.Id == reviewerId);
        }
    }
}
