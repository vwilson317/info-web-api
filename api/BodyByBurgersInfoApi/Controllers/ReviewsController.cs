using BodyByBurgersInfoApi.BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BodyByBurgersInfoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly List<ReviewDto> _reviews;
        private readonly IService<Review, ReviewDto> _reviewService;

        public ReviewsController(IService<Review, ReviewDto> reviewService)
        {
            // Initialize the list of reviews
            _reviews = new List<ReviewDto>();
            _reviewService = reviewService;
        }

        // GET: api/reviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReviewDto>>> GetReviews()
        {
            var reviews = await _reviewService.GetAsync();
            return Ok(reviews.OrderByDescending(r => r.Date));
        }

        // GET: api/reviews/{id}
        [HttpGet("{id}")]
        public ActionResult<ReviewDto> GetReview(int id)
        {
            var review = _reviews.Find(r => r.Id == id);
            if (review == null)
            {
                return NotFound();
            }
            return review;
        }

        [HttpGet("stats")]
        public async Task<ActionResult<StatisticsDto>> GetStats([FromQuery] DateTime? startDate = null,
            [FromQuery] DateTime? endDate = null)
        {
            var reviews = await _reviewService.GetAsync(r => r.Date >= (startDate ?? DateTime.MinValue) &&
                r.Date <= (endDate ?? DateTime.Now));
            return Ok(new StatisticsDto
            {
                Count = reviews.Count(),
                DollarsSpent = reviews.Sum(r => r.Price)
            });
        }
        
        // POST: api/reviews
        [HttpPost]
        public async Task<ActionResult<ReviewDto>> CreateReview(ReviewDto review)
        {
            await _reviewService.CreateAsync(review);

            return CreatedAtAction(nameof(GetReview), new { id = review.Id }, review);
        }

        // PUT: api/reviews/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateReview(int id, ReviewDto updatedReview)
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