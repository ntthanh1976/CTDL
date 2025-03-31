using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToanSapXep
{
    interface ISortAlgorithms
    {
        void Input();
        void Output();
        void InterchageSort(int[] a, int n); //thuat toan doi cho truc tiep
        void SelectionSort(int[] a, int n); //thuat toan chon truc tiep       
        void InsertionSort(int[] a, int n); //thuat toan chon chen tiep
        void BubbleSort(int[] a, int n); //thuat toan chon noi bot
        void QuickSort(int[] a, int left, int right);
    }

    class MyArray : ISortAlgorithms
    {
        public int[] data;
        public MyArray(int size)
        {
            data = new int[size];
        }

        public void BubbleSort(int[] a, int n)
        {
            throw new NotImplementedException();
        }

        public void Input()
        {
            //cai dat nhap gia tri phan tu cho mang data
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write("Nhap gia tri phan tu thu {0}:", i);
                data[i] = int.Parse(Console.ReadLine());
            }
        }

        public void InsertionSort(int[] a, int n)
        {
            throw new NotImplementedException();
        }

        public void InterchageSort(int[] a, int n)
        {
            int tmp;
            for (int i = 0; i <n -1 ; i++)
            {
                for (int j = i+1 ; j < n; j++)
                {
                    if (a[i]>a[j])
                    {
                        tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }  
            }
        }

        public void Output()
        {
            //cai dat lenh xuat cac phan tu mang
            foreach (var x in data)
            {
                Console.Write("{0}  ", x);
            }
        }

        public void QuickSort(int[] a, int left, int right)
        {
            throw new NotImplementedException();
        }

        public void SelectionSort(int[] a, int n)
        {
            throw new NotImplementedException();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cho biet so phan tu mang:");
            int n = int.Parse(Console.ReadLine());
            MyArray myArr = new MyArray(n);
            
            myArr.Input();
            Console.WriteLine("Mang ban dau:");
            myArr.Output();

            //test thuat toan sap xep doi cho truc tiep
            myArr.InterchageSort(myArr.data, n);
            Console.WriteLine("\nMang sau khi sap xep:");
            myArr.Output();

            Console.ReadLine();
            
        }
    }
}
