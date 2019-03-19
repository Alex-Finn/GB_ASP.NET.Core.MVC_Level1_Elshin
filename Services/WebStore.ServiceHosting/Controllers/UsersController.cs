using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebStore.DAL.Context;
using WebStore.DomainEntities.DTO.User;
using WebStore.DomainEntities.Entities;

namespace WebStore.ServiceHosting.Controllers
{
    [ApiController, Route("api/[controller]"), Produces("application/json")]
    public class UsersController : ControllerBase
    {
        private readonly UserStore<User> _userStore;
        public UsersController(WebStoreContext db)
        {
            _userStore = new UserStore<User>(db)
            {
                AutoSaveChanges = true
            };
        }

        [HttpPost("UserId")]
        public async Task<string> GetUserIdAsync([FromBody] User user)
        {
            return await _userStore.GetUserIdAsync(user);
        }

        [HttpPost("UserName")]
        public async Task<string> GetUserNameAsync([FromBody] User user)
        {
            return await _userStore.GetUserNameAsync(user);
        }

        [HttpPost("UserName/{name}")]
        public async Task SetUserNameAsync([FromBody] User user, string name)
        {
            await _userStore.SetUserNameAsync(user, name);
        }

        [HttpPost("NormalUserName")]
        public async Task<string> GetNormalizedUserNameAsync([FromBody] User user)
        {
            return await _userStore.GetNormalizedUserNameAsync(user);
        }

        [HttpPost("NormalUserName/{name}")]
        public async Task SetNormalizedUserNameAsync([FromBody] User user, string name)
        {
            await _userStore.SetNormalizedUserNameAsync(user, name);
        }

        [HttpPost("User")]
        public async Task<bool> CreateAsync([FromBody] User user)
        {
            return (await _userStore.CreateAsync(user)).Succeeded;
        }

        [HttpPut("User")]
        public async Task<bool> UpdateAsync([FromBody] User user)
        {
            return (await _userStore.UpdateAsync(user)).Succeeded;
        }

        [HttpPost("User/Delete")]
        public async Task<bool> DeleteAsync([FromBody] User user)
        {
            return (await _userStore.DeleteAsync(user)).Succeeded;
        }

        [HttpGet("User/Find/{id}")]
        public async Task<User> FindByIdAsync(string id)
        {
            return await _userStore.FindByIdAsync(id);
        }

        [HttpGet("User/Normal/{name}")]
        public async Task<User> FindByNameAsync(string name)
        {
            return await _userStore.FindByNameAsync(name);
        }

        [HttpPost("Role/{role}")]
        public async Task AddToRoleAsync([FromBody] User user, string role)
        {
            await _userStore.AddToRoleAsync(user, role);
        }

        [HttpPost("Role/Delete/{role}")]
        public async Task RemoveFromRoleAsync([FromBody] User user, string role)
        {
            await _userStore.RemoveFromRoleAsync(user, role);
        }

        [HttpPost("Roles")]
        public async Task<IList<string>> GetRolesAsync([FromBody] User user)
        {
            return await _userStore.GetRolesAsync(user);
        }

        [HttpPost("InRole/{role}")]
        public async Task<bool> IsInRoleAsync([FromBody] User user, string role)
        {
            return await _userStore.IsInRoleAsync(user, role);
        }

        [HttpGet("UsersInRole/{role}")]
        public async Task<IList<User>> GetUsersInRoleAsync(string role)
        {
            return await _userStore.GetUsersInRoleAsync(role);
        }

        [HttpPost("GetPasswordHash")]
        public async Task<string> GetPasswordHashAsync([FromBody] User user)
        {
            return await _userStore.GetPasswordHashAsync(user);
        }

        [HttpPost("SetPasswordHash")]
        public async Task<string> SetPasswordHashAsync([FromBody] PasswordHashDTO hash)
        {
            await _userStore.SetPasswordHashAsync(hash.User, hash.Hash);
            return hash.User.PasswordHash;
        }

        [HttpPost("HasPassword")]
        public async Task<bool> HasPasswordAsync([FromBody] User user)
        {
            return await _userStore.HasPasswordAsync(user);
        }

        [HttpPost("GetClaims")]
        public async Task<IList<Claim>> GetClaimsAsync([FromBody] User user)
        {
            return await _userStore.GetClaimsAsync(user);
        }

        [HttpPost("AddClaims")]
        public async Task AddClaimsAsync([FromBody] AddClaimsDTO claimInfo)
        {
            await _userStore.AddClaimsAsync(claimInfo.User, claimInfo.Claims);
        }

        [HttpPost("ReplaceClaims")]
        public async Task ReplaceClaimAsync([FromBody] ReplaceClaimDTO claimInfo)
        {
            await _userStore.ReplaceClaimAsync(claimInfo.User, claimInfo.OldClaim, claimInfo.NewClaim);
        }

        [HttpPost("RemoveClaims")]
        public async Task RemoveClaimsAsync([FromBody] RemoveClaimsDTO claimInfo)
        {
            await _userStore.RemoveClaimsAsync(claimInfo.User, claimInfo.Claims);
        }

        [HttpPost("GetUsersForClaim")]
        public async Task<IList<User>> GetUsersForClaimAsync([FromBody] Claim claim)
        {
            return await _userStore.GetUsersForClaimAsync(claim);
        }

        [HttpPost("GetTwoFactorEnabled")]
        public async Task<bool> GetTwoFactorEnabledAsync([FromBody] User user)
        {
            return await _userStore.GetTwoFactorEnabledAsync(user);
        }

        [HttpPost("SetTwoFactor/{enable}")]
        public async Task SetTwoFactorEnabledAsync([FromBody] User user, bool enable)
        {
            await _userStore.SetTwoFactorEnabledAsync(user, enable);
        }

        [HttpPost("GetEmail")]
        public async Task<string> GetEmailAsync([FromBody] User user)
        {
            return await _userStore.GetEmailAsync(user);
        }

        [HttpPost("SetEmail/{email}")]
        public async Task SetEmailAsync([FromBody] User user, string email)
        {
            await _userStore.SetEmailAsync(user, email);
        }

        [HttpPost("GetEmailConfirmed")]
        public async Task<bool> GetEmailConfirmedAsync([FromBody] User user)
        {
            return await _userStore.GetEmailConfirmedAsync(user);
        }

        [HttpPost("SetEmailConfirmed/{enable}")]
        public async Task SetEmailConfirmedAsync([FromBody] User user, bool enable)
        {
            await _userStore.SetEmailConfirmedAsync(user, enable);
        }

        [HttpGet("UserFindByEmail/{email}")]
        public async Task<User> FindByEmailAsync(string email)
        {
            return await _userStore.FindByEmailAsync(email);
        }

        [HttpPost("GetNormalizedEmail")]
        public async Task<string> GetNormalizedEmailAsync([FromBody] User user)
        {
            return await _userStore.GetNormalizedEmailAsync(user);
        }

        [HttpPost("SetEmail/{email}")]
        public async Task SetNormalizedEmailAsync([FromBody] User user, string email)
        {
            await _userStore.SetNormalizedEmailAsync(user, email);
        }

        [HttpPost("GetPhoneNumber")]
        public async Task<string> GetPhoneNumberAsync([FromBody] User user)
        {
            return await _userStore.GetPhoneNumberAsync(user);
        }

        [HttpPost("SetPhoneNumber/{phone}")]
        public async Task SetPhoneNumberAsync([FromBody] User user, string phone)
        {
            await _userStore.SetPhoneNumberAsync(user, phone);
        }

        [HttpPost("GetPhoneNumberConfirmed")]
        public async Task<bool> GetPhoneNumberConfirmedAsync([FromBody] User user)
        {
            return await _userStore.GetPhoneNumberConfirmedAsync(user);
        }

        [HttpPost("SetPhoneNumberConfirmed/{confirmedPhone}")]
        public async Task SetPhoneNumberConfirmedAsync([FromBody] User user, bool confirmedPhone)
        {
            await _userStore.SetPhoneNumberConfirmedAsync(user, confirmedPhone);
        }

        [HttpPost("AddLogin")]
        public async Task AddLoginAsync([FromBody] AddLoginDTO login)
        {
            await _userStore.AddLoginAsync(login.User, login.UserLoginInfo);
        }

        [HttpPost("RemoveLogin/{loginProvider}/{providerKey}")]
        public async Task RemoveLoginAsync([FromBody] User user, string loginProvider, string providerKey)
        {
            await _userStore.RemoveLoginAsync(user, loginProvider, providerKey);
        }

        [HttpPost("GetLogins")]
        public async Task<IList<UserLoginInfo>> GetLoginsAsync([FromBody] User user)
        {
            return await _userStore.GetLoginsAsync(user);
        }

        [HttpGet("User/FindByLogin/{loginProvider}/{providerKey}")]
        public async Task<User> FindByLoginAsync(string loginProvider, string providerKey)
        {
            return await _userStore.FindByLoginAsync(loginProvider, providerKey);
        }

        [HttpPost("GetLockoutEndDate")]
        public async Task<DateTimeOffset?> GetLockoutEndDateAsync([FromBody] User user)
        {
            return await _userStore.GetLockoutEndDateAsync(user);
        }

        [HttpPost("SetLockoutEndDate")]
        public async Task SetLockoutEndDateAsync([FromBody] SetLockoutDTO lockoutInfo)
        {
            await _userStore.SetLockoutEndDateAsync(lockoutInfo.User, lockoutInfo.LockOutEnd);
        }

        [HttpPost("IncrementAccessFailedCount")]
        public async Task<int> IncrementAccessFailedCountAsync([FromBody] User user)
        {
            return await _userStore.IncrementAccessFailedCountAsync(user);
        }

        [HttpPost("ResetAccessFailedCount")]
        public async Task ResetAccessFailedCountAsync([FromBody] User user)
        {
            await _userStore.ResetAccessFailedCountAsync(user);
        }

        [HttpPost("GetAccessFailedCount")]
        public async Task<int> GetAccessFailedCountAsync([FromBody] User user)
        {
            return await _userStore.GetAccessFailedCountAsync(user);
        }

        [HttpPost("GetLockoutEnabled")]
        public async Task<bool> GetLockoutEnabledAsync([FromBody] User user)
        {
            return await _userStore.GetLockoutEnabledAsync(user);
        }

        [HttpPost("SetLockoutEnabled/{enable}")]
        public async Task SetLockoutEnabledAsync([FromBody] User user, bool enable)
        {
            await _userStore.SetLockoutEnabledAsync(user, enable);
        }
    }
}