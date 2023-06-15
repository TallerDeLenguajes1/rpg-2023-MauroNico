namespace Personaje{
    using System;
    public enum Tipo{
        Guerrero,
        Cañonero,
        Cazador,
        Asesino,
        Mago
    }
 
    public class Personaje{
        private static Random random = new Random();
        private static string[] nombres = {"Pepe","Papa","Pipi","Popo","Pupu"};
        public double Velocidad{get;set;}
        public double Destreza{get;set;}
        public double Fuerza{get;set;}
        public double Nivel{get;set;}
        public double Armadura{get;set;}
        public double Salud{get;set;}
        public string Nombre{get;set;}
        public string Apodo{get;set;}
        public double edad{get;set;}

        public Personaje(){
            nombres = ObtenerNombreAleatorio();
        }
        private string ObtenerNombreAleatorio(){
            int index = random.Next(nombres.Length);
            return nombres[index];
        }
}



}