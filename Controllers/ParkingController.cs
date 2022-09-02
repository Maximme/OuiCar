using OuiCar.Domain;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Net.Http.Headers;

namespace OuiCar.Controllers
{
    [ApiController]
    [EnableCors("agilus-web-app")]
    [Route("/parking")]
    public class ParkingController : ControllerBase
    {
        private readonly HttpClient _client = new();

        public ParkingController(HttpClient? client = null)
        {

            if (client != null) _client = client;
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        [HttpGet("poitiers")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesErrorResponseType(typeof(ProblemDetails))]
        public async Task<ActionResult<List<PoitiersRecord>>> GetPoitiers()
        {
            string urlParameters = "https://data.grandpoitiers.fr/api/records/1.0/search/?dataset=mobilites-stationnement-des-parkings-en-temps-reel&q=";
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, urlParameters);
                HttpResponseMessage? httpResponse = await _client.SendAsync(request);

                PoitiersParkingDTO? parkingDTO = await httpResponse.Content.ReadFromJsonAsync<PoitiersParkingDTO>();

                if(parkingDTO == null) return NotFound();

                return parkingDTO.records == null ? NotFound() : Ok(parkingDTO.records);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("larochelle")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesErrorResponseType(typeof(ProblemDetails))]
        public async Task<ActionResult<List<PoitiersRecord>>> GetLaRochelle()
        {
            string urlParameters = "https://d4c.agglo-larochelle.fr/api/3/action/datastore_search?resource_id=1f69980c-20df-4604-b9f7-c83c7d91b859";
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, urlParameters);
                HttpResponseMessage? httpResponse = await _client.SendAsync(request);

                RochelleParkingDTO? parkingDTO = await httpResponse.Content.ReadFromJsonAsync<RochelleParkingDTO>();

                if (parkingDTO == null) return NotFound();

                return parkingDTO.result.records == null ? NotFound() : Ok(parkingDTO.result.records);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}