using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w6
{
    class LetterDemo
    {
        static void Main(string[] args)
        {
            Letter letter = new Letter();
            CertifiedLetter certifiedLetter = new CertifiedLetter();

            letter.ClientName = "John Smith";
            letter.ClientName = "02/02/2020";

            certifiedLetter.ClientName = "Another Smith";
            certifiedLetter.ClientName = "03/02/2020";
            certifiedLetter.TrackingNum = 123456789;

            Console.WriteLine(letter.ToString());
            Console.WriteLine(certifiedLetter.ToString() + "Number: " + certifiedLetter.TrackingNum);
        }
    }
}
