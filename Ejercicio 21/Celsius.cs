using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
	public class Celsius
	{
		double temperature;
		public Celsius(double temp)
		{
			this.temperature = temp;
		}
		public double GetTemperature()
		{
			return this.temperature;
		}
		public static explicit operator Kelvin(Celsius c)
		{
			Kelvin k = new Kelvin((((((Fahrenheit)c).GetTemperature()) + 459.67D) * (5D / 9D)));
			return k;
		}

		public static explicit operator Fahrenheit(Celsius c)
		{
			Fahrenheit f = new Fahrenheit(c.GetTemperature() * (9D / 5D) + 32D);
			return f;
		}
		public static Celsius operator +(Celsius c, Fahrenheit f)
		{
			Celsius fResult = new Celsius(c.GetTemperature() + ((Celsius)f).GetTemperature());
			return fResult;
		}
		public static Celsius operator +(Celsius c, Kelvin k)
		{
			Celsius fResult = new Celsius(c.GetTemperature() + ((Celsius)k).GetTemperature());
			return fResult;
		}
		public static Celsius operator -(Celsius c, Fahrenheit f)
		{
			Celsius fResult = new Celsius(c.GetTemperature() - ((Celsius)f).GetTemperature());
			return fResult;
		}
		public static Celsius operator -(Celsius c, Kelvin k)
		{
			Celsius fResult = new Celsius(c.GetTemperature() - ((Celsius)k).GetTemperature());
			return fResult;
		}
	}
}
