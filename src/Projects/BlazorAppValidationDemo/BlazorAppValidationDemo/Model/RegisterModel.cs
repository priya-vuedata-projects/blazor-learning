using System.ComponentModel.DataAnnotations;

namespace BlazorAppValidationDemo.Model
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3–50 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
        public string? Password { get; set; }

        [Required]
        [Compare(nameof(Password),ErrorMessage = "Passwords do not match")]
        public string? ConfirmPassword { get; set; }

        [Required]
        [CustomAgeValidation(18, ErrorMessage = "You must be at least 18 years old")]
        public DateTime DateOfBirth { get; set; }
    }

    public class CustomAgeValidationAttribute : ValidationAttribute
    {
        private readonly int _minAge;
        public CustomAgeValidationAttribute(int minAge)
        {
            _minAge = minAge;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime dob)
            {
                var age = DateTime.Today.Year - dob.Year;
                if (dob > DateTime.Today.AddYears(-age)) age--;

                if (age < _minAge)
                    return new ValidationResult(ErrorMessage ?? $"Must be at least {_minAge} years old.");
            }

            return ValidationResult.Success;
        }
    }
}
