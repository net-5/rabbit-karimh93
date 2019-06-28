using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbit
{
    
    public enum Fur
    {
        White,
        Brown,
        Black,
        Grey
    }

    public enum Eyes
    {
        Blue,
        Red,
        Black
    }
    public enum Gender
    {
        Male,
        Female
    }
    class Rabbit
    {
        public DateTime BirthDate { get; set; }
        public Eyes Eyes { get; }
        public Gender Gender { get; }
        public Fur Fur { get; }

        public DateTime Today { get; }

      
       
        

        public Rabbit(Eyes eyes,Fur fur,Gender gender,DateTime birthDate)
        {
            Eyes = eyes;
            Fur = fur;
            Gender = gender;
            BirthDate = birthDate;
           
            double diff = (int)((DateTime.Now- birthDate).TotalDays)/362.25;
           

            Console.WriteLine($"The rabbit has {Eyes} eyes,{Fur} fur,is a {Gender} and has {Math.Round(diff)} years old ");

        }

        public static void Moves()
        {
            Console.WriteLine("The rabbit has been moved");
        }
        public static void Sleeps()
        {
            Console.WriteLine("The rabbit has been sleeping");
        }
        public static void Eats()
        {
            Console.WriteLine("The rabbit has been eating");
        }
    }
}
