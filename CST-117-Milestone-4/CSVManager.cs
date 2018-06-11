using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_117_Milestone_4
{
    class CSVManager
    {
        public List<string[]> readCsv(string fileLocation)
        {
            List<string[]> lines = new List<string[]>();
            StreamReader reader = new StreamReader(File.OpenRead(@""+fileLocation));
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (!String.IsNullOrWhiteSpace(line))
                {
                    lines.Add(line.Split(','));
                }
            }
            reader.Close();
            return lines;
        }

        public void saveCsv(string fileLocation, List<string[]> lines)
        {
            StringBuilder csv = new StringBuilder();

            foreach(string[] line in lines)
            {
                csv.AppendLine(String.Join(",", line));
            }
            File.WriteAllText(fileLocation, csv.ToString());
        }
    }
}
