using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace abp.Authors
{
    public interface IAuthorAppService : IApplicationService
    {
        Task<PagedResultDto<AuthorDto>> GetListAsync(GetAuthorsInput input);

        Task<AuthorDto> GetAsync(Guid id);

        Task DeleteAsync(Guid id);

        Task<AuthorDto> CreateAsync(AuthorCreateDto input);

        Task<AuthorDto> UpdateAsync(Guid id, AuthorUpdateDto input);
    }
}