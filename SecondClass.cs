using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    // SecondClass definition
    public class SecondClass
        {
            // Method to simulate the roll of the dice for the specified number of times
            public int[] rollingTheDice(int rollNumber)
            {
                // Array to keep track of the number of times that each combination is thrown
                int[] myArray = new int[13];

                // Variables to represent the two dice and their total
                int die1 = 0;
                int die2 = 0;
                int total = 0;

                // Random number generator for dice rolls
                Random random = new Random();

                // Loop through the specified number of rolls
                for (int roll = 0; roll < rollNumber; roll++)
                {
                    // Simulate the roll of two dice
                    die1 = random.Next(1, 7);
                    die2 = random.Next(1, 7);
                    total = die1 + die2;

                    // Update the array based on the dice roll
                    myArray[total]++;
                }

                // Return the array after all rolls
                return myArray;
            }
        }
    }


