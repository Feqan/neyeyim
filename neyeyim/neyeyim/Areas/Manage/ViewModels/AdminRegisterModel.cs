﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Areas.Manage.ViewModels
{
    public class AdminRegisterModel
    {
        [StringLength(maximumLength: 30)]
        public string Name { get; set; }
        [StringLength(maximumLength: 20)]
        public string UserName { get; set; }
        [StringLength(maximumLength: 50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}