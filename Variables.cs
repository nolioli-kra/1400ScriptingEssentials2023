using System;

public class VariablesProgram
{
    public Monster godzilla;
    public Monster gidorah;
    public NuclearEnergy warhead;

    public void Main()
    {
        godzilla = new Monster();
        gidorah = new Monster();
        warhead = new NuclearEnergy();

        if (godzilla.godzillaHP <= 0 )
        {
            Console.WriteLine(godzilla.godzillaName + " has died!"); //if godzilla goes below or equal to 0 HP then a death message will display
            //^^he currently has no ways of taking damage so this is just conceptual lol
        }
        else
        {
            Console.WriteLine(godzilla.godzillaName + " has " + godzilla.godzillaHP + " Health remaining!"); //display for godzilla's HP
        }

        godzilla.godzillaSpeed += warhead.nukeBoost; //this operator will give godzilla a speed boost when he eats a nuclear warhead
        Console.WriteLine(godzilla.godzillaName + " is your current Monster."); //tells you which monster is currently being controlled       
        Console.WriteLine(godzilla.godzillaName + "'s current rival is " + godzilla.godzillaRival +"!"); //this is a conceptual rival mechanic when you may get bonus points for defeating your rival monster
        Console.WriteLine(godzilla.godzillaName + " ate the " + warhead.nukeName + " and now has " + godzilla.godzillaSpeed + " speed!"); //informs the player of the buff gained by eating the warhead powerup
    }
}

public class Monster
{
    public int godzillaHP = 100; //godzilla's total starting HP
    public double godzillaSpeed = 15.5; //starting speed stat for godzilla
    public string godzillaName = "Gojira"; //godzilla's display name
    public string godzillaRival = "King Gidorah"; //godzilla's designated rival

    public int gidorahHP = 120;
    public double gidorahSpeed = 20.5;
    public string gidorahName = "King Gidorah";
    public string gidorahRival = "Gojira";
    public bool gidorahPlayable = false; //this boolean value states that King Gidorah is NOT a currently playable monster
}

public class NuclearEnergy
{
    public string nukeName = "Nuclear Warhead"; //display name for the warhead powerup
    public double nukeBoost = 2.5; //speed buff given by the powerup
}