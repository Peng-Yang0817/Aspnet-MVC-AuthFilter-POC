using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace FiltersAndLogIn.Models
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "使用者名稱")]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}