using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly AuthenticationContext _context;

        public ReportsController(AuthenticationContext context)
        {
            _context = context;
        }

        // POST: api/Reports
        [Authorize]
        [HttpPost]
        public bool PostReport(Report report)
        {
            _context.Reports.Add(report);
            _context.SaveChangesAsync();

            return true;
        }
    }
}
