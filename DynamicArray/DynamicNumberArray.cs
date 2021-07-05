using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayProgram
{
    public class DynamicNumberArray
    {
        public  int[] buffer;

        public DynamicNumberArray()
        {
            buffer = new int[5];
        }
        public DynamicNumberArray(int initialSize)
        {
            buffer = new int[initialSize];
        }

        public int this[int index]
        {
            set
            {
               if(index>=buffer.Length)
                {
                    ResizeMethod.Resize(ref buffer, buffer.Length+1);
                }

                buffer[index] = value;
            }
            get
            {
                return buffer[index];
            }
        }   
    }
}
     






















