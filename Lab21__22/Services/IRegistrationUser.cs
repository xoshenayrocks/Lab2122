using System;
using Lab21__22.Models;

namespace Lab21__22.Services
{
    public interface IRegistrationUser
    {
        UserDetailsViewModel Map(RegistrationViewModel user);
    }
}
