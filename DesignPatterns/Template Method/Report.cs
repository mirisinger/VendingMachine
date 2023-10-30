using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template_Method
{
    public abstract class Report
    {
        string filePath = @"..\..\..\..\Daily Reports";
        string newFilePath;
        public Report()
        {
        }
        public abstract void InsertToFile(string data, Form1 form);
        public abstract void WriteData(string data);
        public void CreateFile(string FileType)
        {
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            DateTime currentDate = DateTime.Now.Date;
            newFilePath = $@"{filePath}\{DateTime.Now:dd_MM_yy}.{FileType}";
            if (!File.Exists(newFilePath))
            {
                File.Create(newFilePath);
            }
            WriteData(newFilePath);
        }
    }
}
