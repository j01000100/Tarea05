using UnityEngine;

namespace JoshuaPortilla {
    class Electrodomesticos {

        public bool encendido;
        public float potencia;
        public float temperatura;
        public float volumen;

        public bool Encender(){
            return encendido;
        }
    }

    class Estufa : Electrodomesticos {

        public Estufa(bool encendido, float potencia, float temperatura){
            this.encendido = encendido;
            this.potencia = potencia;
            this.temperatura = temperatura;
        }

        public void Hablar(string mensaje)
        {
            Debug.Log(mensaje);
        }
    }
    class Horno : Electrodomesticos {

        public bool Cocinar() {
            return encendido;
        }
    }
    class Licuadora : Electrodomesticos {

        public bool Licuar() {
            return encendido;

        }
    }
    class Microondas : Electrodomesticos {

        public bool Cocinar() {
            return encendido;
        }
    }
    class OllaArrocera : Electrodomesticos {

        public bool Cocinar() {
            return encendido;
        }
    }
    class Cafetera : Electrodomesticos {

        public bool Cocinar() {
            return encendido;
        }
    }
    class Batidora : Electrodomesticos {

        public bool Batir() {
            return encendido;
        }
    }
    class Refrigeradora : Electrodomesticos {

        public bool Refrigerar() {
            return encendido;
        }
    }
}
