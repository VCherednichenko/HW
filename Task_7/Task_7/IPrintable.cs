using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7.Task_7
{
    public interface IPrintable
    {
        int PaperCount { get; set; }
        void Print(string content);
        void LoadPaper(int count);
    }

}
