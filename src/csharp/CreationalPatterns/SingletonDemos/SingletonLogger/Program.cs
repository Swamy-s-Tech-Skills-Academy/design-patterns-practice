﻿using SingletonLogger;

Console.Title = "Singleton";

// call the property getter twice
var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

if (instance1 == instance2 && instance2 == Logger.Instance)
{
    Console.WriteLine("Instances are the same.");
}

instance1.Log($"Message from {nameof(instance1)}");

instance1.Log($"Message from {nameof(instance2)}");

Logger.Instance.Log($"Message from {nameof(Logger.Instance)}");

Console.WriteLine("\n\nPress any key to exit...");
Console.ReadLine();