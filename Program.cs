using System;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            //create nonfixed array
            int[] userZip = new int[5];
            //have user write a zipcode five times
            for (int i = 0; i < userZip.Length; i++)
            {
                Console.Write("Please make up and enter a zip code: ");
                userZip[i] = Convert.ToInt32(Console.ReadLine());  
            }
            //sort their answers and list them out
            Array.Sort(userZip);
            Console.WriteLine("Your zipcodes are: ");
            for(int i = 0; i < userZip.Length; i++)
            {
                Console.WriteLine("{0}", userZip[i]);
            }
            //create new variable for user new answer
            int newZip = 1;
            do
            {
                //have user enter another zipcode and store it
                Console.Write("Please enter your own zipcode (press 0 if done): ");
                newZip = Convert.ToInt32(Console.ReadLine());
                //see if zipcode matches with userZip's
                int foundZip = Array.BinarySearch(userZip, newZip);
                //if it doesn't match
                if(foundZip < 0)
                {
                    //if user didn't type 0, print out message and go back around
                    if(newZip != 0)
                    {
                        Console.WriteLine("Your zipcode was not found in your delivery route. Press enter to continue.");
                        Console.ReadLine();
                    }
                    //else exit the loop
                    else
                    {
                        Console.WriteLine("Thank you for your time. Press enter to exit.");
                        Console.ReadLine();
                    }
                }
                //else if it matches, print out message and go back around
                else
                {
                    Console.WriteLine("Your zipcode is part of your delivery route. Press enter to continue.");
                    Console.ReadLine();
                }
            } while (newZip != 0);
        }
    }
}
