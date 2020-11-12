using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7LS3
{
    class BinaryHeap
    {
        int[] arr;
        int sizeOfheap;

        public BinaryHeap(int n) {

            this.arr = new int[n + 1];
            sizeOfheap = 0;
        }

        public void AddToHeap(int item) {

            sizeOfheap++;
            arr[sizeOfheap] = item;
            moveUp(sizeOfheap);
        }

        public void AddToArray(int item) {
            sizeOfheap++;
            arr[sizeOfheap] = item;
            // moveUp(sizeOfheap);
        }

        public void Swap(int x, int y) {

            int kopia = arr[x];
            arr[x] = arr[y];
            arr[y] = kopia;
        }


        public int Parent(int n) {

            return n / 2;
        }

        public int Left(int i) {

            return 2 * i;
        }
        public int Right(int i) {

            return 2 * i + 1;
        }



        public void moveUp(int i) {


            while (Parent(i) >= 1 && arr[i] > arr[Parent(i)])
            {
                Swap(i, Parent(i));
                i = Parent(i); 
            }
        }

        public void BuildMaxHeap() { 
        
            // TODO
        }

        public void moveDown(int i) {

            // inna nazwa MaxHeapify -> patrz plik heapify.jpg
        }

        public void Heapsort()
        {

            // TODO -> patrz plik hsort.jpg
        }


        public void WypiszKopiec() {

            for (int i = 1; i <= sizeOfheap; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }

    }
}
