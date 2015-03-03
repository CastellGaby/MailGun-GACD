using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailgun_GACD
{
    class Program
    {
        static void Main(string[] args)
        {
            String Destinatario, email;
            Console.WriteLine("Introduzca el Destinatario:");
            Destinatario = Console.ReadLine();
            Console.WriteLine("Introduzca la dirección electronica:");
            email = Console.ReadLine();
            MailSender.SendSimpleMessage(Destinatario, email);
        }
    }
}
