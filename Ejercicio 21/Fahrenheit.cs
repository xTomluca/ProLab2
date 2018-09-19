using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
	public class Fahrenheit
    {
		double temperature;
    
		public Fahrenheit(double temp)
		{
			this.temperature = temp;
		}
		public double GetTemperature()
		{
			return this.temperature;
		}
		public static explicit operator Celsius(Fahrenheit f)
		{
			Celsius c = new Celsius((f.temperature - 32D) * (5D / 9D));
			return c;
		}
		public static explicit operator Kelvin(Fahrenheit f)
		{
			Kelvin k = new Kelvin((f.GetTemperature() + 459.67D) * (5D / 9D));
			return k;
		}
		public static Fahrenheit operator +(Fahrenheit f, Celsius c)
		{
			Fahrenheit fResult = new Fahrenheit(f.GetTemperature() + ((Fahrenheit)c).GetTemperature());
			return fResult;
		}
		public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
		{
			Fahrenheit fResult = new Fahrenheit(f.GetTemperature() + ((Fahrenheit)k).GetTemperature());
			return fResult;
		}
		public static Fahrenheit operator -(Fahrenheit f, Celsius c)
		{
			Fahrenheit fResult = new Fahrenheit(f.GetTemperature() - ((Fahrenheit)c).GetTemperature());
			return fResult;
		}
		public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
		{
			Fahrenheit fResult = new Fahrenheit(f.GetTemperature() - ((Fahrenheit)k).GetTemperature());
			return fResult;
		}
	}
}
