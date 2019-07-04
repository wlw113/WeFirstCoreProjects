using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeFirstCoreProject.Application.Interface;
using WeFirstCoreProject.Model;
using WeFirstCoreProject.Model.Entitys;

namespace WeFirstCoreProject.Api.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private readonly IProjectService<SystemUserInfo> _systemUserInfoService;

        public LoginController(IProjectService<SystemUserInfo> systemUserInfo)
        {
            _systemUserInfoService = systemUserInfo;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> AdminLogin(int id)
        {
            var model = await this._systemUserInfoService.GetByProjectId(id);
            return Ok(model);
        }
    }
}