using System;

class Program
{
    static void Check(int[] arr, int[] indices, int k)
    {
        for (int i = 0; i < k; i++)
        {
            if (arr[indices[i]] > arr[indices[i + 1]])
            {
                return; // Reversed because of recursion
            } 
        }   
    
        for (int i = 0; i <= k; i++)
        {
            Console.Write(arr[indices[i]] + (i == k ? "\n" : " "));
        }
            
        Environment.Exit(0);
    }

    static void Combination(int[] arr, int[] indices, int k, int i, int next)
    {
        if (i > k)
        {
            return;
        }
        

        for (int j = next; j < arr.Length; j++)
        {
            indices[i] = j;

            if (i == k) Check(arr, indices, k);

            Combination(arr, indices, k, i + 1, j + 1);
        }
    }

    static void Main()
    {

        string titel = "RemoveNumbersSortArrays";
        string problem = @" Write a program that reads an array of integers and removes from it a minimal number of
elements in such way that the remaining array is sorted in increasing order. Print the remaining sorted array. 
Example:{6, 1, 4, 3, 0, 3, 6, 4, 5} à {1, 3, 3, 4, 5}";

        Console.WriteLine("Title:   " + titel + "\n" + "Problem: " + problem);

        int[] arr = new int[9] { 6, 1, 4, 3, 0, 3, 6, 4, 5 };

        //Console.WriteLine("Enter array's size:");
        //int[] arr = new int[int.Parse(Console.ReadLine())];
        //Console.WriteLine("Enter array elements:");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = int.Parse(Console.ReadLine());
        //}
         
        int[] indices = new int[arr.Length];

        for (int i = arr.Length - 1; i >= 0; i--) 
        {
            Combination(arr, indices, i, 0, 0);
        } 
    }
}
