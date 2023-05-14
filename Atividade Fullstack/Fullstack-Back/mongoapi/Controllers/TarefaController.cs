using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Fullstack.Models;
using Fullstack.Services;


namespace Fullstack.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly TarefaServices _tarefaServices;

        public TarefasController(TarefaServices tarefaServices)
        {
            _tarefaServices = tarefaServices;
        }

        [HttpGet]
        public async Task<List<Tarefa>> GetTarefas() =>
            await _tarefaServices.GetAsync();

        [HttpPost]
        public async Task<Tarefa> PostTarefa(Tarefa tarefa)
        {
            await _tarefaServices.CreateAsync(tarefa);

            return tarefa;
        }

        [HttpDelete]
        public async Task<Tarefa> DeleteTarefa(Tarefa tarefa)
        {
            await _tarefaServices.RemoveAsync(tarefa);

            return tarefa;
        }

    }
}
