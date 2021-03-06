using BBBL;
using BBModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BBREST.Controllers
{
    [ExcludeFromCodeCoverage]
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        private readonly IBugbearBL _bugbearBL;

        public CampaignController(IBugbearBL bugbearBL)
        {
            _bugbearBL = bugbearBL;
        }

        // GET: api/<CampaignController>
        [HttpGet]
        public async Task<IActionResult> GetCampaignsAsync()
        {
            return Ok(await _bugbearBL.GetCampaignsAsync());
        }

        // GET api/<CampaignController>/id
        [HttpGet("{id}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetCampaignByIDAsync(int id)
        {
            var campaign = await _bugbearBL.GetCampaignByIDAsync(id);
            if (campaign == null) return NotFound();
            return Ok(campaign);
        }

        // POST api/<CampaignController>
        [HttpPost]
        public async Task<IActionResult> AddACampaignAsync([FromBody] Campaign campaign)
        {
            try
            {
                await _bugbearBL.AddCampaignAsync(campaign);
                return CreatedAtAction("AddACampaign", campaign);
            }
            catch
            {
                return StatusCode(400);
            }
        }

        // PUT api/<CampaignController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCampaignAsync(int id, [FromBody] Campaign campaign)
        {
            try
            {
                await _bugbearBL.UpdateCampaignAsync(campaign);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // DELETE api/<CampaignController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCampaignAsync(int id)
        {
            try
            {
                await _bugbearBL.DeleteCampaignAsync(await _bugbearBL.GetCampaignByIDAsync(id));
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}