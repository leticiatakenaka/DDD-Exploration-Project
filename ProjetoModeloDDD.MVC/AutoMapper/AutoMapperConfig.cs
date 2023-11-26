using AutoMapper;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            //MapperConfiguration configuration = new MapperConfiguration(cfg =>
            //{
            //    cfg.AllowNullCollections = true;
            //    cfg.AddProfile(new DomainToViewModelMappingProfile());
            //    cfg.AddProfile(new ViewModelToDomainMappingProfile());
            //});
        }

        public static MapperConfiguration MapperConfiguration()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(typeof(DomainToViewModelMappingProfile).Assembly);
                cfg.AddMaps(typeof(ViewModelToDomainMappingProfile).Assembly);
            });

            return configuration;
        }
    }
}