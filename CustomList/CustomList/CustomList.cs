using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class CustomList<T>
    {
        private T[] arr = new T[11];
       

        public T this[int i]
        {
            get { return arr[1]; }
            set { arr[i] = value; }
        }

        private T[] items = new T[1];
        private CustomList<T> customList;

        public CustomList(CustomList<T> customList)
        {
            this.customList = customList;
        }

        //COUNT//
        public int Count(CustomList<int> index)
        {
            return index.Count();

        }
        //ADD//
        public void Add(int value)

        {
            T[] temp = new T[capacity];
            for (int i = 0; i < Count; i++)
            {
                temp[i] = items[i];
            }
            temp[Count] = value;
            Count++;
            items = temp;


        }
        //REMOVE//
        public void Remove(int value)
        {
            int[] customList = new int[customList.Length - 1];
            int i = 0;
            while (i < customList.Length)
            {
                if (i != Remove)
                {

                }
            }

        }
        /*public int [] RemoveInt(int [], CustomList, int RemoveAt)
        {
            customerList.RemoveAt(index);
        }*/






        //TO STRING//
        public void ToString()
        {

        }

        //Zip//
        public void Zip()
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            var list1AndList2 =
        }
        //Overload +//
        /*public void Overload()
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            List<int> list3 = list1 + list2
        }*/

        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            
            CustomList<T> newList = new CustomList<T>(list1 + list2);
            newList = list1 + list2;
            return newList;
        }

        //Overload -//

     
    }
}
