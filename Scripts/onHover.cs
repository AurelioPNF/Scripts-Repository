using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onHover : MonoBehaviour
{
    public Animator anim;
    public Camera cam;
    //Elementos UI
    public GameObject crossHair;
    public GameObject seguravel;
    public GameObject interagivel;
    public GameObject textoNomeMistura;
    //
    public GameObject colocaContainer;
    public GameObject objetoColisao;
    public int maxRange;
    [HideInInspector]
    public bool isHoveringPickable;
    public GameObject rotAll;
    [HideInInspector]
    public bool isHoveringInteragivel;
    [HideInInspector]
    public GameObject objetoInteragivel;
    public Text textoMistura;
    // Start is called before the first frame update
    void Start()
    {
        cam.GetComponent<Camera>();
        crossHair.SetActive(true);
        interagivel.SetActive(false);
        colocaContainer.SetActive(false);
        seguravel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(cam.transform.position,cam.transform.forward*10,Color.green);
        rotAll.transform.rotation = transform.rotation;
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward * 10, out hit, maxRange))
        {
            if (hit.collider.tag == "objetoSeguravel")
            {
                objetoColisao = hit.collider.gameObject;
                crossHair.SetActive(false);
                isHoveringPickable = true;
                if (objetoColisao.GetComponentInChildren<contentMaterial>())// n ta definido ainda, vou ter que usar hit.collider
                {
                    seguravel.SetActive(true);
                    if (GetComponent<pickUp>().isHolding)
                    {
                        seguravel.SetActive(false);
                        interagivel.SetActive(false);
                        colocaContainer.SetActive(true);
                    }
                    textoMistura.text = objetoColisao.GetComponentInChildren<contentMaterial>().nomeMistura;
                    textoNomeMistura.SetActive(true);
                    interagivel.SetActive(false);
                }
                /*else if (GetComponent<transferirConteudo>().objetoOlhadoTemConteudo && GetComponent<pickUp>().isHolding && GetComponent<transferirConteudo>().materialSegurado=="Vazio") //Tentando fazer ele mostrar que não é interagivel se o container segurado está vazio
                {
                    crossHair.SetActive(true);
                    seguravel.SetActive(false);
                    interagivel.SetActive(false);
                    colocaContainer.SetActive(false);
                }*/
                else
                {
                    seguravel.SetActive(true);
                    interagivel.SetActive(false);
                    colocaContainer.SetActive(false);
                }
            }
            else if (hit.collider.tag == "objetoInteragivel")
            {
                objetoInteragivel = hit.collider.gameObject;
                isHoveringInteragivel = true;
                crossHair.SetActive(false);
                interagivel.SetActive(true);
                seguravel.SetActive(false);
                colocaContainer.SetActive(false);
                textoNomeMistura.SetActive(false);
            }
            else if(hit.collider.tag == "portaArmario")
            {
                objetoInteragivel = hit.collider.gameObject;
                crossHair.SetActive(false);
                interagivel.SetActive(true);
                seguravel.SetActive(false);
                colocaContainer.SetActive(false);
                textoNomeMistura.SetActive(false);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (!anim.GetBool("Abrir"))
                    {
                       anim.SetBool("Abrir", true);
                    }
                    else
                    {
                        anim.SetBool("Abrir", false);
                    }
                    
                }
            }
        }
        else
        {
            isHoveringPickable = false;
            isHoveringInteragivel = false;
            crossHair.SetActive(true);
            interagivel.SetActive(false);
            seguravel.SetActive(false);
            colocaContainer.SetActive(false);
            textoNomeMistura.SetActive(false);
        }
    }
}
