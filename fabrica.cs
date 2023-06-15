using System;
using Personaje;
namespace Personaje{
    public static class FabricaDePersonajes{
        private static Random random = new Random();

        public static Personaje CrearPersonaje(string apodo, double edad, TipoPersonaje tipo){
            Personaje personaje = new Personaje{
                Apodo = apodo,
                Edad = edad,
                Tipo = tipo,
                

            }
        }
    }
}
