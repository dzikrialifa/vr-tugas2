using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ubahwarna2 : MonoBehaviour
{
    public void Biru()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    public void Ungu()
    {
        GetComponent<Renderer>().material.color = Color.magenta;
    }

    public void Hijau()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
}
