public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {

         string string1 = string.Join("", word1);
        string string2 = string.Join("", word2);

           return string1 == string2;
        
    }
}