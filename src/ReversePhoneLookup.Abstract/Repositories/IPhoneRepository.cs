using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ReversePhoneLookup.Api.Models.Entities;

namespace ReversePhoneLookup.Abstract.Repositories
{
    public interface IPhoneRepository
    {
        Task<Phone> GetPhoneDataAsync(string phone, CancellationToken cancellationToken);
    }
}
