using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UbahWarna1 : MonoBehaviour
{
    public void Hijau()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    public void Biru()
    {
        GetComponent<Renderer>().material.color = Color.cyan;
    }

    public void Merah()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
