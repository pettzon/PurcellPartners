namespace PurcellPartners_1.Extension;

public static class ShuffleValues
{
    /// <summary>
    /// Extension method to shuffle all elements of type T in list. Can be reworked into ICollection / IEnumerable
    /// </summary>
    /// <param name="values"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> Shuffle<T>(this List<T> values)
    {
        Random random = new Random();
        List<T> shuffled = new List<T>();
        
        int iterations = values.Count;
        
        for (int i = 0; i < iterations; i++)
        {
            int index = random.Next(0, values.Count);
            T value = values[index];
            
            values.RemoveAt(index);
            shuffled.Add(value);
        }

        return shuffled;
    }
}