using UnityEngine;

namespace JoshuaPortilla {
    class Comida {
        public int cantidad;
        public string nombre;
    }

    class Carnes : Comida {
        public void Comida(int cantidad) {
            cantidad = 1;
        }
    }
    class Vegetales : Comida {
        public void Comida(int cantidad) {
            cantidad = 2;
        }
    }
    class Pescado : Comida {
        public Pescado(int cantidad, string nombre) {
            cantidad = 1;
            this.nombre = nombre;
            nombre = "pescado";
        }
    }
    class Panes : Comida {
        public void Comida(int cantidad) {
            cantidad = 1;
        }
    }
    class Huevos : Comida {
        public void Comida(int cantidad) {
            cantidad = 2;
        }
    }
    class Fideos : Comida {
        public Fideos (int cantidad, string nombre) {
            cantidad = 1;
            this.nombre = nombre;
            nombre = "fideos";
        }
        public void Hablar (string mensaje)
        {
            Debug.Log(mensaje);
        }
    }


    public class Bebidas {
        public bool liquido;
    }
    class Cafe : Bebidas {
        public Cafe (bool liquido)
        {
            this.liquido = liquido;
            liquido = true;
        }
    }
    class Vino : Bebidas {
        public Vino(bool liquido)
        {
            this.liquido = liquido;
            liquido = true;
        }
    }
    class Agua : Bebidas {
        public Agua(bool liquido)
        {
            this.liquido = liquido;
            liquido = true;
        }
    }
    class Infusiones : Bebidas {
        public Infusiones(bool liquido)
        {
            this.liquido = liquido;
            liquido = false;
        }
    }
}
