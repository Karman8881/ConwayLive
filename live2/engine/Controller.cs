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

            for (int i = 0; i < model.height; i++)
            {
                for (int j = 0; j < model.width; j++)
                {
                    /*int n = 0;
                    n = n + model.a[--i, --j];
                    n = n + model.a[--i, j];
                    n = n + model.a[--i, ++j];
                    n = n + model.a[i, --j];
                    n = n + model.a[i, ++j];
                    n = n + model.a[++i, --j];
                    n = n + model.a[++i, j];
                    n = n + model.a[++i, ++j];*/
                    
                    

                    if (model.a[i, j] == 0)
                    {
                        if (prev(model.a[i, j]) == 3)
                        {
                            model.b[i, j] = 1;
                        }
                    }
                    else
                    {
                        if (next(model.a[i, j]) == 3 || next(model.a[i, j]) == 2)
                        {
                            model.b[i, j] = 1;
                        }
                    }

                }
            }
            model.a = model.b;
            Null();
            return getCells();
        }
        private int prev(int v)
        {
            return v == 0 ? 63 : v - 1;
        }
        private int next(int f)
        {
            return f == 0 ? 63 : f + 1;
        }
        private static void Null()
        {
            for (int i = 0; i < model.width; i++)
                for (int j = 0; j < model.height; j++)
                {
                    model.b[i, j] = 0;
                }
        }
    }
}

