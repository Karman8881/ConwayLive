using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace live2.engine
{
    public class Model
    {
        public int height;
        public int width;
        public int sqaureSize;
        public int[,] a;
        public int[,] b;

        public Model(int width, int height, int sqaureSize) {
            this.width = width;
            this.height = height;
            this.sqaureSize = sqaureSize;

            a = new int[height, width];
            b = new int[height, width];

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    a[i, j] = 0;
                    b[i, j] = 0;
                }


        }

    }

}
