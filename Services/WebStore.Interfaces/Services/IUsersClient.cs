using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using WebStore.DomainEntities.Entities;

namespace WebStore.Interfaces.Services
{
    public interface IUsersClient :
        IUserRoleStore<User>,
        IUserClaimStore<User>,
        IUserPasswordStore<User>,
        IUserPhoneNumberStore<User>,
        IUserTwoFactorStore<User>,
        IUserEmailStore<User>,
        IUserLoginStore<User>,
        IUserLockoutStore<User>
    {
    }
}
