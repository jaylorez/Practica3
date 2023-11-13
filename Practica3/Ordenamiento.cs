using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practica3
{
    internal class Ordenamiento
    {
        #region Estructuras
        //Metodo para agregar elementos a una cola
        public Queue<int> ColaAgregar()
        {
            Queue<int> Cola = new Queue<int>();
            Cola.Enqueue(25);
            Cola.Enqueue(23);
            Cola.Enqueue(8);
            Cola.Enqueue(4);
            Cola.Enqueue(11);
            Cola.Enqueue(30);
            return Cola;
        }

        public void ColaOrdenar(Queue <int> A, Boolean B)
        {
            int total = A.Count;
            int[] Aux=new int[total];

            for (int i = 0; i < total; i++)
            {
                Aux[i]=A.Dequeue();
            }
            if (total!=0)
            {
                if (B)
                {
                    Quicksort(Aux, 0, total - 1);
                    for (int i = 0; i < total; i++)
                    {
                        A.Enqueue(Aux[i]);
                    }
                    for (int i = 0; i < total; i++)
                    {
                        Console.WriteLine(" {0}", A.Dequeue());
                        Thread.Sleep(2000);
                    }
                }
                else
                {
                    Quicksort(Aux, 0, total - 1);
                    int[] arregloVolteado = new int[total];

                    for (int i = 0; i < total; i++)
                    {
                        A.Enqueue(Aux[total - 1 - i]);
                    }
                    for (int i = 0; i < total; i++)
                    {
                        Console.WriteLine(" {0}", A.Dequeue());
                        Thread.Sleep(2000);
                    }
                }
            }
            else
            {
                Console.WriteLine("La cola se encuentra vacía");
            }
            
        }
        static void Apilamiento()

        {
            Stack<int> Pila = new Stack<int>();
            Pila.Push(6);
            Pila.Push(1);
            Pila.Push(7);
            Pila.Push(20);
            Pila.Push(13);
            Pila.Push(16);


        }
        public void ApilamientoOrdenar(Stack<int> A, Boolean B)
        {
            int total = A.Count;
            int[] Aux = new int[total];
            for (int i = 0; i < total; i++)
            {
                Aux[i] = A.Pop();
            }
            if (total!=0)
            {
                if (B)
                {
                    Quicksort(Aux, 0, total - 1);
                    for (int i = 0; i < total; i++)
                    {
                        A.Push(Aux[i]);
                    }
                }
                else
                {

                    int[] arregloVolteado = new int[total];

                    for (int i = 0; i < total; i++)
                    {
                        arregloVolteado[i] = Aux[total - 1 - i];
                        A.Push(arregloVolteado[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("La Pila se encuentra vacía");

            }
        }
        #endregion

        #region ordenamiento
        internal static void Quicksort(int[] A, int inicial, int final)
        {
            int i, j, central;
            double pivote;
            central = (inicial + final) / 2;
            pivote = A[central];
            i = inicial;
            j = final;
            do
            {
                while (A[i] < pivote) i++;
                while (A[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (inicial < j)
            {
                Quicksort(A, inicial, j);
            }
            if (i < final)
            {
                Quicksort(A, i, final);
            }
        }
        #endregion

    }
}
