using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Partida {

    public string Nombre { get; set; }
    public int Puntuacion { get; set; }

    public Partida(string nombre, int puntuacion) {
        this.Nombre = nombre;
        this.Puntuacion = puntuacion;
    }
}

