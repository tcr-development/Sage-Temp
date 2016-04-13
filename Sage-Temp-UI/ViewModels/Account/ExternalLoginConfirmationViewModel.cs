using System.ComponentModel.DataAnnotations;

namespace Sage_Temp_UI.ViewModels.Account {
    public class ExternalLoginConfirmationViewModel {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
