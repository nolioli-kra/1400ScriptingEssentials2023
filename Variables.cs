using System;

public class VariablesProgram
{
    public Monster godzilla;
    public NuclearEnergy warhead;

    public void Main()
    {
        godzilla = new Monster();
        warhead = new NuclearEnergy();

        godzilla.godzillaSpeed += warhead.nukeBoost;
        Console.WriteLine(godzilla.godzillaName + " is your current Monster.");
        Console.WriteLine(godzilla.godzillaName + " has " + godzilla.godzillaHP + " Health remaining!");
        Console.WriteLine(godzilla.godzillaName + "'s current rival is " + godzilla.godzillaRival +"!");
        Console.WriteLine(godzilla.godzillaName + " ate the " + warhead.nukeName + " and now has " + godzilla.godzillaSpeed + " speed!");
    }
}

public class Monster
{
    public int godzillaHP = 100;
    public double godzillaSpeed = 15.5;
    public string godzillaName = "Gojira";
    public string godzillaRival = "King Gidorah";
}

public class NuclearEnergy
{
    public string nukeName = "Nuclear Warhead";
    public double nukeBoost = 2.5;
}