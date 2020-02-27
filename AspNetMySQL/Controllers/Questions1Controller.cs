using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AspNetMySQL.Models;

namespace AspNetMySQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Questions1Controller : ControllerBase
    {
        private readonly quizContext _context;

        public Questions1Controller(quizContext context)
        {
            _context = context;
        }

        // GET: api/Questions1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Questions>>> GetQuestions()
        {
            Questions questions = new Questions
            {
                /*{"id":1,"eid":"5802790f793b1","qid":"58027e82e62e3","qns":"Have you read the README file?","choice":4,"sn":1}*/
                Eid = "5802790f793b1",
                Qid= "58027e82e62e3",
                Qns= "Have you read the README file?",
                Choice=4,
                Sn=1

            };
//            "qid":"58027e82e62e3","qns":"Have you read the README file?","choice":4,"sn":1

            _context.Questions.Add(questions);
            var q=_context.Questions.Find(1);
            q.Qns = "Updated Qustions";

            await _context.SaveChangesAsync();
            return await _context.Questions.ToListAsync();
        }

        // GET: api/Questions1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Questions>> GetQuestions(int id)
        {
            var questions = await _context.Questions.FindAsync(id);

            if (questions == null)
            {
                return NotFound();
            }

            return questions;
        }

        // PUT: api/Questions1/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuestions(int id, Questions questions)
        {
            if (id != questions.Id)
            {
                return BadRequest();
            }

            _context.Entry(questions).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionsExists(id))
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

        // POST: api/Questions1
        [HttpPost]
        public async Task<ActionResult<Questions>> PostQuestions(Questions questions)
        {
            _context.Questions.Add(questions);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuestions", new { id = questions.Id }, questions);
        }

        // DELETE: api/Questions1/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Questions>> DeleteQuestions(int id)
        {
            var questions = await _context.Questions.FindAsync(id);
            if (questions == null)
            {
                return NotFound();
            }

            _context.Questions.Remove(questions);
            await _context.SaveChangesAsync();

            return questions;
        }

        private bool QuestionsExists(int id)
        {
            return _context.Questions.Any(e => e.Id == id);
        }
    }
}
