using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ical.Net.CalendarComponents;
using Ical.Net.DataTypes;
using Ics.Calendar;
using Ics.Helper;
using Repository.Poco;

namespace Ics.AutoMapper
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<MatchPoco, CalendarItem>()
                .ForMember(dest => dest.StartDate, map => map.MapFrom(src => src.DateMatch.Value))
                //.ForMember(dest => dest.IsRecurrence, map => map.MapFrom(src => true))

                .AfterMap((src, dest) =>
                {
                    dest.StartDate = dest.StartDate.Value.ToDateMatch(src.DateMatchTimeString);
                    dest.EndDate = dest.StartDate.Value.AddHours(2);
                    dest.Description = src.ToDescription();
                    dest.Location = src.VenueName ?? "";
                    dest.Summary = src.OfficialMatchName;
                })
                ;


            CreateMap<CalendarItem, CalendarEvent>()
                .ForMember(dest => dest.Summary, map => map.MapFrom(src => src.Summary))
                .ForMember(dest => dest.Description, map => map.MapFrom(src => src.Description))
                .ForMember(dest => dest.Location, map => map.MapFrom(src => src.Location))
                //.ForMember(dest => dest.RecurrenceRules, 
                //    map => map.MapFrom(src => UtilityHepler.ListOfRecurrence(src.Frequency,src.NumberOfRecurrence)))

                .AfterMap((src, dest) =>
                {
                    dest.DtStart = new CalDateTime(src.StartDate.Value);
                    dest.DtEnd = new CalDateTime(src.EndDate.Value);
                  
                })

                ;



        }



    }


}
