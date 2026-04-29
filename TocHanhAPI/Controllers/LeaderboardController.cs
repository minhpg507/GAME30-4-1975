using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TocHanhAPI.Data;
using TocHanhAPI.Models;

namespace TocHanhAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaderboardController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LeaderboardController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Leaderboard - Lấy Top 10 người điểm cao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Leaderboard>>> GetTopScores()
        {
            return await _context.Leaderboards
                .OrderByDescending(s => s.Score)
                .Take(10)
                .ToListAsync();
        }

        // POST: api/Leaderboard - Lưu điểm mới
        [HttpPost]
        public async Task<ActionResult<Leaderboard>> PostScore(Leaderboard scoreEntry)
        {
            _context.Leaderboards.Add(scoreEntry);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Ghi danh thành công!" });
        }
    }
}