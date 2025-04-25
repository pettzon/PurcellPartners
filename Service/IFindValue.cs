using PurcellPartners_1.Model;

namespace PurcellPartners_1.Service;

/// <summary>
/// Interface for generic type return to provide extensibility. Implementations determine how missing value(s) are found
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IFindValue<T>
{
    public T FindMissingValue(Sequence<T> sequence);
    public HashSet<T> FindMissingValues(Sequence<T> sequence);
}