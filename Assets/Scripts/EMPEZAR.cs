using JoshuaPortilla;
using UnityEngine;

public class EMPEZAR : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Pescado pescado = new Pescado(1, "pescado");
        Fideos fideos = new Fideos(1, "fideos");
        fideos.Hablar("Se preparará la comida usando " + fideos.nombre + " y " + pescado.nombre);

        Olla olla = new Olla("olla");
        olla.Hablar("Se cocinarán los " + fideos.nombre + " en la " + olla.nombre);

        Estufa estufa = new Estufa(true, 80, 31);
        estufa.Hablar("La estufa está encendida, funcionando al " + estufa.potencia + "% de su capacidad y a " + estufa.temperatura + " grados");

        Debug.Log("La comida está lista, provecho");

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
