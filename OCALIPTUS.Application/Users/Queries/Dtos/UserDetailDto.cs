using AutoMapper;
using OCALIPTUS.Application.Common.Helpers;
using OCALIPTUS.Application.Common.Mappings;
using OCALIPTUS.Domain.Enums;
using OCALIPTUS.Domain.Identity;

namespace OCALIPTUS.Application.Users.Queries.Dtos
{
    public class UserDetailDto : IMapFrom<User>
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public Gender Gender { get; set; }
        public Nationality Nationality { get; set; }
        public MemberStatus MemberStatus { get; set; }

        public string GenderText
        {
            get
            {
                return Gender.GetDescription();
            }
        }


        public string NationalityText
        {
            get
            {
                return Nationality.GetDescription();
            }
        }

        public string MemberStatusText
        {
            get
            {
                return MemberStatus.GetDescription();
            }
        }

        public string ProfilePhoto { get; set; }
        public DateTime Birthdate { get; set; }
        public string BirthdateText { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<User, UserDetailDto>()
                /*.ForMember(dest => GenderText, opt => 
                    opt.MapFrom(c=>c.Gender.GetDescription()))*/
                .ForMember(dest => dest.BirthdateText, opt =>
                    opt.MapFrom(c => c.Birthdate.ToString("dd/MM/yyyy")));
        }
    }
}