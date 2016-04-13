using System.ComponentModel.DataAnnotations;

namespace Sage_Temp_UI.ViewModels.Manage {
    public class AddPhoneNumberViewModel {
        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}
