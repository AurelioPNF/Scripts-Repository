using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transferirConteudo : MonoBehaviour
{
    private GameObject objetoSegurado;
    [HideInInspector]
    public GameObject objetoOlhado;
    private bool objetoSeguradoTemConteudo = false;
    [HideInInspector]
    public bool objetoOlhadoTemConteudo = false;
    [HideInInspector]
    public string materialSegurado;
    [HideInInspector]
    public string materialOlhado;
    public string nomeMistura;
    void Update()
    {
        if (GetComponent<pickUp>().isHolding)
        {
            objetoSegurado = GetComponent<pickUp>().objetoColisao;
            if (GetComponent<onHover>().isHoveringPickable)
            {
                objetoOlhado = GetComponent<onHover>().objetoColisao;
                //Debug.Log("Is hovering <<"+objetoOlhado.name+">> while holding <<"+ objetoSegurado.name + ">>");
                if (objetoSegurado.GetComponent<isContainer>())
                {
                    if (objetoSegurado.GetComponentInChildren<contentMaterial>())
                    {
                        //Debug.Log("Conteudo do Objeto Segurado: " + objetoSegurado.GetComponentInChildren<contentMaterial>().nomeMaterial);
                        materialSegurado = objetoSegurado.GetComponentInChildren<contentMaterial>().nomeMaterial;
                        objetoSeguradoTemConteudo = true;
                    }
                    else
                    {
                        objetoSeguradoTemConteudo = false;
                    }
                    
                }
             
                if (objetoOlhado.GetComponent<isContainer>())
                {
                    if (objetoOlhado.GetComponentInChildren<contentMaterial>())
                    {
                        //Debug.Log("Conteudo do Objeto Olhado: " + objetoOlhado.GetComponentInChildren<contentMaterial>().nomeMaterial);
                        materialOlhado = objetoOlhado.GetComponentInChildren<contentMaterial>().nomeMaterial;
                        objetoOlhadoTemConteudo = true;
                    }
                    else
                    {
                        objetoOlhadoTemConteudo = false;
                    }
                }
                
                //Debug.Log("Objeto Segurado tem conteudo?: " + objetoSeguradoTemConteudo + " Objeto Olhado tem conteudo?: "+ objetoOlhadoTemConteudo);
                if(objetoSeguradoTemConteudo && objetoOlhadoTemConteudo)
                {
                    if (Input.GetKeyDown(KeyCode.Q))
                    {                                                                                   //Por agora, não da pra colocar uma mistura com outra coisa, quando eu mudar esse sistema é suposto ser possível
                        if(materialSegurado!= "Vazio" && materialSegurado!=materialOlhado)//Não dá pra colocar *vazio* em um outro objeto, e não dá pra colocar o material segurado se o material olhado for igual a ele
                        {
                            if(materialOlhado == "Vazio")
                            {
                                objetoOlhado.GetComponentInChildren<contentMaterial>().nomeMaterial = materialSegurado;
                            }
                            else if (materialOlhado == "Agua")
                            {
                                if (materialSegurado == "Areia")
                                {
                                    objetoOlhado.GetComponentInChildren<contentMaterial>().nomeMaterial = "AguaAreia";
                                }
                            }
                            else if (materialOlhado == "Areia")
                            {
                                if (materialSegurado == "Agua")
                                {
                                    objetoOlhado.GetComponentInChildren<contentMaterial>().nomeMaterial = "AguaAreia";
                                }
                            }
                            objetoSegurado.GetComponentInChildren<contentMaterial>().nomeMaterial = "Vazio";
                        }
                    }
                }
            }
        }
    }
}
