using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public class PrintingService
    {
        private IPrintWords _printWords;

        public PrintingService(IPrintWords printWords)
        {
            _printWords = printWords;
        }

        public string Alphabet()
        {
            return _printWords.Alphabet();
        }

        public string Repeater(string word)
        {
            return _printWords.Repeater(word);
        }

        public string RandomText(int option)
        {
            return _printWords.RandomText(option);
        }
    }
}
