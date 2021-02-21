using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter the temperature in Celcius:");
		
		//read the user input and convert it into type Double
		double tempInCelcius = Convert.ToDouble(Console.ReadLine());
		
		//convert the temperature using the below formula
		double tempInFarenheit = Convert.ToDouble(tempInCelcius * 9) / 5 + 32;
		
		//print the results
		Console.WriteLine("The weather in Farenheit is {0}°F", tempInFarenheit);
	}
}