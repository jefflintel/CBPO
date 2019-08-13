using CBPO.Data;
using CBPO.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBPO.Controllers
{
    [Route("demographics")]
    public class DemographicsController : Controller
    {
        //dependency injection
        private readonly ApplicationDbContext _context;
        private readonly ILogger _logger;
        private readonly UserManager<IdentityUser> _userManager; 

        public DemographicsController (ApplicationDbContext context, ILogger<DemographicsController> logger, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;
        }

        [HttpPost("new")]
        public JsonResult NewEarner (string FirstName, string LastName, string StreetAddress, string City, string State, int Zip)
        {
            IdentityUser user = Task.Run(async () => { return await _userManager.GetUserAsync(HttpContext.User); }).Result;

            _context.Add(new Demographics
            {
                FirstName = FirstName,
                LastName = LastName,
                StreetAddress = StreetAddress,
                City = City,
                State = State,
                Zip = Zip
            });
            _context.SaveChanges();
            return new JsonResult(new
            {
                Status = true
            });
        }

        [HttpPost("new-youth")]
        public JsonResult NewYouth(string School, string GuardianEmail, string GuardianPhone, string ReducedLunch)
        {
            IdentityUser user = Task.Run(async () => { return await _userManager.GetUserAsync(HttpContext.User); }).Result;

            _context.Add(new Demographics
            {
                School = School,
                ParentGuardianEmail = GuardianEmail,
                ParentGuardianPhone = GuardianPhone,
                ReducedLunch = ReducedLunch
            });
            _context.SaveChanges();
            return new JsonResult(new
            {
                Status = true
            });
        }

        [HttpPost("new-adult")]
        public JsonResult NewAdult(int Income, string Employer)
        {
            IdentityUser user = Task.Run(async () => { return await _userManager.GetUserAsync(HttpContext.User); }).Result;

            _context.Add(new Demographics
            {
                Income = Income,
                Employer = Employer
            });
            _context.SaveChanges();
            return new JsonResult(new
            {
                Status = true
            });
        }

        [HttpPost("demographics/location")]
        public JsonResult LocationData()
        {
            IdentityUser user = Task.Run(async () => { return await _userManager.GetUserAsync(HttpContext.User); }).Result;
            List<Demographics> zips = _context.Demographics
                .Include(z => z.Zip)
                .Where

            return new JsonResult(new
            {
                
            })
        }
    }
        

}
