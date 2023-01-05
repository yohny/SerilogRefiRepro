using Refit;

namespace SerilogRefiRepro.Controllers;

public interface IApi
{
    [Get("/uuid")]
    Task<UuidDto> GetUUIDAsync();
}