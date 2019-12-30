using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService
{

	[OperationContract]
	string GetData(int value);

	[OperationContract]
	CompositeType GetDataUsingDataContract(CompositeType composite);

	// TODO: agregue aquí sus operaciones de servicio
	[OperationContract]
	int Suma(int val1, int val2);

	[OperationContract]
	int Resta(int val1, int val2);

	[OperationContract]
	int Multiplicacion(int val1, int val2);

	[OperationContract]
	String Dividir(int val1, int val2);

	[OperationContract]
	int AreaTriangulo(int baseT, int alturaT);


	[OperationContract]
	Double AreaCuadrado(int val1);

	[OperationContract]
	Double AreaCirculo(int val1);

	[OperationContract]
	Double AreaRectangulo(int val1, int val2);

}

// Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
[DataContract]
public class CompositeType
{
	bool boolValue = true;
	string stringValue = "Hello ";

	[DataMember]
	public bool BoolValue
	{
		get { return boolValue; }
		set { boolValue = value; }
	}

	[DataMember]
	public string StringValue
	{
		get { return stringValue; }
		set { stringValue = value; }
	}
}
