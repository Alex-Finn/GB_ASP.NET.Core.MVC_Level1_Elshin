using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using WebStore.Clients.Base;

namespace WebStore.Clients.Users
{
    public class RolesClient : BaseClient, IRoleStore<IdentityRole>
    {
        public RolesClient(IConfiguration configuration) : base(configuration)
        {
            ServiceAddress = "aoi/roles";
        }

        public async Task<IdentityResult> CreateAsync(IdentityRole role, CancellationToken cancellationToken)
        {
            return await(await PostAsync(ServiceAddress, role, cancellationToken))
                .Content
                .ReadAsAsync<bool>(cancellationToken)
                ? IdentityResult.Success
                : IdentityResult.Failed();
        }

        public async Task<IdentityResult> DeleteAsync(IdentityRole role, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/Delete", role, cancellationToken))
                .Content
                .ReadAsAsync<bool>(cancellationToken)
                ? IdentityResult.Success
                : IdentityResult.Failed();
        }

        public async Task<IdentityRole> FindByIdAsync(string roleId, CancellationToken cancellationToken)
        {
            return await GetAsync<IdentityRole>($"{ServiceAddress}/FindById/{roleId}", cancellationToken);
        }

        public async Task<IdentityRole> FindByNameAsync(string normalizedRoleName, CancellationToken cancellationToken)
        {
            return await GetAsync<IdentityRole>($"{ServiceAddress}/FindByName/{normalizedRoleName}", cancellationToken);
        }

        public async Task<string> GetNormalizedRoleNameAsync(IdentityRole role, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/GetnormalizedRoleName", role, cancellationToken))
               .Content
               .ReadAsAsync<string>(cancellationToken)
               .ConfigureAwait(false);
        }

        public async Task<string> GetRoleIdAsync(IdentityRole role, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/GetRoleId", role, cancellationToken))
                .Content
                .ReadAsAsync<string>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<string> GetRoleNameAsync(IdentityRole role, CancellationToken cancellationToken)
        {
            return await(await PostAsync($"{ServiceAddress}/GetRoleName", role, cancellationToken))
                .Content
                .ReadAsAsync<string>(cancellationToken)
                .ConfigureAwait(false);

        }

        public async Task SetNormalizedRoleNameAsync(IdentityRole role, string normalizedName, CancellationToken cancellationToken)
        {
            role.NormalizedName = normalizedName;
            await PostAsync($"{ServiceAddress}/SetNormalizedRoleName/{normalizedName}", role, cancellationToken);
        }

        public async Task SetRoleNameAsync(IdentityRole role, string roleName, CancellationToken cancellationToken)
        {
            role.Name = roleName;
            await PostAsync($"{ServiceAddress}/SetRoleName/{roleName}", role, cancellationToken);
        }

        public async Task<IdentityResult> UpdateAsync(IdentityRole role, CancellationToken cancellationToken)
        {
            return await(await PutAsync(ServiceAddress, role, cancellationToken))
                .Content
                .ReadAsAsync<bool>(cancellationToken)
                ? IdentityResult.Success
                : IdentityResult.Failed();
        }
    }
}
