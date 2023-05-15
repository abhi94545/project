using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Sort23
    {
        //Sorting through Bubble Sort for array of integers
        public void BubbleSorting(int[] arr) 
        {
            for (int i = 0; i < arr.Length - 1; i++) //Loop running till second last position
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1]) //Comparing values present at  consecutive position in given array
                    {
                        int temp = arr[j];  //Swapping of two values
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }
                }
            }
           }


        //Sorting through Bubble Sort for array of strings
        public void BubbleSorting(string[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)//Loop running till second last position
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (String.Compare(arr[j],arr[j + 1])>0)//Comparing values present at consecutive position in given array
                    {
                        string temp = arr[j]; //Swapping of two values
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }
                }
            }
           
        }

        //Sorting through Insertion Sort for array of integers
        public void InsertionSorting(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i]; 
                int j = i - 1;//Assuming Array before index i is already sorted 
                while (j >= 0 && key < arr[j])//Comparing key value with the value present in array
                {
                    arr[j + 1] = arr[j]; //Overriding the larger value
                    j--;
                }
                arr[j + 1] = key;//Inserting key at the right position

            }
           
        }

        //Sorting through Insertion Sort for array of strings
        public void InsertionSorting(string[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                string key = arr[i];
                int j = i - 1; //Assuming Array index i is already sorted
                while (j >= 0 && (String.Compare(key,arr[j])<0)) //Comparing key value with the value present in array
                {
                    arr[j + 1] = arr[j]; //Overriding the larger value
                    j--;
                }
                arr[j + 1] = key;//Inserting key at the right position
            }
            
        }

        //Sorting through Selection Sort for array of integers
        public void SelectionSorting(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int small = arr[i];// Finding smallest element of the remaining array
                int pos = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < small)
                    {
                        small = arr[j];
                        pos = j;

                    }
                }
                int temp = arr[i];//Swapping the element at i with the smallest element of the array
                arr[i] = small;
                arr[pos] = temp;
            }
        }

        //Sorting through Selection Sort for array of Strings
        public void SelectionSorting(string[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                string small = arr[i]; //Finding smallest string lexicographically from the remaining array
                int pos = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (String.Compare(arr[j],small)<0)
                    {
                        small = arr[j];
                        pos = j;

                    }
                }
                string temp = arr[i];//Swapping the smallest string with the string present at index i
                arr[i] = small;
                arr[pos] = temp;
            }
        }



        //Sorting through Merge Sort for array of integers
        public void MergeSort(int f, int r, int[] arr)
        {
            if (f < r)
            {
                int mid = (f + r) / 2;//Dividing the array in two parts
                MergeSort(f, mid, arr); //Calling MergeSort function recursively on left array
                MergeSort(mid + 1, r, arr);//Calling MergeSort function recursively on right array
                 //Merging the two Sorted arrays
                int[] temp = new int[r - f + 1];
                int i = f, j = mid + 1, k = 0;
                while (i <= mid && j <= r)
                {
                    if (arr[i] < arr[j])
                    {
                        temp[k] = arr[i];
                        i++;
                        k++;
                    }
                    else
                    {
                        temp[k] = arr[j];
                        k++;
                        j++;

                    }
                }
                while (i <= mid)
                {
                    temp[k] = arr[i];
                    i++;
                    k++;
                }
                while (j <= r)
                {
                    temp[k] = arr[j];
                    j++;
                    k++;

                }


                for (k = 0; k < temp.Length; k++)
                    arr[f + k] = temp[k];
            }
        }

        //Sorting through quick sort for array of integers
        public void quickSort(int[] arr, int left, int right)
        {  
            if (left >= right)
                return;
            int temp;
            // arr[left] is pivot
            int i = left, j = right;
            while (i < j)
            {
                while (i <= right && arr[i] <= arr[left])
                    i++;
                while (arr[j] > arr[left])
                    j--;
                if (i < j)
                {   //Swapping the elements
                     temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
             temp = arr[left];
            arr[left] = arr[j];
            arr[j] = temp;
            quickSort(arr, left, j - 1);//Calling quickSort recursively on left part of the array
            quickSort(arr, j + 1, right);//Calling quickSort recursively on right part of the array
        }

    


 public static void Main(string []args) {
            int[] arr = { 3, 45, 6, 90, 7, 43, 78 }; //initializing the integer array
            string[] sarr = { "rohan", "puneet", "ashish","nihar","akaar" }; //initializing the string array
            Sort sort = new Sort();
            // sort.MergeSort(0,arr.Length-1,arr);
            // sort.quickSort(arr,0,arr.Length-1);
            // sort.BubbleSorting(arr);
            //sort.InsertionSorting(arr);
            sort.SelectionSorting(arr);
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);

            sort.SelectionSorting(sarr);
            //Printing sorted string array

            for (int i = 0; i < sarr.Length; i++)
                Console.WriteLine(sarr[i]);

            Console.Read();



        }
    }
}
