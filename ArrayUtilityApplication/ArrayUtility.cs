using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayUtilityApplication
{
    public static class ArrayUtility
    {
        public static void Resize(ref int[] array, int newSize)
        {

            int[] newarray = new int[newSize];
            Array.Copy(array, newarray, array.Length);
            array = newarray;





        }

    }

}
