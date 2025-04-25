using PurcellPartners_1.Model;

namespace PurcellPartners_1.Service.Implementation;

public class FindInt : IFindValue<int>
{
    private readonly ILogger logger;
    public FindInt(ILogger logger)
    {
        this.logger = logger;
    }
    
    /// <summary>
    /// Optionally FindMissingValue and FindMissingValues would be merged together and always return an array/list of entries, with an optional parameter of how
    /// many missing values you want to search for
    /// </summary>
    /// <param name="sequence"></param>
    /// <returns></returns>
    public int FindMissingValue(Sequence<int> sequence)
    {
        List<int> sortedValues = sequence.values.OrderBy(x => x).ToList();
        
        logger.LogMessage($"Sorted Values : {string.Join(",", sortedValues)}");
        
        for (int i = 0; i < sortedValues.Count; i++)
        {
            if (i == sortedValues[i]) continue;
            return i;
        }

        return -1;
    }

    public HashSet<int> FindMissingValues(Sequence<int> sequence)
    {
        List<int> sortedValues = sequence.values.OrderBy(x => x).ToList();
        HashSet<int> missingValues = new HashSet<int>();

        for (int i = 0; i < sortedValues.Count; i++)
        {
            if (i == sortedValues[i]) continue;
            missingValues.Add(i);
        }

        return missingValues;
    }
}