/*
Problem Description:
Ashish has a collection of N strings, where some strings may be duplicated. 
He is tasked with finding the kth unique string from this collection. 
If the number of unique strings is less than k, return an empty string.

Input Format:
- The first line contains an integer N, which represents the number of strings.
- The next N lines each contain a string.
- The last line contains an integer k, which represents the position of the unique string to be returned.

Output Format:
- Output the kth unique string. If there are fewer than k unique strings, return an empty string.

Constraints:
- 1 <= N <= 10^3
- 1 <= String.length() <= 10^3

Approach:
1. Read the input strings and maintain their frequency of occurrence using a dictionary or hash map.
2. Extract the unique strings from the collection by filtering out duplicates.
3. If the number of unique strings is greater than or equal to k, return the kth unique string in the order of appearance.
4. If the number of unique strings is less than k, return an empty string.

Sample Test Case 0:
Input:
3
dac
ba
a
1

Output:
dac

Explanation:
All the strings in the input are unique: "dac", "ba", "a".
As k = 1, the first unique string is "dac".

Sample Test Case 1:
Input:
6
d
b
c
b
c
a
2

Output:
a

Explanation:
The distinct strings are "d" and "a" in order of appearance.
The second unique string is "a", which is returned since k = 2.
*/



using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. */
        /* Read input from STDIN. */
        /* Print output to STDOUT. */

        //The below statement reads an integer N denoting the number of strings.
        int N = Convert.ToInt32(Console.ReadLine());

        List<string> strings = new List<string>();

        //The next N lines for Reading strings and storing in List.
        for(int i=0;i<N;i++){
            strings.Add(Console.ReadLine());
        }

        //The below line reads an integer k for finding kth unique element.
        int k = Convert.ToInt32(Console.ReadLine());

        //Creating a Dictionary for storing each string with their occurences
        Dictionary<string,int> stringcount = new Dictionary<string,int>();

        //ForEach Loop for Calculating occurences of Input Strings
        foreach(string s in strings){
            if(stringcount.ContainsKey(s)){
                stringcount[s]++;
            }
            else{
                stringcount[s]=1;
            }
        }

        //List for Storing Unique Input Strings Occurences
        List<string> unique = new List<string>();

        foreach(string s in strings){
            if(stringcount[s]==1){
                unique.Add(s);
            }
        }

        //Printing kth Occurence if it Exist
        if(unique.Count >= k){
            Console.WriteLine(unique[k-1]);
        }
        else{
            Console.WriteLine("");
        }


    }
}
        

        
