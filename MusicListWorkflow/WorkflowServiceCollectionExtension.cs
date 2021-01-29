using Microsoft.Extensions.DependencyInjection;
using MusicListWorkflow.Contracts;
using MusicListWorkflow.Contracts.Mapper;
using MusicListWorkflow.Mapper;

namespace MusicListWorkflow
{
    public static class WorkflowServiceCollectionExtension
    {
        public static void RegisterWorkflowServices(this IServiceCollection services)
        {
            services.AddScoped<IUserWorkflow, UserWorkflow>();
            services.AddScoped<ISongWorkflow, SongWorkflow>();
            services.AddScoped<IPersonWorkflow, PersonWorkflow>();
            services.AddScoped<ILikedSongWorkflow, LikedSongWorkflow>();
            services.AddScoped<ILikedAlbumWorkflow, LikedAlbumWorkflow>();
            services.AddScoped<IArtistWorkflow, ArtistWorkflow>();
            services.AddScoped<IAlbumWorkflow, AlbumWorkflow>();
        }

        public static void RegisterWorkflowMapperServices(this IServiceCollection services)
        {
            services.AddScoped<IUserLogicMapper, UserLogicMapper>();
            services.AddScoped<ISongLogicMapper, SongLogicMapper>();
            services.AddScoped<IPersonLogicMapper, PersonLogicMapper>();
            services.AddScoped<ILikedSongLogicMapper, LikedSongLogicMapper>();
            services.AddScoped<ILikedAlbumLogicMapper, LikedAlbumLogicMapper>();
            services.AddScoped<IArtistLogicMapper, ArtistLogicMapper>();
            services.AddScoped<IAlbumLogicMapper, AlbumLogicMapper>();
        }


    }
}
