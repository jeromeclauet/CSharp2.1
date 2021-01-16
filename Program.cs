using System;

namespace Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merci de renseigner votre âge.");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Vous avez " + age + " ans, vous êtes donc majeur.e.");
            }
        else
        {
                Console.WriteLine("Vous avez " + age + " ans, vous êtes donc mineur.e.");
            }
}
}
}

