namespace Assignment6_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 6.1.1
            //==============

            //SIngle linked list 
            //Class house
            //properties house number, etc
            int[] arr = { 0, 1, 0, 3, 12 };
            Console.WriteLine("Assignment 6.1.3");
            Console.WriteLine("==============\n");

            Console.WriteLine("Original array:");
            PrintArray(arr);

            int[] modifiedArr = MoveZerosToEnd(arr);

            Console.WriteLine("\nModified Array:");
            PrintArray(modifiedArr);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public class House
        {
            public int HouseId { get; set; }
            public int HouseNumber { get; set; }
            public string StreetName { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }
            public string Country { get; set; }
            public HouseStyle HouseStyle { get; set; }

        }

        public enum HouseStyle
        {
            colonial,
            ranch,
            victorian
        }

        public class Node
        {
            public House Data { get; set; }
            public Node Next { get; set; }

            public Node(House house)
            {
                Data = house;
                Next = null;
            }
        }

        public class LinkedList
        {
            public Node Head { get; set; }
            public int Length { get; set; }


            public House FindHouse(int houseNumber)
            {
                // Implement a search algorithm to find a house in the list
                // based on house number, street name, city, state, zip code, country, or house style
                Node current = Head;
                while (current != null)
                {
                    if (current.Data.HouseNumber == houseNumber)
                    {
                        return current.Data;
                    }
                    current = current.Next;
                }
                return null; // Return null if not found
            }
        }

        //Reviewd better method to implement
        public static int[] MoveZerosToEnd(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    // Swap arr[count] and arr[i]
                    int temp = arr[count];
                    arr[count] = arr[i];
                    arr[i] = temp;
                    count++;
                }
            }
            return arr;
        }
    }
}
