using System;
using System.Collections.Generic;

namespace Crawler
{
    class Program
    {
        static void Main(string[] args)
        {
            var link = "https://ria.ru/";


            //var crawler = new Crawler.Crawler();
            //crawler.Crawl(link);

            var stemming = new Stemming(link);
            stemming.StartStemming();

            var inverter = new InvertList(link);
            inverter.Invert();
            //var search3 = inverter.Search("музей & памятники | путин");
            //foreach (var i in search3)
            //{
            //    Console.WriteLine(i);
            //}


            var tdidf = new TfIdf(link);
            tdidf.TF();
            tdidf.Idf();
            tdidf.TfIdfCalc();

            var search = new Search(link);
            search.SearchWord("американц счит себя избранными17 3327 минновостиглавн темы");


            Console.WriteLine();


        }
    }
}
