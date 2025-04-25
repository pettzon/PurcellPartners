using PurcellPartners_1.Extension;

namespace PurcellPartners_1.Model;

public abstract class Sequence<T>
{
    public List<T> values { get; protected init; } = new List<T>();
}