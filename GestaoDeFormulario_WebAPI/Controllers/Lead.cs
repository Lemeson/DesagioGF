using Microsoft.AspNetCore.Mvc;
using GestaoDeFormulario_WebAPI.Data;
using GestaoDeFormulario_WebAPI.Models;

namespace GestaoDeFormulario_WebAPI.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadController : ControllerBase
    {
        private readonly IRepository repo;

        public LeadController(IRepository repo)  //maneira de fazer o aluno conversar com BD
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await this.repo.GetAllLeadsAsync();

                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: {ex.Message}");

            }
        }

        [HttpGet("{LeadId}")]
        public async Task<IActionResult> GetByLeadId(int LeadId)
        {
            try
            {
                var result = await this.repo.GetLeadsAsyncById(LeadId);

                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: {ex.Message}");

            }
        }


        [HttpPost]
        public async Task<IActionResult> Post(Lead model)
        {
            try
            {
                this.repo.Add(model);

                if(await this.repo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }

        [HttpPut("{leadsId}")]
        public async Task<IActionResult> put(int leadsId, Lead model)
        {
            try
            {
                var lead = await this.repo.GetLeadsAsyncById(leadsId);
                if(lead == null) return NotFound();

                this.repo.Update(model);

                if (await this.repo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }

        [HttpDelete("{leadId}")]
        public async Task<IActionResult> delete(int leadId)
        {
            try
            {
                var lead = await this.repo.GetLeadsAsyncById(leadId);
                if (lead == null) return NotFound();

                this.repo.Delete(lead);

                if (await this.repo.SaveChangesAsync())
                {
                    return Ok("Deletado");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }
    }
}
