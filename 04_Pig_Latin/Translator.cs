using System;

namespace _04_Pig_Latin
{
    internal class Translator{
        const string EXTENSION = "ay";
        internal string Translate(string v){
            string moreWords = "";
            string[] words = v.Split(' ');
            for (int i = 0; i < words.Length; i++) {
                moreWords = moreWords + " " + checkIfVowel(words[i]);
            }
            return (moreWords.Trim(' '));
        }
        internal string checkIfVowel(string w){
            string fullWord = w;
            char[] Vowels = { 'a', 'e', 'i', 'o', 'u' };
            int i = 0;
            if (!Contains(w[0], Vowels)){
                while (!Contains(w[i], Vowels)){
                    if(fullWord[0] == 'q'){
                        i--;
                    }
                    char firstLetter = fullWord[0];
                    string restWord = fullWord.Substring(1);
                    i++;
                    fullWord = restWord + firstLetter;
                }
                return fullWord + EXTENSION;
            }
            else{
                return fullWord + EXTENSION;
            }
        }
        internal bool Contains(char v, char[] x){
            int a = 0;
            for(int i = 0; i < x.Length; i++){
                if(v == x[i]){
                    a++;
                }
            }
            if(a > 0){
                return true;
            }
            else{
                return false;
            }
        }
    }
}