using UnityEngine;

namespace JoshuaPortilla {
    class Recipientes {

        public float volumen;

    }


    class RecipientesParaCocinar : Recipientes {

        public float resistencia;
    }

    class Olla : RecipientesParaCocinar {
        public string nombre;
        void Resistencia() {
            resistencia = 100;
        }
        public Olla(string nombre)
        {
            this.nombre = nombre;
            nombre = "olla";
        }
        public void Hablar(string mensaje)
        {
            Debug.Log(mensaje);
        }
    }
    class Sartén : RecipientesParaCocinar {
        void Resistencia() {
            resistencia = 100;
        }
    }
    class Tetera : RecipientesParaCocinar {
        void Resistencia() {
            resistencia = 100;
        }
    }
    class Cacerola : RecipientesParaCocinar {
        void Resistencia() {
            resistencia = 100;
        }
    }
    class Tazón : RecipientesParaCocinar {
        void Resistencia() {
            resistencia = 100;
        }
    }
    class Medidor : RecipientesParaCocinar {
        void Resistencia() {
            resistencia = 100;
        }
    }


    class RecipientesParaComer : Recipientes {

        public bool usando;

        public bool EnUso() {
            return usando;
        }
    }

    class Platos : RecipientesParaComer { }
    class Tazas : RecipientesParaComer { }
    class Vasos : RecipientesParaComer { }
    class Copas : RecipientesParaComer { }
}