using Backend.Models;

namespace Backend.Interfaces
{
    public interface IReviewerRepository
    {
        Reviewer GetReviewer(int reviewerId);
        ICollection<Reviewer> GetReviewers();
        ICollection<Review> GetReviewsByReviewer(int reviewerId);
     
        bool ReviewerExists(int reviewerId);
        bool CreateReviewer(Reviewer reviewer);
        bool Save();
    }
}
