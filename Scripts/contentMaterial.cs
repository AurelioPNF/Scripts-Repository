using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contentMaterial : MonoBehaviour
{
    
    public string nomeMaterial="Vazio";
    public string nomeMistura = "Vazio";
    private GameObject pegaMaterial;
    private void Awake()
    {
        pegaMaterial = GameObject.FindGameObjectWithTag("tagContemMateriais");
    }
    void Update()
    {
        if (nomeMaterial == "Vazio")
        {
            GetComponent<Renderer>().material = pegaMaterial.GetComponent<referenciasMateriais>().materialVazio;
            nomeMistura = "Vazio";
        }else if(nomeMaterial == "Agua")
        {
            GetComponent<Renderer>().material = pegaMaterial.GetComponent<referenciasMateriais>().materialAgua;
            nomeMistura = "Água";
        }
        else if(nomeMaterial == "Areia")
        {
            GetComponent<Renderer>().material = pegaMaterial.GetComponent<referenciasMateriais>().materialAreia;
            nomeMistura = "Areia";
        }
        else if(nomeMaterial == "AguaAreia")
        {
            GetComponent<Renderer>().material = pegaMaterial.GetComponent<referenciasMateriais>().materialAgua_Areia;
            nomeMistura = "Mistura de Água e Areia";
        }
        
    }
}
