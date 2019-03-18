using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebStore.DAL.Context;

namespace WebStore.ServiceHosting.Controllers
{    
    [ApiController, Route("api/[controller]"), Produces("application/json")]
    public class RolesController : ControllerBase
    {
        private readonly RoleStore<IdentityRole> _roleStore;
        public RolesController(WebStoreContext db)
        {
            _roleStore = new RoleStore<IdentityRole>(db);
        }

        [HttpPost]
        public async Task<bool> CreateAsync(IdentityRole role)
        {
            return (await _roleStore.CreateAsync(role)).Succeeded;
        }

        [HttpPut]
        public async Task<bool> UpdateAsync(IdentityRole role)
        {
            return (await _roleStore.UpdateAsync(role)).Succeeded;
        }

        [HttpPost("Delete")]
        public async Task<bool> DeleteAsync(IdentityRole role)
        {
            return (await _roleStore.DeleteAsync(role)).Succeeded;
        }

        [HttpPost("GetRoleId")]
        public async Task<string> GetRoleIdAsync(IdentityRole role)
        {
            return await _roleStore.GetRoleIdAsync(role);
        }

        [HttpPost("GetRoleName")]
        public async Task<string> GetRoleNameAsync(IdentityRole role)
        {
            return await _roleStore.GetRoleNameAsync(role);
        }

        [HttpPost("SetRoleName/{name}")]
        public async Task SetRoleNameAsync(IdentityRole role, string name)
        {
            await _roleStore.SetRoleNameAsync(role, name);
        }

        [HttpPost("GetNormalizedRoleName")]
        public async Task<string> GetNormalizedRoleNameAsync(IdentityRole role)
        {
            return await _roleStore.GetNormalizedRoleNameAsync(role);
        }

        [HttpPost("SetNormalizedRoleName/{name}")]
        public async Task SetnormalizedRoleNameAsync(IdentityRole role, string name)
        {
            await _roleStore.SetNormalizedRoleNameAsync(role, name);
        }

        [HttpGet("FindById/{id}")]
        public async Task<IdentityRole> FindByIdAsync(string id)
        {
            return await _roleStore.FindByIdAsync(id);
        }

        [HttpGet("FindByName/{name}")]
        public async Task<IdentityRole> FindByNameAsync(string name)
        {
            return await _roleStore.FindByNameAsync(name);
        }
    }
}