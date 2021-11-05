using Aemo_test_project.Model.Dto;
using Aemo_test_project.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Aemo_test_project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StringComparisonController : ControllerBase
    {
        private readonly ILogger<StringComparisonController> _logger;
        private readonly IStringIndex _stringIndex;

        public StringComparisonController(ILogger<StringComparisonController> logger, IStringIndex stringIndex)
        {
            _logger = logger;
            _stringIndex = stringIndex;
        }

        [HttpGet("{Text}/{SubText}")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(Object), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Object>> GetStringIndex([FromRoute] RequestDto request)
        {
            try
            {
                return await _stringIndex.GetStringIndex(request.Text, request.SubText);
            
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Internal server error: {ex}");
            }
        }
    }
}
