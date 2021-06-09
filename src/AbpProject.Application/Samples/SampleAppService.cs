﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace AbpProject.Samples
{
    public class SampleAppService : AbpProjectAppService, ISampleAppService
    {
        public Task<SampleDto> GetAsync()
        {
            return Task.FromResult(
                new SampleDto
                {
                    Value = 4611111
                }
            );
        }

        [Authorize]
        public Task<SampleDto> GetAuthorizedAsync()
        {
            return Task.FromResult(
                new SampleDto
                {
                    Value = 42
                }
            );
        }
    }
}