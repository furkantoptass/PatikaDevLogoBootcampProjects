﻿using System.Collections.Generic;

namespace ApartmanYonetimOtomasyonu.Web.Models
{
    public class UserRolesViewModel
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string TCNo { get; set; }
        public string CarLicensePlate { get; set; }        
        
        public IEnumerable<string> Roles { get; set; }
    }
}
