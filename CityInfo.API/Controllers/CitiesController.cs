﻿using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;


namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
            [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {            
            return Ok(CitiesDataStore.Current.Cities);
        }
        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id) 
        {
            //find city
            var cityToRetun = CitiesDataStore.Current.Cities
                .FirstOrDefault(x => x.Id == id);

            if (cityToRetun == null)
            {
                return NotFound();
            }
            return Ok(cityToRetun);
        }
    }
    
}
