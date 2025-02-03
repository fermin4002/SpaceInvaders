using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Jugador {
    private int puntuacion;
    private string nombre;

    public Jugador(string nombre,int puntuacion) {
        this.nombre = nombre;
        this.puntuacion = 0;
    }

    public int getPuntuacion() {
        return puntuacion;
    }

    public string getNombre() {
        return nombre;
    }

    public void setPuntuacion(int puntuacion) {
        this.puntuacion = puntuacion;
    }

    public void setNombre(string nombre) {
        this.nombre = nombre;
    }

}
