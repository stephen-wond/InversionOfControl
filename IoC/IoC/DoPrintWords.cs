namespace IoC
{
    public class DoPrintWords : IPrintWords
    {
        public string Alphabet()
        {
            return "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
        }

        public string Repeater(string word)
        {
            return (word + word + word);
        }

        public string RandomText(int option)
        {
            switch (option)
            {
                case 1:
                    return "A suspected tourist whistles with the broadcast passport. Her impossible offender ducks beneath a singing keeper. Why can't the authorized wren orbit in a head? How can my stamped perspective run on top of a foreigner?";
                case 2:
                    return "Into the nine surname reckons the solo interference. The blanket steams!The magnetic nut primes a scheme in the exposed wind.My manifesto crawls throughout the terminator. Above the lifetime arrives the regarding annoyance.Can a reluctance shout?";
                case 3:
                    return "The stare pops? A human alien mounts the peer. The palace elaborates past the squeeze! The inform paper grinds against the gossip. The important boss leaps in the nice attribute.";
                default:
                    return "only accepts 1-3";
            }
        }
    }
}