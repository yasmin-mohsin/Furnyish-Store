﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WebApplication2.Models;

namespace WebApplication2.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the UsingIdentityUser class
    public class UsingIdentityUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar(100)")]
        public string Firstname { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        public List<User_Product> User_Products { get; set; }
        public List<Order> Orders { get; set; }
        public List<ShoppingProduct> shoppingProducts { get; set; }
    }
}
