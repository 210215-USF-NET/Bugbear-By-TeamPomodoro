using BBBL;
using BBModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BBREST.Controllers
{
    [ExcludeFromCodeCoverage]
    [Route("api/[controller]")]
    [ApiController]
    public class StoryController : ControllerBase
    {
        private readonly IBugbearBL _bugbearBL;
        public StoryController(IBugbearBL bugbearBL)
        {
            _bugbearBL = bugbearBL;
        }
        // GET: api/<StoryController>
        [HttpGet]
        public async Task<IActionResult> GetStorysAsync()
        {
            return Ok(await _bugbearBL.GetStoriesAsync());
        }

        //GET: api/<StoryController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStoryByIDAsync(int id)
        {
            var story = await _bugbearBL.GetStoryByIDAsync(id);
            if (story == null) return NotFound();
            return Ok(story);
        }

        //POST api/<StoryController>
        [HttpPost]
        public async Task<IActionResult> AddAStoryAsync([FromBody] Story story)
        {
            try
            {
                await _bugbearBL.AddStoryAsync(story);
                return CreatedAtAction("AddAStory", story);
            }
            catch
            {
                return StatusCode(400);
            }
        }

        // PUT api/<StoryController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStoryAsync(int id, [FromBody] Story story)
        {
            try
            {
                await _bugbearBL.UpdateStoryAsync(story);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // DELETE api/<StoryController>/5
        [HttpDelete("{story}")]
        public async Task<IActionResult> DeleteStoryAsync(int storyID)
        {
            try
            {
                await _bugbearBL.DeleteStoryAsync( await _bugbearBL.GetStoryByIDAsync(storyID));
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
