namespace JohannaCMS.Business.Services.Interfaces;

public interface IDescendantService
{
    IEnumerable<T> GetDescendantsOfType<T>(PageData pageData) where T : class;
}