using System.ComponentModel.DataAnnotations;

namespace CustomerOrderManagement.Models.CustomValidators
{
    public class AddressValidationAttribute : ValidationAttribute
    {
        public string AddressLocation { get; set; }

        public override bool IsValid(object? value)
        {

            //if(value == null) return false;

            //if(value != AddressLocation) return false;

            return true; 
            
        }

    }
}
