//déclaration des variables
tempMin = 35.2m;
tempMax = 40.4m;
etatPerso = "en forme";
dead = false;
tempPerso;

Console.WriteLine("Saisissez votre température (ex: 37,4): \n");
//Récupération de la saisie utilisateur
saisie = Console.ReadLine();

//On teste si l'utilisateur a saisi un décimal
if (Decimal.TryParse(saisie, out tempPerso))
{
    //si la température du perso est inférieure ou égale à la température minimum
    //ou si la température du perso est supérieure ou égale à la température maximum
    //alors le perso est mort
    if ()
    {
        dead = true;
    }
    //sinon si la température du perso est strictement inférieure à 36
    //ou si la température du perso est strictement supérieure à 38.5
    else if ()
    {
        etatPerso = "bien malade";
        Console.WriteLine();
    }
    //sinon si la température du perso est strictement inférieure à 36.6
    //ou si la température du perso est strictement supérieure à 37.4
    else if ()
    {
        etatPerso = "un peu malade";
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine();
    }
    
    //question 4
}
else
{
    Console.WriteLine("Saisissez un nombre décimal avec la virgule comme séparateur");
}






