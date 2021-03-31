using Microsoft.AspNetCore.Mvc;
using SocialMedia.Core.Interfaces;
using System.Threading.Tasks;

namespace SocialMedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicationsController : ControllerBase
    {
        private readonly IPublicationsRepository _publicationsRepository;
        public PublicationsController(IPublicationsRepository publicationsRepository)
        {
            _publicationsRepository = publicationsRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetPublications()
        {
            var publication = await _publicationsRepository.GetPublicacions();
            return Ok(publication);
        }
    }
}
