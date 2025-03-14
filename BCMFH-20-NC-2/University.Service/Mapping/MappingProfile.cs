﻿using AutoMapper;
using University.Models.Dtos.Course;
using University.Models.Dtos.Identity;
using University.Models.Dtos.Teacher;
using University.Models.Entities;

namespace University.Service.Mapping
{
    public class MappingProfile : Profile
    {
        //ForPath შეიძლება დაგჭირდეთ ForMember - ის მაგივრად როცა ცდილობთ Nested ტიპებს მიწვდეთ.
        //შეიძლება პრობლემა შეგექმანთ როცა Automapper - ის შიგნით LINQ Extension მეთოდების გამოყენებას ეცდებით.
        public MappingProfile()
        {
            CreateMap<Teacher, TeacherForGettingDto>()
                .ForMember(dest => dest.Id, options => options.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, options => options.MapFrom(src => src.Name))
                .ForMember(dest => dest.ProfilePictureUrl, options => options.MapFrom(src => src.ProfilePictureUrl));

            CreateMap<TeacherForCreatingDto, Teacher>()
                .ForMember(dest => dest.Name, options => options.MapFrom(src => src.Name))
                .ForMember(dest => dest.ProfilePictureUrl, options => options.MapFrom(src => src.ProfilePictureUrl));

            CreateMap<TeacherForUpdatingDto, Teacher>()
                .ForMember(dest => dest.Id, options => options.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, options => options.MapFrom(src => src.Name));

            CreateMap<Course, CourseForGettingDto>()
                .ForMember(dest => dest.Id, options => options.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, options => options.MapFrom(src => src.Title));

            CreateMap<UserDto, ApplicationUser>().ReverseMap();
            CreateMap<RegistrationRequestDto, ApplicationUser>()
                .ForMember(dest => dest.UserName, options => options.MapFrom(src => src.Email))
                .ForMember(dest => dest.NormalizedUserName, options => options.MapFrom(src => src.Email.ToUpper()))
                .ForMember(dest => dest.Email, options => options.MapFrom(src => src.Email))
                .ForMember(dest => dest.NormalizedEmail, options => options.MapFrom(src => src.Email.ToUpper()))
                .ForMember(dest => dest.FullName, options => options.MapFrom(src => src.FullName));
        }
    }
}
