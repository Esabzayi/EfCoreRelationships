using EfCoreRelationships.Data;
using EfCoreRelationships.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EfCoreRelationships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly DataContext _context;

        public SampleController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> createCharacter(CharacterCreateDto character)
        {
            var NewCharacter = new Character()
            {
                Name = character.Name
            };

            var backpack = new Backpack() { Description = character.BackpackCreate.Description };
            NewCharacter.Backpack = backpack;
            _context.Characters.Add(NewCharacter);

            await _context.SaveChangesAsync();

            return Ok(await _context.Characters.Include(c => c.Backpack).ToListAsync());

        }
    }
}
