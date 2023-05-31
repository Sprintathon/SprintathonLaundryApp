﻿using System;
namespace SprintathonLaundryApp.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class UserLogInDTo
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class CreateUserDto : User
    {
        public readonly int Id = 0;
        public string Name { get => $"{FirstName} {LastName}"; }
    }

}