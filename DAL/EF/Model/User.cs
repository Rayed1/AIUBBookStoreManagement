﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class User
    {
        [Key]
        public int IntUserId { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public string UserEmail { get; set; }
        public long Age { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
