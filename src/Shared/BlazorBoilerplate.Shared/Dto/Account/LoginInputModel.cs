﻿using BlazorBoilerplate.Localization;
using System.ComponentModel.DataAnnotations;

namespace BlazorBoilerplate.Shared.Dto.Account
{
    public class LoginInputModel : AccountFormModel
    {
        [Required(ErrorMessageResourceType = typeof(Strings), ErrorMessageResourceName = "FieldRequired")]
        public string UserName { get; set; }

        [Required(ErrorMessageResourceType = typeof(Strings), ErrorMessageResourceName = "FieldRequired")]
        public string Password { get; set; }
    }
}