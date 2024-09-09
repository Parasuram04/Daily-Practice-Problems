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
        

        