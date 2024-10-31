using System;
using System.Security.Cryptography.X509Certificates;

public class Persona {
    //declaro la clase
    public string Nombre { get; set;}
    public int Edad {get; set;}
    // constructor de la clase
    public Persona() {
       this.Nombre = "N/A";
        this.Edad = 0;
    } 
    public Persona(string Nombre, string Edad){
        this.Nombre = nombre;
        this.Edad = edad;
    public void MostrarInformacion(){
        Console.WriteLine($"Nombre: {this.Nombre},Edad:{this.Edad}");
    }
    }
}
