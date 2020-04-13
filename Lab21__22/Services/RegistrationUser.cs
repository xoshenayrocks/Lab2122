using System;
using Lab21__22.Models;

namespace Lab21__22.Services
{
    public class RegistrationUser: IRegistrationUser

    {
        public RegistrationUser()
        {
        }

        public UserDetailsViewModel Map(RegistrationViewModel user)
        {
            var model = new UserDetailsViewModel();
            model.FirstName = user.FirstName;
            model.LastName = user.LastName;
            model.City = user.City;
            model.State = user.State;
            model.Email = user.Email;
            model.Username = user.Username;

            return model;
        }
    }
}
