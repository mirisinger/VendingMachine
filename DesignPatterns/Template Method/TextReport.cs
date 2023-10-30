using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DesignPatterns.Template_Method
{
    public class TextReport : Report
    {
        string data;
        public TextReport()
        {
        }
        Form1 form;
        public override void InsertToFile(string data, Form1 form)
        {
            this.form = form;
            this.data = data;
            CreateFile("txt");
        }
        public override void WriteData(string NewFilePath)
        {
            using (StreamWriter writer = new StreamWriter(NewFilePath, true))
            {
                string[] words = data.Split(' ');
                string productName = words[0];
                string data2 = "At " + DateTime.Now + "\n" + data;
                writer.WriteLine(data2);
                writer.Close();
                MessageBox.Show($"The {productName} product was successfully registered in the report!");
            }
        }
    }
}
