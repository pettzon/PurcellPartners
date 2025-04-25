using PurcellPartners_1.Model;
using PurcellPartners_1.Service;
using PurcellPartners_1.Service.Implementation;

namespace PurcellPartners_1;

class Program
{
    static void Main(string[] args)
    {
        ILogger logger = new Logger();
        IFindValue<int> intFinder = new FindInt(logger); // Dependency-Inject the logger
        
        const int numberCount = 10;
        IntSequence sequence = new IntSequence(numberCount);
        
        logger.LogMessage($"Shuffled Values : {string.Join(",", sequence.values)}");
        logger.LogMessage($"Missing Value : {intFinder.FindMissingValue(sequence)}");
    }
}