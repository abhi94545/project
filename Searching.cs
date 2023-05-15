//searching program modified by Ajay Shinde
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Searching123

    {
        //Binary Search Program
        public int BinarySearch(int []arr,int f,int r,int key) 
        {
            if (f < r)
            {
                int pos = (f + r) / 2; //Dividing the array in two parts
                if (arr[pos] == key)
                    return pos;
                if (arr[pos] < key) //If key is greater than the element present at mid postion

                {
                    //Move to the right part of array
                    return BinarySearch(arr, pos + 1, r, key);
                }

                else
                {
                    //Else move to the left part of array
                    return BinarySearch(arr, f, pos - 1, key);
                }
            }
            return -1;
        }

        //Linear Search  Program
        public int LinearSearch(int[] arr, int key)
        {
           
            for (int i = 0; i < arr.Length; i++) //Iterating through the entire array
            {
                if (arr[i] == key)//Comparing each element with key
                
                    return i;
                }
            return -1;
        
        
        }

        static void Main(string[]args) {
            int[] arr = { 1, 3,67,89,95,101,123,567,789 };//Initializing the sorted array
            Searching s=new Searching();
            int t=s.LinearSearch(arr,89);
            //int t = s.BinarySearch(arr,0,arr.Length-1,567);
            Console.WriteLine("Position of given key is "+(t+1));//Printing position of the key in the array
            Console.Read();
        }
    }
}
