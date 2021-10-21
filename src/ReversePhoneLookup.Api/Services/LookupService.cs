using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ReversePhoneLookup.Abstract.Repositories;
using ReversePhoneLookup.Abstract.Services;
using ReversePhoneLookup.Models;
using ReversePhoneLookup.Models.Exceptions;
using ReversePhoneLookup.Models.Requests;
using ReversePhoneLookup.Models.Responses;

namespace ReversePhoneLookup.Api.Services
{
    public class LookupService : ILookupService
    {
        private readonly IPhoneService phoneService;
        private readonly IPhoneRepository phoneRepository;

        public LookupService(IPhoneService phoneService, IPhoneRepository phoneRepository)
        {
            this.phoneService = phoneService;
            this.phoneRepository = phoneRepository;
        }

        public async Task<LookupResponse> LookupAsync(LookupRequest request, CancellationToken cancellationToken)
        {
            string phone = phoneService.TryFormatPhoneNumber(request.Phone);
            if (!phoneService.IsPhoneNumber(phone))
                throw new ApiException(StatusCode.InvalidPhoneNumber);

            var data = await phoneRepository.GetPhoneDataAsync(phone, cancellationToken);
            if (data == null)
                throw new ApiException(StatusCode.NoDataFound);

            return new LookupResponse()
            {
                Phone = phone,
                Operator = data.Operator == null ? null : new OperatorResponse()
                {
                    Name = data.Operator.Name,
                    Code = data.Operator.Mcc + data.Operator.Mnc
                },
                Names = data.Contacts?.Select(x => x.Name).ToList()
            };
        }
    }
}
