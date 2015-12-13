using System.Collections.Generic;

internal class ETL
{
    public static IDictionary<string, int> Transform(Dictionary<int, IList<string>> old)
    {
        var refactoredList = new Dictionary<string, int>();

        foreach (var pair in old)
            foreach (var item in pair.Value)
                refactoredList.Add(item.ToLower(), pair.Key);

        return refactoredList;
    }
}