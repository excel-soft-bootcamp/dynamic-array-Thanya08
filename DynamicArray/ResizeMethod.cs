using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayProgram
{
    class ResizeMethod
    {
          public static void Resize(ref int[] oldarray, int newSize)
        {
                      
            int[] newarray= new int[newSize];
            Array.Copy(oldarray, newarray, oldarray.Length);
            oldarray = new int[newSize];
            Array.Copy(newarray, oldarray, newSize);
           
        }
    }
}
