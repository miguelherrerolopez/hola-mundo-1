using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public interface IMisEventosCanvas : IEventSystemHandler
{
    // functions that can be called via the messaging system
    void MostrarPuntos(int valor);
}

public class ControlDelCanvas : MonoBehaviour, IMisEventosCanvas
{
    public Text texto;

    public void MostrarPuntos(int valor)
    {
        texto.text = "Puntos: " + valor;
    }
}
