using System;
using Task_01_04_2022.Models;

namespace Task_01_04_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel("Hotel Elite");
            Room rm = new Room("01", 12, 5);
            Room rm2 = new Room("03", 34, 7);
            hotel.AddRoom(rm);
          
            hotel.AddRoom(rm2);
        

            Console.WriteLine(rm);

            Console.WriteLine(rm2);
            hotel.Reserve(2);
            Console.WriteLine(hotel[0]);
        }
    }
}
