using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.SOLID.S
{
    public class UserService
    {
        public void Register(User user){
            //Register user logic here

            //Send email 
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(user.Email, "Welcome to our platform"); 
        }
    }
}