using System;
using System.Collections.Generic;

namespace Utilize.Helper
{
    public static class ExHelper
    {
        public static void ForEach<T>(this IEnumerable<T> data, Action<T> action)
        {
            if(data==null) return;
            foreach (var variable in data)
            {
                action(variable);
            }
        }
    }
}
