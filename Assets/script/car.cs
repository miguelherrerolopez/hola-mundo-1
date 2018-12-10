using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class car : MonoBehaviour {
    float velocidad = 0.1f;
    public KeyCode teclaAsignada = KeyCode.F1;
    public string nombre;
    int cuenta = 0;
    public Text marcador;
    public Text ganador;
    public GameObject canvas;
    bool aterminado = false;

    void Update() {
        if (Input.GetKeyDown(teclaAsignada)&& aterminado == false) {
            this.transform.Translate(new Vector3(velocidad, 0, 0));
            cuenta++;
            marcador.text = "Tus pulsaciones: " + cuenta;
        }
    }
    void OnTriggerEnter2D(Collider2D collider) {
        Debug.Log("El ganador es " + nombre);
        velocidad = 0;
        ganador.text = "!Felicidades  " + nombre + " has ganado¡";
        aterminado = true;
    }
}

