namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(75);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(30);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($"Celsius: {celsius}");
            Console.WriteLine($"Fahrenheit: {fahrenheit}");
            
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");
            
            var celsiusEquiv = TempConverter.FahrenheitToCelsius(50);
            var fahrenheitEquiv = TempConverter.CelsiusToFahrenheit(10);
            Console.WriteLine($"The following converted values of Celsius and Fahrenheit are equivalent:");
            Console.WriteLine($"Celsius base value: {fahrenheitEquiv}, and Fahrenheit base value: {celsiusEquiv}");
            
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("");
        }
    }
}
