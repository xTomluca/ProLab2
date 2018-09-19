using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
	public class Kelvin
	{
		double temperature;
		public Kelvin(double temp)
		{
			this.temperature = temp;
		}
		public double GetTemperature()
		{
			return this.temperature;
		}
		public static explicit operator Fahrenheit(Kelvin k)
		{
			Fahrenheit f = new Fahrenheit(k.temperature*(9D/5D)-459.67D);
			return f;
		}
		public static explicit operator Celsius(Kelvin k)
		{
			Celsius c = new Celsius(((((Fahrenheit)k).GetTemperature())-32D)*(5D/9D));
			return c;
		}
		public static Kelvin operator +(Kelvin k, Celsius c)
		{
			Kelvin kResult = new Kelvin(k.GetTemperature() + ((Kelvin)c).GetTemperature());
			return kResult;
		}
		public static Kelvin operator +(Kelvin k, Fahrenheit f)
		{
			Kelvin kResult = new Kelvin(k.GetTemperature() + ((Kelvin)f).GetTemperature());
			return kResult;
		}
		public static Kelvin operator -(Kelvin k, Celsius c)
		{
			Kelvin kResult = new Kelvin(k.GetTemperature() - ((Kelvin)c).GetTemperature());
			return kResult;
		}
		public static Kelvin operator -(Kelvin k, Fahrenheit f)
		{
			Kelvin kResult = new Kelvin(k.GetTemperature() - ((Kelvin)f).GetTemperature());
			return kResult;
		}

	}
}
