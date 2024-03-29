﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        [Column(TypeName ="nvarchar(150)")]
        public string FullName { get; set; }

        
        public int UserRoleID { get; set; }

        [ForeignKey("UserRoleID")]
        public virtual UserRoleTest UserRoleTest { get; set; }

        public int Person_ID { get; set; }

        [ForeignKey("Person_ID")]
        public virtual Person Person { get; set; }
    }
}
