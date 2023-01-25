using System.Threading.Tasks;

namespace HackerNews.Model;

public interface INavigation
{
    Task NavigateAsync(ILazyLoadable lazyLoadable);
    Task BackAsync();
}