namespace IoC
{
    class DontPrintWords : IPrintWords
    {
        public string Alphabet()
        {
            return "Not printing words";
        }

        public string Repeater(string word)
        {
            return ("Not going to do anything with your word " + word);
        }

        public string RandomText(int option)
        {
            switch (option)
            {
                case 1:
                    return "Case 1 of the switch statement";
                case 2:
                    return "Case 2 of the switch statement";
                case 3:
                    return "Case 3 of the switch statement";
                default:
                    return "only accepts 1-3";
            }
        }
    }
}