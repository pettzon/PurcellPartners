using PurcellPartners_1.Extension;

namespace PurcellPartners_1.Model;

/// <summary>
/// Mock data generator
/// Creates a sequence of numbers ranging from 0 to n(count), then shuffles and removes one entry
/// </summary>
public class IntSequence : Sequence<int>
{
    public IntSequence(int count)
    {
        Random random = new Random();
        int indexToRemove = random.Next(1, count - 1); // Removing the first or the last index logically does not count as a missing number given the task
        
        for (int i = 0; i < count; i++)
        {
            if (i == indexToRemove) continue;
            
            values.Add(i);
        }

        values = values.Shuffle();
    }
}