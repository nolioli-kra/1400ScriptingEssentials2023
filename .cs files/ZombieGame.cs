using System;

public class ZombieGame
{
	public Weapon laserGun;
	public Monster zombie;
	public void Main()
	{
		laserGun = new Weapon();
		zombie = new Monster();
		Console.WriteLine("The zombie has " + zombie.zombieHealth + " HP!");
		ZombieTakeDamage();
		if (zombie.zombieHealth <= 0)
		{
			Console.WriteLine("You defeated the Zombie!");
		}
		else
		{
			Console.WriteLine("The zombie has " + zombie.zombieHealth + " HP!");
			Console.WriteLine(laserGun.weaponName + " has " + laserGun.ammoCount + " ammo remaining.");
			ZombieTakeDamage();
		}
	}

	public void ZombieTakeDamage()
	{
		Console.WriteLine("How many shot's do you want to fire?");
		int shotsFired = Convert.ToInt32((Console.ReadLine()));
		zombie.zombieHealth -= Convert.ToInt32(shotsFired * laserGun.weaponStrength);
		laserGun.ammoCount -= shotsFired;
	}
}

public class Weapon
{
	public int ammoCount = 100;
	public string weaponName = "Laser Cannon";
	public double weaponStrength = 2.5;
}

public class Monster
{
	public int zombieHealth = 200;
}

public class Monster
{
	public int zombieHealth = 200;
}
