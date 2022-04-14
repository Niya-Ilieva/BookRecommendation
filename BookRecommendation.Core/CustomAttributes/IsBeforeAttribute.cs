using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecommendation.Core.CustomAttributes
{
    public class IsBeforeAttribute : ValidationAttribute
    {
        private readonly string compareDate;

        public IsBeforeAttribute(string _compareDate, string errorMessage = "")
        {
            compareDate = _compareDate;
            this.ErrorMessage = errorMessage;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            try
            {
                DateTime dateToCompare = (DateTime)validationContext
                    .ObjectType
                    .GetProperty(compareDate)
                    .GetValue(validationContext.ObjectInstance);

                if ((DateTime)value < dateToCompare)
                {
                    return ValidationResult.Success;
                }
            }
            catch (Exception)
            {
            }

            return new ValidationResult(ErrorMessage);
        }
    }
}
