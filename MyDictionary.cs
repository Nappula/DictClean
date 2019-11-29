using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DictClean
{
    class MyDictionary
    {
        public List<string> wordlist { get; private set; }



        // Create lists of strings for each column of the cvs file
        // This file has nr. columns separated by a single blank
        // Some line contains an extra blank
        //  
        // 7 86711 hän (0.4925 %)
        // 8 78076 mutta (0.4434 %)
        // 98657 13 2---0 1---0 (7.3842e-05 %)
        /*
         * first and second column end with a blank
         * the third column ends before the opening parenthesis "("
         * the fourth column ends with a closing parenthesis ")"
         * 
         */


        // Load the entire word list (mydictionary) in memory
        public List<string> LoadDictionary(string myfile, string separatedby)
        {
            using (var streamdata = new StreamReader(myfile, Encoding.GetEncoding("iso-8859-1")))
            {
                string strjoiner;
                int j = 0;

                List<string> wl = new List<string>();

                while (!streamdata.EndOfStream)
                {
                    var readline = streamdata.ReadLine();

                    var values = readline.Split(separatedby);

                    // if the line has more than 3 blanks
                    // so has more than 4 columns
                   
                    j = 2;
                    //
                    strjoiner = "";
                    // I want the string contained in column 3 (having index 2) and more
                    // except the last one (index Length - 1)
                    do
                    {
                        strjoiner = strjoiner + values[j];

                        j++;

                    } while (j == (values.Length - 1));

                                      

                    wl.Add(strjoiner);
                    

                    
                }

                return wl;
            }
        }


        // Write the entire word list (mydictionary) into a file



        // Read line by line and remove numeric sequences
        // 542522 1 450/87 4 (5.6802e-06 %)
        // 542522 1 1990 54 (5.6802e-06 %)



        // open csv dictionary file
    }
}
