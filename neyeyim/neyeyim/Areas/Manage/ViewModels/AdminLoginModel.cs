using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Areas.Manage.ViewModels
{
    public class AdminLoginModel
    {
        [StringLength(maximumLength: 30)]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [StringLength(maximumLength: 50)]
        public string Password { get; set; }
    }
}