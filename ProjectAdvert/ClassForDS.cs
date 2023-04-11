using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAdvert
{
    internal class ClassForDS
    {
        public static T DeserializeObj<T>()
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == true)
            {
                string json = File.ReadAllText(open.FileName);
                T obj = JsonConvert.DeserializeObject<T>(json);
                return obj;
            }
            else { return default(T); }
        }
    }
}
