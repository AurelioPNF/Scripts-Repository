using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pegaElemento : MonoBehaviour
{
    public GameObject objetoSegurado;
    public AudioClip somDaAgua;
    public GameObject objetoInteragivel;
    public ElementosBase elementoBase;
    // Update is called once per frame
    void Update()
    {
        if (GetComponent<pickUp>().isHolding)
        {
            objetoSegurado = GetComponent<pickUp>().objetoColisao;
            if (objetoSegurado.GetComponent<isContainer>())
            {
                Debug.Log(GetComponent<onHover>().objetoColisao.name);
                if (GetComponent<onHover>().isHoveringInteragivel)
                {
                    objetoInteragivel = GetComponent<colocarItem>().localDestino;
                    if(objetoInteragivel.name == "interagivelPia")
                    {
                        Debug.Log("É a pia");
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            if (objetoSegurado.GetComponentInChildren<contentMaterial>().nomeMaterial == "Vazio")
                            {
                                objetoSegurado.GetComponentInChildren<contentMaterial>().nomeMaterial = "Agua";
                                AudioSource.PlayClipAtPoint(somDaAgua, GameObject.Find("Torneira").transform.position);
                            }
                            else if (objetoSegurado.GetComponentInChildren<contentMaterial>().nomeMaterial == "Areia")
                            {
                                objetoSegurado.GetComponentInChildren<contentMaterial>().nomeMaterial = "AguaAreia";
                            }
                        }
                    }
                    else if(objetoInteragivel.name == "potinhoAreia")
                    {
                        Debug.Log("É o potinho de areia");
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            if (objetoSegurado.GetComponentInChildren<contentMaterial>().nomeMaterial == "Vazio")
                            {
                                objetoSegurado.GetComponentInChildren<contentMaterial>().nomeMaterial = "Areia";
                            }
                            else if (objetoSegurado.GetComponentInChildren<contentMaterial>().nomeMaterial == "Agua")
                            {
                                objetoSegurado.GetComponentInChildren<contentMaterial>().nomeMaterial = "AguaAreia";
                            }
                            if (objetoSegurado.GetComponentInChildren<Mistura>())
                            {
                                objetoSegurado.GetComponentInChildren<Mistura>().elementoAdicionado = elementoBase.Areia;
                                objetoSegurado.GetComponentInChildren<Mistura>().justAdded = true;
                            }
                        }
                    }
                }
            }
            
        }
    }
}
//Depois fazer o audio abaixar de volume de acordo com a distância, talvez um script só pra isso seja bom