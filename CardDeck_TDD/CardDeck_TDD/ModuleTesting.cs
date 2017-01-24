using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace CardDeck_TDD
{
    class ModuleTesting
    {
        string[] testCases = new string[52];

        public ModuleTesting()
        {
            int index = 0;
            int colorIndex = 0;
            while (colorIndex < 4)
            {
                for (int i = 0; i < 13; i++)
                {
                    if (index < 9)
                    {
                        testCases[index] = "00" + (index + 1) + ":" + CardList.rank[i].CompareInput + CardList.color[colorIndex].Input + ":"
                            + CardList.rank[i].Card + " of " + CardList.color[colorIndex].Card;
                    }
                    else
                    {
                        testCases[index] = "0" + (index + 1) + ":" + CardList.rank[i].CompareInput + CardList.color[colorIndex].Input + ":"
                            + CardList.rank[i].Card + " of " + CardList.color[colorIndex].Card;
                    }
                    index++;
                }
                colorIndex++;
            }
        }

        /*public void TestStarter()
        {
            var run = new Runtime();

            string[] testCases = { "001:ac:ace of clubs" };
            string searchPath = @"C:\Users\ander\Documents\Testning av programvara\Labbar\CardDeck_TDD\testlogg.txt";

            foreach (string tc in testCases)
            {
                string[] section = tc.Split(':');
                string id = section[0];
                string cardInput = section[1];
                string expectedOutput = section[2];
                if (run.ConvertInputToCard(cardInput) == expectedOutput)
                {
                    //var addToFile = testCases + " PASS" + Environment.NewLine;
                    //File.AppendAllText(searchPath, addToFile);
                    File.AppendAllText(searchPath, id + " PASS " + Environment.NewLine);
                }
                else
                {
                    //var addToFile = testCases + " FAIL " + Environment.NewLine;
                    //File.AppendAllText(searchPath, addToFile);
                    File.AppendAllText(searchPath, id + " FAIL " + Environment.NewLine);
                }
            }
        } */

        public void StartTest()
        {
            try
            {
                Runtime run = new Runtime();
                var file = Directory.GetCurrentDirectory() + "\\module testing.txt";
                File.WriteAllText(file, "Test results:" + Environment.NewLine);
                int passedTest = 0;
                int failedTest = 0;

                foreach (var tc in testCases)
                {
                    string[] tokens = tc.Split(':');
                    string caseID = tokens[0];
                    string input = tokens[1];
                    string expected = tokens[2];
                    if (run.ConvertInputToCard(input) == expected)
                    {
                        File.AppendAllText(file, caseID + " PASS" + Environment.NewLine);
                        passedTest++;
                    }
                        
                    else
                    {
                        File.AppendAllText(file, caseID + " FAIL" + Environment.NewLine);
                        failedTest++;
                    }
                }

                File.AppendAllText(file, Environment.NewLine + "Passed tests: " + passedTest + " Falied tests: " + failedTest);

                Process process = new Process();
                process.StartInfo.FileName = "module testing.txt";
                process.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
