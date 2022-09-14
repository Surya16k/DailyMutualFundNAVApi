using DailyMutualFundNAV.Models;
using DailyMutualFundNAV.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyMutualFundNAV.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MutualFundNAVController : ControllerBase
    {
        private readonly IMutualFundRepository mutualFundRepository;
       
        public MutualFundNAVController(IMutualFundRepository _mutualFundRepository)
        {
            mutualFundRepository = _mutualFundRepository;
        }
        [HttpGet]
        [Route("mutualfundname")]
        public IActionResult GetMutualFundByName(string mutualfundname)
        {
           
                if (mutualfundname == null)
                {
                    return BadRequest();
                }
                var mutualFundData = mutualFundRepository.GetMutualFundByNameRepository(mutualfundname);
                if (mutualFundData == null)
                {
                    return BadRequest();
                }
                return Ok(mutualFundData);

            
        }
        [HttpGet]
        public ActionResult GetAllMutualFund()
        {
            var l = mutualFundRepository.GetAllmutualFund();
            return Ok(l);


        }


    }
}
