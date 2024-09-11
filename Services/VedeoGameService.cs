using BlazorServerCrudDotnet8.Data;
using BlazorServerCrudDotnet8.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerCrudDotnet8.Services
{
    public class VideoGameService : IVideoGameService
    {
        private readonly DataContext _context;
        public VideoGameService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<VideoGame>> GetAllGamesAsync()
        {
            var result = await _context.VideoGames.ToListAsync();
            return result;
        }

    }
}