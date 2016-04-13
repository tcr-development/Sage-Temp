using System.Threading.Tasks;

namespace Sage_Temp_UI.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
