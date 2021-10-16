using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

class WordList
{
	ArrayList words = new ArrayList();
	public bool failed;

	public WordList()
	{
		failed = false;
		FileStream inFile = null;
		StreamReader reader = null;
		try
		{
			inFile = new FileStream(@"C:\Users\ethan\source\repos\project2\project2\bin\Debug\text.txt", FileMode.Open, FileAccess.Read);//get text file from right location
			reader = new StreamReader(inFile);
			words.Add(reader.ReadLine());//add words of txt file to words
			Console.WriteLine(reader.ReadLine());
			int i = 0;
			while (words[i] != null)
			{
				words.Add(reader.ReadLine());
				Console.WriteLine(reader.ReadLine());
				i++;
			}
		}
	    catch(Exception e)
        {
			Console.WriteLine(e.Message);
        }
        finally
        {
			if (reader != null)
				reader.Close();
			if (inFile != null)
				inFile.Close();

        }
	}

	public string GetRandomWord()
    {
		Random r = new Random();
		string randomword = (string)words[r.Next(words.Count)];
		return randomword;
    }
}
