using System;
using System.Collections.Generic;
namespace Core
{
    public class GenericClass<T> where T: IComparable
    {
        private T[] list;
        private int count = 0;
        private int elementsInArr;
        public GenericClass(int size)
        {
            this.list = new T[size];
            elementsInArr = size;

        }
        public void AddElement(T value)
        {
            if (count == elementsInArr)
            {
                T[] newList = new T[elementsInArr * 2];
                for (int i = 0; i < list.Length; i++)
                {
                    newList[i] = this.list[i];
                }
                this.list = newList;
            }
            list[count] = value;
            count++;
        }
        public T AccessElement(int index)
        {
            
            return list[index];
        }
        public void RemoveElementByIndex(int index)
        {
            list[index] = default(T);
        }
        public void InsertElementAtPosition(T value, int index)
        {
            list[index] = value;
        }
        public void RemoveAllElementsInList()
        {
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = default(T);
            }
        }
        public void Min<T>()
        {

        }
        public void Max<T>()
        {

        }
    }
}
