using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestSounds
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Asterisk");
            SystemSounds.Asterisk.Play();
            Thread.Sleep(1000);

            Console.WriteLine("Beep");
            SystemSounds.Beep.Play();
            Thread.Sleep(1000);

            Console.WriteLine("Exclamation");
            SystemSounds.Exclamation.Play();
            Thread.Sleep(1000);

            Console.WriteLine("Hand");
            SystemSounds.Hand.Play();
            Thread.Sleep(1000);

            //Console.WriteLine("Question");
            //SystemSounds.Question.Play();
            //Thread.Sleep(1000);
        }
    }
}
