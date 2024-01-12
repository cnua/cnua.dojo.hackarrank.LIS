using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace consolehack
{
    public class Mixr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Mix(float[] source, float[] destination)
        {
            int i = 0;
            for (int c = source.Length - Vector<float>.Count; i <= c; i += Vector<float>.Count)
            {
                (new Vector<float>(source, i) + new Vector<float>(destination, i)).CopyTo(destination, i);
            }
            for (; i < source.Length; i++)
            {
                destination[i] += source[i];
            }
        }
    }
}
