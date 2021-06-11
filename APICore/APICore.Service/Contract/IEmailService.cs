using APICore.Domain.Settings;
using System.Threading.Tasks;

namespace APICore.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
