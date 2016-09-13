using System;

namespace _04_Pig_Latin{
    internal class Translator{
        const string EXTENSION = "ay";
        internal string Translate(string v){
            string result;
            string finalWords = "";
            string[] words = v.Split(' ');
            for (int i = 0; i < words.Length; i++) {
                finalWords += " " + checkIfVowel(words[i]);
            }
            result = finalWords.Trim(' ');
            return result;
        }
        internal string checkIfVowel(string w){
            string result;
            string baseWord;
            string fullWord = baseWord = w;
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
                result = fullWord + EXTENSION;
            }
            else{
                result = baseWord + EXTENSION;
            }
            return result;
        }
        internal bool Contains(char v, char[] x){
            bool result;
            int a = 0;
            for(int i = 0; i < x.Length; i++){
                if(v == x[i]){
                    a++;
                }
            }
            if(a > 0){
                result = true;
            }
            else{
                result = false;
            }
            return result;
        }
    }
}