using Activities.Domain;
using System.Threading.Tasks;

namespace Activities.Service.Contract
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
