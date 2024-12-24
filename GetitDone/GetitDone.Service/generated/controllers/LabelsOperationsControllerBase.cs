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
    public abstract partial class LabelsOperationsControllerBase : ControllerBase
    {

        internal abstract ILabelsOperations LabelsOperationsImpl { get; }


        [HttpGet]
        [Route("/labels")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Label[]))]
        public virtual async Task<IActionResult> GetPersonalLabels()
        {
            var result = await LabelsOperationsImpl.GetPersonalLabelsAsync();
            return Ok(result);
        }


        [HttpPost]
        [Route("/labels")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(Label))]
        public virtual async Task<IActionResult> CreateLabel(CreateLabelRequest body)
        {
            var result = await LabelsOperationsImpl.CreateLabelAsync(body);
            return Ok(result);
        }

    }
}