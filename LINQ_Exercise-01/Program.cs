using System;
using System.Collections.Generic;

namespace LINQ_Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Linq Methods to choose from           

            //*BONUS*: Use any LINQ methods not in this list for an extra challenge.           

            //Where() - Filters a sequence of values based on a predicate.
            //Select() - Projects each element of a sequence into a new form.
            //OrderBy() - Sorts the elements of a sequence in ascending order.
            //OrderByDescending() - Sorts the elements of a sequence in descending order.
            //Sum() - Sums all elements
            //Average() - Calculates average of all elements
            //Count() - Returns the number of elements in a sequence.
            //Min() - Finds min value in list / sequence
            //Max() - Finds max value in list / sequence
            //Take() - Returns a specified number of contiguous elements from the start of a sequence.
            //Append() - Appends a value to the end of the sequence.
            //ThenBy() - Performs a subsequent ordering of the elements in a sequence in ascending order.

            #endregion

            var dictionaryOfStrings = new Dictionary<int, string>
            {
                { 1, "abc" },
                { 2, "def" },
                { 3, "ghi" },
                { 4, "jkl" },
                { 5, "mno" },
                { 6, "pqr" },
                { 7, "stu" },
                { 8, "vwx" },
                { 9, "yz_" },
                { 10, "111" }
            };
            
            //TODO: Using the dictionaryOfStrings above, remove the entries that contains numbers or an underscore
            //      and print the contents to the console (using a LINQ 1-Liner)



            //TODO: Using the dictionaryOfStrings above, filter out all of the entries with vowels
            //      and print the contents to the console (using a LINQ 1-Liner)


        }
    }
}
