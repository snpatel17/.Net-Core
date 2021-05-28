using DisneyCloneWebAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyCloneWebAPI.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContext _context;

        public MovieRepository(MovieContext context)
        {
            _context = context;
        }
        public async Task<List<MovieModel>> GetAllMovieAsync()
        {
            var records = await _context.Movies.Select(x=>new MovieModel() {
                MovieId = x.MovieId,
                BackgroundImg = x.BackgroundImg,
                CardImg=x.CardImg,
                Description=x.Description,
                SubTitle=x.SubTitle,
                Title=x.Title,
                TitleImg=x.TitleImg,
                Type=x.Type
            }).ToListAsync();

            return records;
        }

        public async Task<MovieModel> GetMoviebyIdAsync(int movieId)
        {
            var records = await _context.Movies.Where(x =>x.MovieId == movieId).Select(x=> new MovieModel()
            {
                MovieId = x.MovieId,
                BackgroundImg = x.BackgroundImg,
                CardImg = x.CardImg,
                Description = x.Description,
                SubTitle = x.SubTitle,
                Title = x.Title,
                TitleImg = x.TitleImg,
                Type = x.Type
            }).FirstOrDefaultAsync();

            return records;
        }

        public async Task<int> AddMovieAsync(MovieModel movieModel)
        {
            var movie = new MovieModel()
            {
                BackgroundImg = movieModel.BackgroundImg,
                CardImg = movieModel.CardImg,
                Description = movieModel.Description,
                SubTitle = movieModel.SubTitle,
                Title = movieModel.Title,
                TitleImg = movieModel.TitleImg,
                Type = movieModel.Type
            };
            _context.Movies.Add(movie);
           await _context.SaveChangesAsync();
            return movie.MovieId;
        }

        public async Task UpdateMovieAsync(int MovieId, MovieModel movieModel)
        {
            var movie = await _context.Movies.FindAsync(MovieId);
            if (movie != null)
            {
                movie.BackgroundImg = movieModel.BackgroundImg;
                movie.CardImg = movieModel.CardImg;
                movie.Description = movieModel.Description;
                movie.SubTitle = movieModel.SubTitle;
                movie.Title = movieModel.Title;
                movie.TitleImg = movieModel.TitleImg;
                movie.Type = movieModel.Type;

                await _context.SaveChangesAsync();
              }
           
        }
    }
}
