// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// <auto-generated />

using System;
using System.Net;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Getitdone.Service.Models;
using Getitdone.Service;

namespace Getitdone.Service.Controllers
{
    [ApiController]
    public abstract partial class SectionOpsOperationsControllerBase : ControllerBase
    {

        internal abstract ISectionOpsOperations SectionOpsOperationsImpl { get; }


        [HttpGet]
        [Route("/sections/{section_id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Section))]
        public virtual async Task<IActionResult> GetSection(string sectionId)
        {
            var result = await SectionOpsOperationsImpl.GetSectionAsync(sectionId);
            return Ok(result);
        }


        [HttpPost]
        [Route("/sections/{section_id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Section))]
        public virtual async Task<IActionResult> UpdateSection(string sectionId, UpdateSectionRequest body)
        {
            var result = await SectionOpsOperationsImpl.UpdateSectionAsync(sectionId, body);
            return Ok(result);
        }


        [HttpDelete]
        [Route("/sections/{section_id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent, Type = typeof(void))]
        public virtual async Task<IActionResult> DeleteSection(string sectionId)
        {
            await SectionOpsOperationsImpl.DeleteSectionAsync(sectionId);
            return Ok();
        }

    }
}
