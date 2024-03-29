﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PharmaCoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly ILogger<FileController> _logger;
        private readonly ICouchRepository _couchRepository;
        public FileController(ILogger<FileController> logger, ICouchRepository couchRepository)
        {
            _logger = logger;
            _couchRepository = couchRepository;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] DrugDetails drugDetails)
        {
            string filePath = @"c:\FileData\Filedata.txt"; ;
            var result = await _couchRepository.WriteTextAsync(filePath, drugDetails);
            if (result.Length > 0)
            {
                // var sResult = JsonConvert.DeserializeObject<SavedResult>(result.SuccessContentObject);
                return Ok(result);
            }

            return BadRequest();
        }
    }
}
