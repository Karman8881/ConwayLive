using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace live2.engine
{
    internal class Controller
    {
        public Model model = new Model(64, 64, 10);
        

        public System.Collections.ArrayList clean()
        {
            for (int i = 0; i < model.width; i++)
                for (int j = 0; j < model.height; j++)
                {
                    model.a[i, j] = 0;
                    model.b[i, j] = 0;
                }
            return new System.Collections.ArrayList();

        }
        public System.Collections.ArrayList random()
        {
            for (int i = 0; i < 100; i++)
            {
                var randRow = new Random();
                var randCol = new Random();
                model.a[randCol.Next(0, 64), randRow.Next(0, 64)] = 1;
            }

            return getCells();
        }

        public System.Collections.ArrayList getCells()
        {
            System.Collections.ArrayList result = new System.Collections.ArrayList();
            for (int col = 0; col < model.width; col++)
                for (int row = 0; row < model.height; row++)
                {
                    if (model.a[col, row] == 1)
                        result.Add(new Cell(col, row));
                }

            return result;
        }
        public System.Collections.ArrayList step()
        {
            for (int col = 0; col < model.height; col++)
            {
                for (int row = 0; row < model.width; row++)
                {
                    int n =
                      model.a[prev(col), prev(row)]
                    + model.a[prev(col), row]
                    + model.a[prev(col), next(row)]
                    + model.a[col, prev(row)]
                    + model.a[col, next(row)]
                    + model.a[next(col), prev(row)]
                    + model.a[next(col), row]
                    + model.a[next(col), next(row)];

                    if (model.a[col, row] == 1)
                        model.b[col, row] = (n == 2 || n == 3) ? 1 : 0;
                    else
                        model.b[col, row] = (n == 3) ? 1 : 0;
                }
            }
            
            model.a = model.b;
            
            model.b = new int[model.height, model.width];
            Null();
            return getCells();
        }
        private int prev(int v)
        {
            return v == 0 ? 63 : v - 1;
        }
        private int next(int f)
        {
            return f == 63 ? 0 : f + 1;
        }
        private void Null()
        {
            for (int i = 0; i < model.width; i++)
                for (int j = 0; j < model.height; j++)
                {
                    model.b[i, j] = 0;
                }
        }
        public System.Collections.ArrayList Invers(int x, int y)
        {
            int col = x / model.sqaureSize;
            int row = y / model.sqaureSize;
            model.a[col, row] = model.a[col, row] == 1 ? 0 : 1;
            return getCells();
        }

        
    }
}

