﻿using System;
using System.Diagnostics;
using Xunit;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int number1, int number2)
        {
            return number1 == number2;
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;

        }

        public int Add(int number1, int number2)
            {
                return number1 + number2;
            }

            public int GetSmallestNumber(int number1, int number2)
            {
                return number1 < number2 ? number1 : number2;
                
                //if (number1 < number2)
                //{
                //    return number1;
                //}
                //return number 2;
            }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            //if (nameOfPerson == "")
            //{
            //    return "Hello";
            //}
            //else
            //   return $"Hello, {nameOfPerson}";
            //}

            return string.IsNullOrEmpty(nameOfPerson) ? "Hello!" : $"Hello, {nameOfPerson}!";
        }

        public string GetHey() => "HEY!";
        //{
        //    return "HEY!"
        //}
    }
}
