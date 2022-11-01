using Dapr.Client;
using ControllerPublisher.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ControllerPublisher.Controllers
{    
    [Route("[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {

        private readonly DaprClient daprClient = new DaprClientBuilder().Build();
        
        [HttpPost]
        public async Task<ActionResult> CreateMessage(Message msg)
        {
            var eventData = new { Id = "17", Amount = 10m, };
            await daprClient.PublishEventAsync("pubsub", "deposit", eventData);

            return Ok(new { response = "Successfully published message." });
        }
    }
}
