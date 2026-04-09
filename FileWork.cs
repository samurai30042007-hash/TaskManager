using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class FileWork
    {
        static internal async Task<string> ImportFile(string filePath)
        {
            using (StreamReader fs = new StreamReader(filePath))
            {
                return await fs.ReadToEndAsync();
            }
        }
        static internal async Task SaveFile(string filePath, string json)
        {
            using (StreamWriter fs = new StreamWriter(filePath))
            {
                await fs.WriteAsync(json);
            }
        }
    }
}
