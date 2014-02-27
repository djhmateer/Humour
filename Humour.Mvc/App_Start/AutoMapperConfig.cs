using AutoMapper;
using Humour.Model;
using Humour.Mvc.Models.Story;

namespace Humour.Mvc.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Start()
        {
            Mapper.CreateMap<Story, DisplayStory>();

            Mapper.AssertConfigurationIsValid();
        }
    }
}