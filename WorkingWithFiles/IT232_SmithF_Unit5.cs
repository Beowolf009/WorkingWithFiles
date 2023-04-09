using System.Collections;
using System.IO;
using System;

namespace WorkingWithFiles
{
    internal class IT232_SmithF_Unit5
    { /**********************************************************************************************************
                                                                        Assignment 5 Section 1
       ****************************************************************************************************/
        #region Section 1
     
        static void Main(string[] args)
        {

            // shows linecount as int from function FileLineCount                                                      

            ArrayList produceList = new ArrayList();

            // Adding data to the produce list.
            produceList.Add("bananas 0.59");
            produceList.Add("grapes 2.99");
            produceList.Add("apples 1.49");
            produceList.Add("pears 1.39");
            produceList.Add("lettuce 0.99");
            produceList.Add("onions 0.79");
            produceList.Add("potatoes 0.59");
            produceList.Add("peaches 1.59");

            using (StreamWriter writer = new StreamWriter(@"ProducePrice.txt"))                              //streamwriter to make the file ProducePrice
            {
                foreach (string p in produceList)
                {                    
                    writer.WriteLine(p);                   
                }
            }
            int lineCount = FileLineCount(@"ProducePrice.txt");
            Console.WriteLine($"The file has {lineCount} lines.");

            /*********************************************************************************************************************
                                                                                  Assignment 5 Section 2
           **********************************************************************************************************************/


            using (StreamWriter append = new StreamWriter(@"ProducePrice.txt", true))                              //streamwriter to append the file ProducePrice
            {
                append.WriteLine("peppers 0.99");
                append.WriteLine("celery 1.29");
                append.WriteLine("cabbage 0.79");
                append.WriteLine("tomatoes 1.19");

            }
            int appendlineCount = FileLineCount(@"ProducePrice.txt");
            Console.WriteLine($"The file has {appendlineCount} lines.");
            static int FileLineCount(string fileName)                                                            //funtion that that loops through a file to count the objects in the file
            {
                int count = 0;
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (reader.ReadLine() != null)
                    {
                        count++;
                    }
                }
                return count;
            }

            ArrayList ProducePrices = new ArrayList();
           using (StreamReader reader = new StreamReader(@"ProducePrice.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null){
                    ProducePrices.Add(line);
                }
            }

            for (int i = 0; i < ProducePrices.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {ProducePrices [i] }" );
            }


            #endregion

          


        }

    }
}