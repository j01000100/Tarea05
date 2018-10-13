using UnityEngine;

namespace JoshuaPortilla {
    class Utensilios {

        public float tamaño;
        public float rango;
        public bool usandoU;

        public bool EnUso(){
            return usandoU;
        }
    }


    class UtensiliosParaCocinar : Utensilios {
        public float resistencia;
    }

    class Encendedor : UtensiliosParaCocinar {
        public bool prender;
        public bool Encendido() {
            return prender;
        }
    }
    class Rayador : UtensiliosParaCocinar {
        public float fuerza;
    }
    class TablaDePicar : UtensiliosParaCocinar {      
    }
    class Exprimidor : UtensiliosParaCocinar {
        public bool exprimir;
        public bool Exprimir() {
            return exprimir;
        }
    }


    class UtensiliosParaManipularLaComida : Utensilios {
        public string material;
    }

    class Cuchillo : Utensilios { }
    class Cucharon : Utensilios { }
    class Espatula : Utensilios { }
    class Rodillo : Utensilios { }
    class Tenedor : Utensilios { }
    class Cuchara : Utensilios { }
}
