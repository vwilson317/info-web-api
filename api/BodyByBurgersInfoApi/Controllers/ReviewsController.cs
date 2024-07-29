using BodyByBurgersInfoApi.BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BodyByBurgersInfoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly List<Review> _reviews;
        private readonly IReviewService _reviewService;

        public ReviewsController(IReviewService reviewService)
        {
            // Initialize the list of reviews
            _reviews = new List<Review>();
            _reviewService = reviewService;
        }

        // GET: api/reviews
        [HttpGet]
        public ActionResult<IEnumerable<Review>> GetReviews()
        {
            return _reviews;
        }

        // GET: api/reviews/{id}
        [HttpGet("{id}")]
        public ActionResult<Review> GetReview(int id)
        {
            var review = _reviews.Find(r => r.Id == id);
            if (review == null)
            {
                return NotFound();
            }
            return review;
        }

        // POST: api/reviews
        [HttpPost]
        public async Task<ActionResult<Review>> CreateReview(ReviewDto review)
        {
            await _reviewService.CreateAsync(review);

            return CreatedAtAction(nameof(GetReview), new { id = review.Id }, review);
        }

        // PUT: api/reviews/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateReview(int id, Review updatedReview)
        {
            var review = _reviews.Find(r => r.Id == id);
            if (review == null)
            {
                return NotFound();
            }
            // Update other properties as needed

            return NoContent();
        }

        // DELETE: api/reviews/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteReview(int id)
        {
            var review = _reviews.Find(r => r.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            _reviews.Remove(review);

            return NoContent();
        }
    }
}