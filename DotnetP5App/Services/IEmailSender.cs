using MimeKit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotnetP5App.Services
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
        Task SendEmailAsync(Message message);
    }
}