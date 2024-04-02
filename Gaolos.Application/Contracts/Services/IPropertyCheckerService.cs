namespace Gaolos.Application.Contracts.Services;
public interface IPropertyCheckerService
{
    bool TypeHasProperties<T>(string? fields);
}
