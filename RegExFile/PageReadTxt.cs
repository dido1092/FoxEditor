using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegExFile
{
    public class PageReadTxt
    {
        //private readonly int pageSize;
        private string filePath;

        public PageReadTxt(string filePath)
        {
            this.filePath = filePath;
            //this.pageSize = pageSize;
        }

        public List<string> GetPages()
        {
            using (var reader = new StreamReader(filePath))
            {
                List<string> pageContent = new List<string>();
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line == "")
                    {
                        continue;
                    }

                    pageContent.Add(line + "\n");
                    //pageContent.Add("\n");
                }

                return pageContent;
            }
        }
    }
}
