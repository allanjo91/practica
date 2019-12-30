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

	private int Division(int val1, int val2)
	{
		return val1 / val2;
	}

	public string Dividir(int val1, int val2)
	{
		if(val2 != 0)
		{
			return this.Division(val1, val2).ToString();
		}
		else
		{
			return "No se puede dividir entre 0";
		}
	}

	public Double AreaCirculo(int radio)
	{
		return Math.PI * Math.Pow(radio,2);
	}

	public int Resta (int val1, int val2)
	{
		return val1 - val2;
	}

	public int Multiplicacion (int val1, int val2)
	{
		return val1 * val2;
	}
    
    public int AreaTriangulo(int baseT, int alturaT)
    {
        return (baseT * alturaT) / 2;
    }

    public Double AreaCuadrado(int val1)
    {
        return val1 * val1;
    }

    public Double AreaRectangulo(int val1, int val2)
    {
        return val1 * val2;
    }
}
