using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.OOPPrinciples.Abstraction
{
    public class EmailService
    {
        public void SendMail(){
            Connect();
            Authenticate();
            System.Console.WriteLine("Sending email...");
            Disconnect();
        }

        private void Connect(){
            System.Console.WriteLine("Connecting to email server...");
        }

        public void Authenticate(){
            System.Console.WriteLine("Authenticating...");
        }

        public void Disconnect(){
            System.Console.WriteLine("Disconnecting from email server...");
        }
    }
}