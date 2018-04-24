using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class BinarySearch
    {              
        public bool Search(int target, params int[] arr)
        {
            Array.Sort(arr, 0, arr.Length, new CustomComparer());

            bool found = false;
            int min = 0;
            int max = arr.Length;
            int middle = Convert.ToInt32((max - min) / 2);
            int hop = 0;
            
            try
            {
                if ((arr[0] > target) || (arr[arr.Length - 1] < target))
                {
                    throw new Exception($"Error: the target value " + target + " is out of array values");
                }

                while (!found)
                {
                    hop++;
                    if ((middle == min) && (middle == max) && (arr[middle] != target))
                    {
                        throw new Exception($"Error: the array does not contain the target value of {target}");
                    }

                    if (target > arr[middle])
                    {
                        min = middle + 1;
                        middle = Convert.ToInt32(max - (max - min) / 2);

                    }
                    else if (target < arr[middle])
                    {
                        max = middle - 1;
                        middle = Convert.ToInt32(max - (max - min) / 2);
                    }
                    else
                    {
                        found = true;
                        Console.WriteLine($"Success: {found}, target = {target}, found = {arr[middle]}, hop()s = {hop}");
                    }
                }
                
                return found;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return found;
            }
        }        
    }   

}

