using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, surname;
            int age;
            float height, weight;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            surname = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your height(cm): ");
            height = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter your weight(kg): ");
            weight = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(name + " " + surname + " is " + age + " years old, " + "his weight is " + weight + " kg." + " and his height is " + height + " cm.");
            height /= 100;
            float bmi = weight / (height * height);
            Console.WriteLine("BMI: " + bmi);

        }
    }
}
