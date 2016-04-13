using System.ComponentModel.DataAnnotations;

namespace Sage_Temp_UI.ViewModels.Account {
    public class ForgotPasswordViewModel {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
