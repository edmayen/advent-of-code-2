﻿using System;

namespace Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] {1,12,2,3,1,1,2,3,1,3,4,3,1,5,0,3,2,6,1,19,1,19,9,23,1,23,9,27,1,10,27,31,1,13,31,35,1,35,10,39,2,39,9,43,1,43,13,47,1,5,47,51,1,6,51,55,1,13,55,59,1,59,6,63,1,63,10,67,2,67,6,71,1,71,5,75,2,75,10,79,1,79,6,83,1,83,5,87,1,87,6,91,1,91,13,95,1,95,6,99,2,99,10,103,1,103,6,107,2,6,107,111,1,13,111,115,2,115,10,119,1,119,5,123,2,10,123,127,2,127,9,131,1,5,131,135,2,10,135,139,2,139,9,143,1,143,2,147,1,5,147,0,99,2,0,14,0};
            Console.WriteLine("\n");
            Console.WriteLine("__________________________");
            Console.WriteLine("\n");
            Console.WriteLine("Day 2: 1202 Program Alarm.");
            Console.WriteLine("\n");
            Console.WriteLine("__________________________");
            Console.WriteLine("\n\n");
            Intcode(input);
        }

        public static void Intcode(int[] input)
        {
            int i = 0;
            int exit = 0;
            int aux = 0;
            int val1= 0;
            int val2 = 0; 
            int val3 = 0;
            do{
                if(input[i] == 1)
                {
                    val1 = input[i+1];
                    val2 = input[i+2];
                    val3 = input[i+3];
                    aux = input[val1] + input[val2];
                    input[val3] = aux;
                }
                else
                if(input[i] == 2)
                {
                    val1 = input[i+1];
                    val2 = input[i+2];
                    val3 = input[i+3];
                    aux = input[val1] * input[val2];
                    input[val3] = aux;
                }
                i = i + 4;
                exit = input[i];
            }while(exit != 99);
            Console.WriteLine("Response: " + input[0]);
        }
    }
}
