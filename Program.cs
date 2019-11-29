using System;
using System.Collections.Generic;



/* Project DictClean
 * by Michelangelo Marchesi
 * start date:   28/11/2019
 * last review:  29/11/2091
 */

/* Project specification 
 * and to do list:
 * 

//Dictionary Normalizer
// Given list of words in csv file (comma separated values)
// returns a file that has been cleaned using regular expressions
// removing errors in compilation of the list.
// The check happens on a given column of the csv file.
// The separator in the file can be decided (comma, point, space, tab)
// The file is read, precessed for trimming and number removal
// then is added an index and sorted by the given column
// Some of the features:
// - trimming non numeric and alphabetic beginners and enders (- / > (like: =d, heränneellä/, -pula-aika) deleting line if short remains
// - purely numeric lines are removed (even if contain : , . / --- + or space, ex: 55a, 90 00o:n, 1992 21, 160000:een)
// - text+num are removed (ex. tol9133, 90-luku)
// - travel routes or sport are removed (gulko---bischoff, v4---arvo, ilves---lahden)
// - url type words to be deleted (ex. http://, desc=href=http://)
// - remove words containing ~ (ex. g~nter)
// - remove words containing : (like fst:lle, usa:sa, ky:ssä, ap-dj:lle, gmbh:lta)
// - remove abitation descrition like (2h+k+wc+kph)
// - remove
//
//
//

/* Classes:
 * Dictionary methods: 
 * 
 */


namespace DictClean
{
    class Program
    {
        static void Main(string[] args)
        {
            string myfilepath = @"M:\MichelangeloMarchesi\_CodeDevelopment\source\repos\DictClean\Data\parole_frek_Fi_1339787_to_normalize.csv";
            string myseparator = " ";

            List<string> myWordList = new List<string>();

            MyDictionary xm = new MyDictionary();

            //test advice
            Console.WriteLine("Loading dictionaryfile: {0}", myfilepath);

            myWordList = xm.LoadDictionary(myfilepath, myseparator);

            // test load printing few lines

            for (int i=1; i<100; i++)
            {
                Console.Write(" {0}) " + myWordList[i * 10000] + "{1}", i*10000, ";");
            }
            Console.ReadKey();
        }
    }
}
