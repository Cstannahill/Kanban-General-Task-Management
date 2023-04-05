using Sabio.Models.Requests;

namespace Sabio.Services.Interfaces
{
    public interface IEmailService
    {
        void SendContactUsEmail(ContactUsRequest model);

        void SendWelcome(EmailRequest emailRequest);

        void Confirm(string email, string token);

        void Invite(BoardInviteAddRequest inviteModel, string token);

        void ForgotPassword(string email, string token);
    }
}