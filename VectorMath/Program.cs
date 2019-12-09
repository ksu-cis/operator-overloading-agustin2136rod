﻿using System;

namespace VectorMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with vectors");

            Vector3 one = new Vector3(3, 4, 5);
            Vector3 two = new Vector3(4, 8, 0);

            Console.WriteLine($"Static method Add: {Vector3.Add(one, two)}");

            Console.WriteLine($"Object method Add: {one.Add(two)}");

            Console.WriteLine($"Operator: {one + two}");

            Console.WriteLine($"Operator Subraction: {one - two}");

            Console.WriteLine($"Scalar multiplication: {2 * one}");

            Console.WriteLine($"Vector Comparison: {one == two}");

            Console.WriteLine($"Vector Comparison: {one == new Vector3(3, 4, 5)}");

            Console.WriteLine($"Preincrement: {++one}");
            Console.WriteLine($"Preincrement: {one++}");

            Console.WriteLine($"Magnitude: {~one}");

            if (Vector3.Zero)
            {
                Console.WriteLine($"{one} is Truthy");
            }
            else
            {
                Console.WriteLine($"{one} is Falsy");
            }
        }
    }
}
