using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csApiRestful304.src.Data;
using csApiRestful304.src.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace csApiRestful304.src.controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class VideoGameController : ControllerBase
    {
        private readonly VideoGameDbContext _context;
        public VideoGameController(VideoGameDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<VideoGame>>> GetAll()
        {
            return Ok(await _context.VideoGames.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VideoGame>> GetById(int id)
        {
            var game = await _context.VideoGames.FirstOrDefaultAsync(x => x.Id == id);
            if (game == null){return NotFound();}

            return Ok(game);
        }

        [HttpPost]
        public async Task<ActionResult<VideoGame>> PostGame([FromBody] VideoGame game)
        {
            if (game == null){return BadRequest();}

            await _context.VideoGames.AddAsync(game);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = game.Id }, game);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutById(int id, [FromBody] VideoGame gameUpdate)
        {
            VideoGame? game = await _context.VideoGames.FirstOrDefaultAsync(x => x.Id == id);
            if(game == null){return NotFound();}

            game.Title = gameUpdate.Title;
            game.Plataform = gameUpdate.Plataform;
            game.Publisher = gameUpdate.Publisher;
            game.Developer = gameUpdate.Developer;

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteById(int id)
        {
            VideoGame? game = await _context.VideoGames.FirstOrDefaultAsync(x => x.Id == id);
            if (game == null){return NotFound();} 

            _context.VideoGames.Remove(game);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}