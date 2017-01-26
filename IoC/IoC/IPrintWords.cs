using System;

namespace IoC
{
    public interface IPrintWords
    {
        string Alphabet();
        string Repeater(string word);
        string RandomText(int option);
    }
}