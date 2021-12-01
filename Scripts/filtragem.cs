using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class filtragem : MonoBehaviour
{
    public GameObject localDoRecipiente;
    private string objetoExterno;
    void Update()
    {
       


    }
    //Pode acontecer bug se o player colocar outro item dentro do collider
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<isPaper>())
        {
            localDoRecipiente = GameObject.Find("contemRecipiente");
            if (localDoRecipiente.GetComponent<conteudoObjInterno>())
            {
                
                if (localDoRecipiente.GetComponent<conteudoObjInterno>().ObjetoInterno.GetComponent<isContainer>())
                {
                    //Debug.Log(localDoRecipiente.GetComponent<conteudoObjInterno>().ObjetoInterno.name);
                    if (other.GetComponentInChildren<contentMaterial>().nomeMaterial == "AguaAreia")
                    {
                        objetoExterno = "Agua";
                        other.GetComponentInChildren<contentMaterial>().nomeMaterial = "Areia";
                        localDoRecipiente.GetComponent<conteudoObjInterno>().ObjetoInterno.GetComponentInChildren<contentMaterial>().nomeMaterial = objetoExterno;
                    }
                    else if(other.GetComponentInChildren<contentMaterial>().nomeMaterial == "Agua")
                    {
                        objetoExterno = "Agua";
                        other.GetComponentInChildren<contentMaterial>().nomeMaterial = "Vazio";
                        localDoRecipiente.GetComponent<conteudoObjInterno>().ObjetoInterno.GetComponentInChildren<contentMaterial>().nomeMaterial = objetoExterno;
                    }
                }
                else if (!localDoRecipiente.GetComponent<conteudoObjInterno>().ObjetoInterno.GetComponent<isContainer>())
                {
                    if(other.GetComponentInChildren<contentMaterial>().nomeMaterial == "Agua")
                    {
                        other.GetComponentInChildren<contentMaterial>().nomeMaterial = "Vazio";
                    }
                    
                }
            }
        }
    }
}
