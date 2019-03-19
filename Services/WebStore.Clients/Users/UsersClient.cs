using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using WebStore.Clients.Base;
using WebStore.DomainEntities.DTO.User;
using WebStore.DomainEntities.Entities;
using WebStore.Interfaces.Services;

namespace WebStore.Clients.Users
{
    public class UsersClient : BaseClient, IUsersClient
    {
        public UsersClient(IConfiguration configuration) : base(configuration)
        {
            ServiceAddress = "api/users";
        }

        public async Task AddClaimsAsync(User user, IEnumerable<Claim> claims, CancellationToken cancellationToken)
        {
            await PostAsync($"{ServiceAddress}/AddClaims", new AddClaimsDTO { User = user, Claims = claims }, cancellationToken);
        }

        public async Task AddLoginAsync(User user, UserLoginInfo login, CancellationToken cancellationToken)
        {
            await PostAsync($"{ServiceAddress}/AddLogin", new AddLoginDTO { User = user, UserLoginInfo = login }, cancellationToken);
        }

        public async Task AddToRoleAsync(User user, string roleName, CancellationToken cancellationToken)
        {
            await PostAsync($"{ServiceAddress}/Role/{roleName}", user, cancellationToken);
        }    

        public async Task<IdentityResult> CreateAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/User", user, cancellationToken))
               .Content
               .ReadAsAsync<bool>(cancellationToken)
               ? IdentityResult.Success
               : IdentityResult.Failed();
        }

        public async Task<IdentityResult> DeleteAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/User/Delete", user, cancellationToken))
                .Content
                .ReadAsAsync<bool>(cancellationToken)
                ? IdentityResult.Success
                : IdentityResult.Failed();
        }

        public async Task<User> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken)
        {
            return await GetAsync<User>($"{ServiceAddress}/User/FindByEmail/{normalizedEmail}", cancellationToken);
        }

        public async Task<User> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            return await GetAsync<User>($"{ServiceAddress}/User/Find/{userId}", cancellationToken);
        }

        public async Task<User> FindByLoginAsync(string loginProvider, string providerKey, CancellationToken cancellationToken)
        {
            return await GetAsync<User>($"{ServiceAddress}/User/FindByLogin/{loginProvider}/{providerKey}", cancellationToken);
        }

        public async Task<User> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            return await GetAsync<User>($"{ServiceAddress}/User/Normal/{normalizedUserName}", cancellationToken);
        }

        public async Task<int> GetAccessFailedCountAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/GetAccessFailedCount", user, cancellationToken))
               .Content
               .ReadAsAsync<int>(cancellationToken);
        }

        public async Task<IList<Claim>> GetClaimsAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/GetClaims", user, cancellationToken))
                .Content
                .ReadAsAsync<List<Claim>>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<string> GetEmailAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/GetEmail", user, cancellationToken))
               .Content
               .ReadAsAsync<string>(cancellationToken)
               .ConfigureAwait(false);
        }

        public async Task<bool> GetEmailConfirmedAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/GetEmailConfirmed", user, cancellationToken))
                  .Content
                  .ReadAsAsync<bool>(cancellationToken)
                  .ConfigureAwait(false);
        }

        public async Task<bool> GetLockoutEnabledAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/GetLockoutEnabled", user, cancellationToken))
               .Content
               .ReadAsAsync<bool>(cancellationToken);
        }

        public async Task<DateTimeOffset?> GetLockoutEndDateAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/GetLockoutEndDate", user, cancellationToken))
                .Content
                .ReadAsAsync<DateTimeOffset?>(cancellationToken);
        }

        public async Task<IList<UserLoginInfo>> GetLoginsAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/GetLogins", user, cancellationToken))
                .Content
                .ReadAsAsync<List<UserLoginInfo>>(cancellationToken);
        }

        public async Task<string> GetNormalizedEmailAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/User/GetNormalizedEmail", user, cancellationToken))
              .Content
              .ReadAsAsync<string>(cancellationToken)
              .ConfigureAwait(false);
        }

        public async Task<string> GetNormalizedUserNameAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/NormalUserName/", user, cancellationToken))
                .Content
                .ReadAsAsync<string>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<string> GetPasswordHashAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/GetPasswordHash", user, cancellationToken))
                .Content
                .ReadAsAsync<string>(cancellationToken).ConfigureAwait(false);
        }

        public async Task<string> GetPhoneNumberAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/GetPhoneNumber", user, cancellationToken))
                .Content
                .ReadAsAsync<string>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<bool> GetPhoneNumberConfirmedAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/GetPhoneNumberConfirmed", user, cancellationToken))
                .Content
                .ReadAsAsync<bool>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<IList<string>> GetRolesAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/roles", user, cancellationToken))
                .Content
                .ReadAsAsync<IList<string>>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<bool> GetTwoFactorEnabledAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/GetTwoFactorEnabled", user, cancellationToken))
                .Content
                .ReadAsAsync<bool>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<string> GetUserIdAsync(User user, CancellationToken cancellationToken)
        {
            var response = await PostAsync($"{ServiceAddress}/UserId", user, cancellationToken);
            return await response.Content
                .ReadAsAsync<string>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<string> GetUserNameAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/UserName", user, cancellationToken))
               .Content
               .ReadAsAsync<string>(cancellationToken)
               .ConfigureAwait(false);
        }

        public async Task<IList<User>> GetUsersForClaimAsync(Claim claim, CancellationToken cancellationToken)
        {
            var response = await PostAsync($"{ServiceAddress}/GetUsersForClaim", claim, cancellationToken);
            return await response
                .Content
                .ReadAsAsync<List<User>>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<IList<User>> GetUsersInRoleAsync(string roleName, CancellationToken cancellationToken)
        {
            return await GetAsync<List<User>>($"{ServiceAddress}/UsersInRole/{roleName}", cancellationToken);
        }

        public async Task<bool> HasPasswordAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/HasPassword", user, cancellationToken))
                .Content
                .ReadAsAsync<bool>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<int> IncrementAccessFailedCountAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/IncrementAccessFailedCount", user, cancellationToken))
                      .Content
                      .ReadAsAsync<int>(cancellationToken).ConfigureAwait(false);
        }

        public async Task<bool> IsInRoleAsync(User user, string roleName, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/InRole/{roleName}", user, cancellationToken))
                .Content
                .ReadAsAsync<bool>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task RemoveClaimsAsync(User user, IEnumerable<Claim> claims, CancellationToken cancellationToken)
        {
            await PostAsync($"{ServiceAddress}/RemoveClaims", new RemoveClaimsDTO { User = user, Claims = claims },
               cancellationToken);
        }

        public async Task RemoveFromRoleAsync(User user, string roleName, CancellationToken cancellationToken)
        {
            await PostAsync($"{ServiceAddress}/Role/Delete/{roleName}", user, cancellationToken);
        }

        public async Task RemoveLoginAsync(User user, string loginProvider, string providerKey, CancellationToken cancellationToken)
        {
            await PostAsync($"{ServiceAddress}/RemoveLogin/{loginProvider}/{providerKey}", user, cancellationToken);
        }

        public async Task ReplaceClaimAsync(User user, Claim claim, Claim newClaim, CancellationToken cancellationToken)
        {
            await PostAsync($"{ServiceAddress}/ReplaceClaim",
                new ReplaceClaimDTO { User = user, OldClaim = claim, NewClaim = newClaim }, cancellationToken);
        }

        public async Task ResetAccessFailedCountAsync(User user, CancellationToken cancellationToken)
        {
            await PostAsync($"{ServiceAddress}/ResetAccessFailedCont", user, cancellationToken);
        }

        public async Task SetEmailAsync(User user, string email, CancellationToken cancellationToken)
        {
            user.Email = email;
            await PostAsync($"{ServiceAddress}/SetEmail/{email}", user, cancellationToken);
        }

        public async Task SetEmailConfirmedAsync(User user, bool confirmed, CancellationToken cancellationToken)
        {
            user.EmailConfirmed = confirmed;
            await PostAsync($"{ServiceAddress}/SetEmailConfirmed/{confirmed}", user, cancellationToken);
        }

        public async Task SetLockoutEnabledAsync(User user, bool enabled, CancellationToken cancellationToken)
        {
            await PostAsync($"{ServiceAddress}/SetLockoutEnabled/{enabled}", user, cancellationToken);
        }

        public async Task SetLockoutEndDateAsync(User user, DateTimeOffset? lockoutEnd, CancellationToken cancellationToken)
        {
            user.LockoutEnd = lockoutEnd;
            await PostAsync($"{ServiceAddress}/SetLockoutEndDate",
                new SetLockoutDTO { User = user, LockOutEnd = lockoutEnd }, cancellationToken);
        }

        public async Task SetNormalizedEmailAsync(User user, string normalizedEmail, CancellationToken cancellationToken)
        {
            await PostAsync($"{ServiceAddress}/SetnormalizedEmail/{normalizedEmail}", user, cancellationToken);
        }

        public async Task SetNormalizedUserNameAsync(User user, string normalizedName, CancellationToken cancellationToken)
        {
            user.NormalizedUserName = normalizedName;
            await PostAsync($"{ServiceAddress}/NormalUserName/{normalizedName}", user, cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task SetPasswordHashAsync(User user, string passwordHash, CancellationToken cancellationToken)
        {
            await PostAsync($"{ServiceAddress}/SetPasswordHash", new PasswordHashDTO { Hash = passwordHash, User = user }, cancellationToken);
        }

        public async Task SetPhoneNumberAsync(User user, string phoneNumber, CancellationToken cancellationToken)
        {
            user.PhoneNumber = phoneNumber;
            await PostAsync($"{ServiceAddress}/SetPhoneNumber/{phoneNumber}", user, cancellationToken);
        }

        public async Task SetPhoneNumberConfirmedAsync(User user, bool confirmed, CancellationToken cancellationToken)
        {
            user.PhoneNumberConfirmed = confirmed;
            await PostAsync($"{ServiceAddress}/SetPhoneNumberConfirmed/{confirmed}", user, cancellationToken);
        }

        public async Task SetTwoFactorEnabledAsync(User user, bool enabled, CancellationToken cancellationToken)
        {
            user.TwoFactorEnabled = enabled;
            await PostAsync($"{ServiceAddress}/SetTwoFactor/{enabled}", user, cancellationToken);
        }

        public async Task SetUserNameAsync(User user, string userName, CancellationToken cancellationToken)
        {
            user.UserName = userName;
            await PostAsync($"{ServiceAddress}/UserName/{userName}", user, cancellationToken);
        }

        public async Task<IdentityResult> UpdateAsync(User user, CancellationToken cancellationToken)
        {
            return await(await PutAsync($"{ServiceAddress}/User", user, cancellationToken))
               .Content
               .ReadAsAsync<bool>(cancellationToken)
               ? IdentityResult.Success
               : IdentityResult.Failed();
        }
    }
}
