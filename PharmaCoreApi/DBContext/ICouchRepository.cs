﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaCoreApi.Models
{
    public interface ICouchRepository
    {
        Task<HttpClientResponse> PostDocumentAsync(PharmaDetails pharmaDetails);
        Task<HttpClientResponse> PutDocumentAsync(UpdatePharmaDetails update);
        Task<HttpClientResponse> GetDocumentAsync(string id);
        Task<HttpClientResponse> DeleteDocumentAsync(string id, string rev);
        Task<string> WriteTextAsync(string filePath, DrugDetails drugDetails);
    }
}
