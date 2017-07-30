using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var trafficLights = new List<TrafficLight>();

        var inputColors = Console.ReadLine().Split();

        for (int i = 0; i < inputColors.Length; i++)
        {
            trafficLights.Add(new TrafficLight((LightColor)Enum.Parse(typeof(LightColor), inputColors[i])));
        }

        var number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            foreach (var trafficLight in trafficLights)
            {
                trafficLight.ChangeColor();
                Console.Write(trafficLight.CurrentColor + " ");
            }
            Console.WriteLine();
        }
    }
}