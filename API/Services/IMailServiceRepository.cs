using API.Authentication;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public interface IMailServiceRepository
    {
        Task SendEmailAsync(string toEmail, string subject, string content);
        Task<RegistrationResponse> ForgetPasswordAsync(ApplicationUser applicationUser);
        Task<RegistrationResponse> ResetPasswordAsync(PasswordReset model);

        //Task<RegistrationResponse> ConfirmEmailAsync(string userId, string token);
    }
}
