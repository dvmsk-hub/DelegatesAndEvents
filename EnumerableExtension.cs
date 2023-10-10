namespace DelegatesAndEvents;


public static class EnumerableExtension
{
    /// <summary>
    /// Метод расширения
    /// </summary>
    public static float GetMax<T>(this IEnumerable<T> e, Func<T, float> getParameter) where T : class
    {
        var maxElement = float.MinValue;
        
        foreach (var element in e)
        {
            var parameter = getParameter(element);
            if (parameter > maxElement)
                maxElement = parameter;
        }        

        return maxElement;
    }
}