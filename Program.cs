﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Regestration Using Regex");
            UserRegestration userRegestration = new UserRegestration();
            Console.WriteLine("Enter Your First Name :");
            string FirstName = Console.ReadLine();
            Console.WriteLine(userRegestration.ValidateFirstName(FirstName));

        }

    }
}
