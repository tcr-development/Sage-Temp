using System.Threading.Tasks;

namespace Sage_Temp_UI.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
