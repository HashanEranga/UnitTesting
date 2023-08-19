using System.Net;

namespace UnitTestingProject;

public class MathClass
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Max(int a, int b)
    {
        return (a < b) ? b : a;
    }

    public IEnumerable<int> GetAllOddNumbers(int limit)
    {
        for (int i = 0; i < limit; i++)
        {
            if (i % 2 == 1) yield return i;
        }
    }
}
