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

            Mapper.CreateMap<CreateAndEditStory, Story>()
                    .ForMember(d => d.StoryType, t => t.Ignore())
                    .ForMember(d => d.DateCreated, t => t.Ignore())
                    .ForMember(d => d.DateModified, t => t.Ignore())
                    .ForMember(d => d.Votes, t => t.Ignore());

            Mapper.AssertConfigurationIsValid();
        }
    }
}