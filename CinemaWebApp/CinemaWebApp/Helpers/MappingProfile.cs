using AutoMapper;
using CinemaWebApp.Dtos;
using CinemaWebApp.Models;

namespace CinemaWebApp.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() { 
            CreateMap<Movie, MovieDetailsDto>();
            CreateMap<MovieDto, Movie>().ForMember(src => src.Poster, opt => opt.Ignore());
        }

    }
}
