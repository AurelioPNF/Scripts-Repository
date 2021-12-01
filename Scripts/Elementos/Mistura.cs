using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Mistura : MonoBehaviour
{
    public bool justAdded = false;

    public Elemento solventeBase;
    public Elemento elementoAdicionado;
    public Elemento[] elementos = new Elemento[0];

    private void Update()
    {
        addElemento(elementoAdicionado);
    }

    private void addElemento(Elemento elemento)
    {
        if (justAdded == true)
        {
            bool existe = false;
            for (int i = 0; i < elementos.Length; i++)
            {
                if (elementos[i] == elementoAdicionado)
                {
                    existe = true;
                }
                Debug.Log(elementos[i].getNome_Comercial());
            }
            if (!existe)
            {
                Array.Resize(ref elementos, elementos.Length + 1);
                elementos[elementos.Length - 1] = elemento;
            }
            justAdded = false;
        }
    }
}
