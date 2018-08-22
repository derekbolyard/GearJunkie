using GearJunkie.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearJunkie.Api.Controllers
{
    [Route("api/[controller]")]
    public class GearListController : Controller
    {
        private IGearListBusinessLayer gearListBusinessLayer;

        public GearListController(IGearListBusinessLayer gearListBusinessLayer)
        {
            this.gearListBusinessLayer = gearListBusinessLayer;
        }


        [HttpGet("{userId:int}")]
        public async Task<IActionResult> GetGearListsByUserId(long userId)
        {
            var result = await this.gearListBusinessLayer.GetGearListsByUserId(userId);

            if(result.Entity == null || result.Entity.Count == 0)
            {
                return this.NotFound($"No gear lists exist for user ID: {userId}");
            }

            return this.Ok(result.Entity);
        }
    }
}
