using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

class Word
 {
    string word;
    public int Length()
    {
        return word.Length; //return length of the word
    }

    public string convertWord(string w)
    {
        word = w.ToUpper(); // change string ot uppercase
        return word;
    }
 }

