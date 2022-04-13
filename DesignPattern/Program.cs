using DesignPattern;

Chat minou = new Chat();
Chien medor = new Chien();
Chien lacy = new Chien();
Facteur monFacteur = new Facteur();
string[] Couleur = new string[] {"Bleu", "Rouge", "Vert", "Violet", "Noire"};

minou.Miauler();
medor.Mordre(monFacteur);
minou.Dormir();
medor.Dormir();
medor.Manger();

if (minou.estAffame)
{
    minou.Manger();
}
else
{
    Console.WriteLine("Le chat n'a pas faim");
}

foreach(string a in Couleur)
{
    Console.Write(a + " ");
}
