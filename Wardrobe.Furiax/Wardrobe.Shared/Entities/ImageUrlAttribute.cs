using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class ImageUrlAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
        {
            return ValidationResult.Success; 
        }

        var url = value.ToString();

       
        string pattern = @"^(http(s?):)([/|.|\w|\s|-])*\.(?:jpg|jpeg|gif|png|bmp|svg)$";

        if (!Regex.IsMatch(url, pattern, RegexOptions.IgnoreCase))
        {
            return new ValidationResult("The URL must point to an image file (jpg, jpeg, gif, png, bmp, svg).");
        }

        return ValidationResult.Success;
    }
}
