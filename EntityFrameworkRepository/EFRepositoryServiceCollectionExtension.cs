using EntityFrameworkRepository.Interfaces;
using EntityFrameworkRepository.Mapper;
using Microsoft.Extensions.DependencyInjection;
using MusicListWorkflow.Contracts;
using Repository.Contracts;

namespace EntityFrameworkRepository
{

    public static class EFRepositoryServiceCollectionExtension
    {
        public static void RegisterEntityFrameworkRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserEntityFrameworkRepository>();
            services.AddScoped<ISongRepository, SongEntityFrameworkRepository>();
            services.AddScoped<IPersonRepository, PersonEntityFrameworkRepository>();
            services.AddScoped<ILikedSongRepository, LikedSongEntityFrameworkRepository>();
            services.AddScoped<ILikedAlbumRepository, LikedAlbumEntityFrameworkRepository>();
            services.AddScoped<IArtistRepository, ArtistEntityFrameworkRepository>();
            services.AddScoped<IAlbumRepository, AlbumEntityFrameworkRepository>();
        }

        public static void RegisterDataMapperServices(this IServiceCollection services)
        {
            services.AddScoped<IUserDataMapper, UserDataMapper>();
            services.AddScoped<ISongDataMapper, SongDataMapper>();
            services.AddScoped<IPersonDataMapper, PersonDataMapper>();
            services.AddScoped<ILikedSongDataMapper, LikedSongDataMapper>();
            services.AddScoped<ILikedAlbumDataMapper, LikedAlbumDataMapper>();
            services.AddScoped<IArtistDataMapper, ArtistDataMapper>();
            services.AddScoped<IAlbumDataMapper, AlbumDataMapper>();
        }
    }
}
