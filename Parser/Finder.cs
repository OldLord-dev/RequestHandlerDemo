using System;

using System.Net.Http;

namespace Parser
{
    public class Finder
    {
   string result,stringToFind;

   public Finder(String s)
{
      stringToFind=s;
}        public String find_substring(String stringToCut) {
            var split =stringToCut.Split(' ');
            
            for (int i=0;i< split.Length; i++) 
            { 
                 if (split[i].Equals(stringToFind))
                      {
                         result= split[i+ 1];
                      }
            }
        return result;
        }
    }
}