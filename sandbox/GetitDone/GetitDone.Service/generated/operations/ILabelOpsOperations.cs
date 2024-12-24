// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// <auto-generated />

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Getitdone.Service.Models;

namespace Getitdone.Service
{

    public interface ILabelOpsOperations
    {
        Task<Label> GetPersonalLabelAsync(string labelId);
        Task<Label> UpdateLabelAsync(string labelId, UpdateLabelRequest body);
        Task DeleteLabelAsync(string labelId);

    }
}
