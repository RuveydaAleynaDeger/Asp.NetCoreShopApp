using System.Threading.Tasks;

namespace shopApp.webui.EmailServices
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string htmlMessage);
         
    }
}