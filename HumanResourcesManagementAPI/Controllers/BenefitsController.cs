﻿using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;
using Microsoft.AspNetCore.Mvc;

namespace HumanResourcesManagementAPI.Controllers
{
    public class BenefitsController : Controller<Benefits>
    {
        public BenefitsController(IRepository<Benefits> repository) : base(repository)
        {
        }
    }
}
