using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRM.DBConnection.Web.Data;
using CRM.DBConnection.Web.Models;

namespace CRM.DBConnection.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignsController : ControllerBase
    {
        private CampaignsContext _context;
        public DbAccess _dbAccess { get; set; }

        //public CampaignsController(CampaignsContext context)
        //{
        //    _context = context;
        //}

        public CampaignsController(DbAccess dbAccess)
        {
            _dbAccess = dbAccess;
        }

        // GET: api/Campaigns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Campaign>>> GetCampaign()
        {
            _context = GetCampaignsContext(3);
            return await _context.Campaign.Take(10).ToListAsync();
        }

        // GET: api/Campaigns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Campaign>> GetCampaign(int id)
        {
            _context = GetCampaignsContext(3);
            var campaign = await _context.Campaign.FindAsync(id);

            if (campaign == null)
            {
                return NotFound();
            }

            return campaign;
        }

        // PUT: api/Campaigns/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCampaign(int id, Campaign campaign)
        {
            _context = GetCampaignsContext(3);

            if (id != campaign.iCampaignId)
            {
                return BadRequest();
            }

            _context.Entry(campaign).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CampaignExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Campaigns
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Campaign>> PostCampaign(Campaign campaign)
        {
            _context = GetCampaignsContext(3);

            _context.Campaign.Add(campaign);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCampaign", new { id = campaign.iCampaignId }, campaign);
        }

        // DELETE: api/Campaigns/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Campaign>> DeleteCampaign(int id)
        {
            _context = GetCampaignsContext(3);

            var campaign = await _context.Campaign.FindAsync(id);
            if (campaign == null)
            {
                return NotFound();
            }

            _context.Campaign.Remove(campaign);
            await _context.SaveChangesAsync();

            return campaign;
        }

        private bool CampaignExists(int id)
        {
            _context = GetCampaignsContext(3);
            return _context.Campaign.Any(e => e.iCampaignId == id);
        }

        private CampaignsContext GetCampaignsContext(int siteId)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CampaignsContext>();
            optionsBuilder.UseSqlServer(_dbAccess.RetrieveConnectStr(siteId));
            return new CampaignsContext(optionsBuilder.Options);
        }

    }
}
