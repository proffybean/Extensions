using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class ArrayExtensions
    {
        public static double Average(this int[] myArray)
        {
            double sum = 0;
            for (int i=0; i<myArray.Length; i++)
            {
                sum += myArray[i];
            }

            return sum/myArray.Length;
        }

        public static void ForEachItem<T>(this T[] arr, Action<T> action)
        {
            for(int i=0; i< arr.Length; i++)
            {
                action(arr[i]);
            }
        }

        public static T[] Reverse<T>(this T[] myArray)
        {
            T[] tempArray = new T[myArray.Length];
            int length = myArray.Length;

            for (int i=0; i<length; ++i)
            {
                tempArray[i] = myArray[length - 1 - i];
            }

            return tempArray;
        }

        public static char[] Reverse(this char[] myCharArray)
        {
            Stack<char> myStack = new Stack<char>();

            foreach(char c in myCharArray)
            {
                myStack.Push(c);
            }

            for(int i=0; i<myCharArray.Length; ++i)
            {
                myCharArray[i] = myStack.Pop();
            }
            
            return myCharArray;
        }

        public static T[] ReverseWithStack<T>(this T[] array)
        {
            Stack<T> stack = new Stack<T>();

            foreach(T c in array)
            {
                stack.Push(c);
            }

            for(int i=0; i<array.Length; ++i)
            {
                array[i] = stack.Pop();
            }

            return array;
        }

        public static T[] ReverseWithForeachLoop<T>(this T[] arr)
        {
            Stack<T> stack = new Stack<T>();

            Array.ForEach(arr, x => stack.Push(x));

            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = stack.Pop();
            }

            return arr;
        }

        public static T[] ReverseWithForEachItemExtension<T>(this T[] arr)
        {
            Stack<T> stack = new Stack<T>();

            arr.ForEachItem(x => stack.Push(x));

            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = stack.Pop();
            }

            return arr;
        }
    }
}
