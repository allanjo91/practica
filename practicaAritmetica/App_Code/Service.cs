using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}

	public int Suma(int val1, int val2)
	{
		return val1 + val2;
	}

	private int division(int val1, int val2)
	{
		return val1 / val2;
	}

	public string dividir(int val1, int val2)
	{
		if(val2 != 0)
		{
			return this.division(val1, val2).ToString();
		}
		else
		{
			return "No se puede dividir entre 0";
		}
	}

	public Double areaCirculo(int radio)
	{
		return Math.PI * Math.Pow(radio,2);
	}

}
