﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Users
    {
        public Users()
        {
            History = new HashSet<History>();
        }

        public int UsersId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserGender { get; set; }
        public string UserCountry { get; set; }
        public string UserEmail { get; set; }
        public int UserPhoneNumber { get; set; }
        public string UserSchoolName { get; set; }

        public virtual ICollection<History> History { get; set; }
    }
}