using System.Collections.Generic;
using System.Threading.Tasks;
using AirConditionStore.Api.Dtos.Input;
using AirConditionStore.Domain.Entities;
using AirConditionStore.Logic.Contracts;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AirConditionStore.Api.Controllers
{
    [Route("api/aircondition")]
    [ApiController]
    public class AirConditionController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IAirConditionService airConditionService;

        public AirConditionController(IMapper mapper, IAirConditionService airConditionService)
        {
            this.mapper = mapper;
            this.airConditionService = airConditionService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAirConditions()
        {
            var airConditions = await airConditionService.GetAirConditionAsync();
            var airConditionsInDto = mapper
                .Map<IEnumerable<AirCondition>, IEnumerable<AirConditionInDto>>(airConditions);

            return Ok(airConditionsInDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAirCondition(AirConditionInDto airConditionInDto)
        {
            var airCondition = mapper.Map<AirConditionInDto, AirCondition>(airConditionInDto);
            await airConditionService.CreateAirConditionAsync(airCondition);

            return Ok();
        }
        
        [HttpDelete("{name}")]
        public async Task<IActionResult> RemoveAirCondition(string name)
        {
            await airConditionService.RemoveAirCondition(name);

            return Ok();
        }
    }
}