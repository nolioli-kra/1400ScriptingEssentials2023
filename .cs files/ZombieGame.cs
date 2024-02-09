using System;

public class ZombieGame
{
	public Weapon laserGun;
	public Monster zombie;
	public void Main()
	{
		//creating the instances of the Weapon and Monster objects before the while loop is executed will allow them to persist and maintain their state throughout the loop.
		laserGun = new Weapon();
		zombie = new Monster();
		while (zombie.zombieAlive == true)
		{ //while loop continues the game as long as the zombie is alive
			Console.WriteLine("The zombie has " + zombie.zombieHealth + " HP!");
			//Console.WriteLine(laserGun.weaponName + " has " + laserGun.ammoCount + " ammo remaining.");
			ZombieTakeDamage();
			
			if (zombie.zombieHealth <= 0)
			{
				zombie.zombieAlive = false;
				Console.WriteLine("You defeated the Zombie!");
			} // if
			else
			{
				Console.WriteLine("The zombie has " + zombie.zombieHealth + " HP!");
				ZombieTakeDamage();
			} //else
		} //while close
	} //main

	public void ZombieTakeDamage()
	{
		Console.WriteLine(laserGun.weaponName + " has " + laserGun.ammoCount + " ammo remaining.");
		Console.WriteLine("How many shot's do you want to fire?");
		int shotsFired = Convert.ToInt32((Console.ReadLine()));
		zombie.zombieHealth = Math.Max(0, zombie.zombieHealth - Convert.ToInt32(shotsFired * laserGun.weaponStrength));
		laserGun.ammoCount -= shotsFired;
	} //zombietakedamage
} //zombiegame

public class Weapon
{
	public int ammoCount = 100;
	public string weaponName = "Laser Cannon";
	public double weaponStrength = 2.5;
}

public class Monster
{
	public int zombieHealth = 200;
	public bool zombieAlive = true;
}