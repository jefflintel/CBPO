using CBPO.Data;
using CBPO.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBPO.Controllers
{
    [Route("checklist")]
    public class ChecklistController : Controller
    {

        //dependency injection
        private readonly ApplicationDbContext _context;
        private readonly ILogger _logger;
        private readonly UserManager<IdentityUser> _userManager;

        /*[Route("new")]
        public JsonResult Checklist (string SerialNumber, string Brand, string Model, string Color)
        {
            IdentityUser user = Task.Run(async () => { return await _userManager.GetUserAsync(HttpContext.User); }).Result;

            _context.Add(new Checklist
            {
                SerialNumber = SerialNumber,
                Brand = Brand,
                Model = Model,
                Color = Color,
                CleanInspectForCracks = "Not Started",
                GreaseSeatpost = "Not Started",
                InspectForCracksBends = "Not Started",
                GreaseStem = "Not Started",
                RepackBottomBracket = "Not Started",
                GreasePedalThreads = "Not Started",
                CableAdjustFrontDer = "Not Started",
                CableAdjustRearDer = "Not Started",
                CheckChainStretch = "Not Started",
                CleanOilChain = "Not Started",
                CableAdjustFrontBrake = "Not Started",
                CableAdjustRearBrake = "Not Started",
                RepackFrontHub = "Not Started",
                TrueFrontWheel = "Not Started",
                RepackRearHub = "Not Started",
                TrueRearWheel = "Not Started",
                InflateTires = "Not Started",
                TiresHoldingAir = "Not Started",
                AccurateShifting = "Not Started",
                GoodBraking = "Not Started",
                RidingClassCompleted = "Not Started",
                StartDate = DateTime.Now,
                NumOfDays = 1

            });
            _context.SaveChanges();
            return new JsonResult(new
            {
                Status = true
            });
        }

        [HttpPost("update")]
        public JsonResult Checklist(string CleanInspectForCracks, string GreaseSeatpost, string InspectForCracksBends, string GreaseStem, string RepackBottomBracket, string GreasePedalThreads,
            string CableAdjustFrontDer, string CableAdjustRearDer, string CheckChainStretch, string CleanOilChain, string CableAdjustFrontBrake, string CableAdjustRearBrake, string RepackFrontHub,
            string TrueFrontWheel, string RepackRearHub, string TrueRearWheel, string InflateTires, string TiresHoldingAir, string AccurateShifting, string GoodBraking, string RidingClassCompleted)
        {
            IdentityUser user = Task.Run(async () => { return await _userManager.GetUserAsync(HttpContext.User); }).Result;

            Checklist list = _context.Checklists
                .

            _context.Add(new Checklist
            {
                CleanInspectForCracks = CleanInspectForCracks,
                GreaseSeatpost = GreaseSeatpost,
                InspectForCracksBends = InspectForCracksBends,
                GreaseStem = GreaseStem,
                RepackBottomBracket = RepackBottomBracket,
                GreasePedalThreads = GreasePedalThreads,
                CableAdjustFrontDer = CableAdjustFrontDer,
                CableAdjustRearDer = CableAdjustRearDer,
                CheckChainStretch = CheckChainStretch,
                CleanOilChain = CleanOilChain,
                CableAdjustFrontBrake = CableAdjustFrontBrake,
                CableAdjustRearBrake = CableAdjustRearBrake,
                RepackFrontHub = RepackFrontHub,
                TrueFrontWheel = TrueFrontWheel,
                RepackRearHub = RepackRearHub,
                TrueRearWheel = TrueRearWheel,
                InflateTires = InflateTires,
                TiresHoldingAir = TiresHoldingAir,
                AccurateShifting = AccurateShifting,
                GoodBraking = GoodBraking,
                RidingClassCompleted = RidingClassCompleted,
                
            });
            _context.SaveChanges();
            return new JsonResult(new
            {
                Status = true
            });
        }*/
    }
}
