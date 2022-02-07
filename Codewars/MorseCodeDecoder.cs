using System.Reflection.Emit;

namespace Codewars
{
    class MorseCodeDecoder
    {
        public static string Decode(string morseCode)
        {
            morseCode = ".... . -.--   .--- ..- -.. .";
            string[] wordsCoded = morseCode.Split("   ", System.StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            for (int i = 0; i < wordsCoded.Length; i++)
            {
                string[] lettersCoded = wordsCoded[i].Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < lettersCoded.Length; j++)
                    result += MorseCode.Get(lettersCoded[j]);

                if (i != wordsCoded.Length - 1)
                    result += " ";
            }

            return result;
        }
    }

    public class MorseCode
    {
        public static string Get(string str)
        {

            return str;
        }
    }

    public class Kata
    {
        public static bool IsIsogram(string str)
        {
            string loweredString = str.ToLower();

            for(int i = 0; i < loweredString.Length; i++)
                for(int j = 0; j < loweredString.Length; j++)
                {
                    if (i == j)
                        continue;

                    if (loweredString[i] == loweredString[j])
                        return false;
                }

            return true;
        }
    }

}
