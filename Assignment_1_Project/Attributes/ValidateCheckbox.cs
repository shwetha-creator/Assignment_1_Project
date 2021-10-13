using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_1_Project.Attributes
{
    public class ValidateCheckbox: ValidationAttribute , IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-chkbox", ErrorMessage);
        }

        public override bool IsValid(object value)
        {
            if ((bool)value)
                return true;
            else
                return false;
        }
    }
}
