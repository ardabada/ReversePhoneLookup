using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ReversePhoneLookup.Models.Requests;
using ReversePhoneLookup.Models.Responses;

namespace ReversePhoneLookup.Abstract.Services
{
    public interface ILookupService
    {
        Task<LookupResponse> LookupAsync(LookupRequest request, CancellationToken cancellationToken);
    }
}
