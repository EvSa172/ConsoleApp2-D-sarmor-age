
// Programme qui simule un système de désamorçage de bombe. L'utilisateur doit deviner un code secret entre 1 et 20

class Program
{
    static void Main()
    {
        int codeSecret = new Random().Next(1, 21);
        int tentative;

        do
        {
            Console.Write("Votre tentative : ");
            tentative = int.Parse(Console.ReadLine());

            if (tentative < codeSecret)
            {
                Console.WriteLine("[ALERTE] Code trop bas ! Accès restreint.");
            }
            else if (tentative > codeSecret)
            {
                Console.WriteLine("[ALERTE] Code trop haut ! Surcharge détectée.");
            }
            else
            {
                Console.WriteLine("[SUCCÈS] Porte déverrouillée, bon travail agent !");
            }

        } while (tentative != codeSecret);
    }
}