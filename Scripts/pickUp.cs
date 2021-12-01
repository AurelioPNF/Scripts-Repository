using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public GameObject isHovering;
    public GameObject objetoColisao;
    public GameObject pivotMao;
    public Vector3 cam;
    public bool isHoveringPickable;
    public bool isHoveringInteragivel;
    public bool isHolding;
    private GameObject rotAll;
    public bool objetoVirado;
    // Update is called once per frame

    private void Start()
    {
        objetoVirado = false;
        isHolding = false;
    }

    void Update()
    {
        isHoveringPickable =  isHovering.GetComponent<onHover>().isHoveringPickable;
        isHoveringInteragivel = isHovering.GetComponent<onHover>().isHoveringInteragivel;
        cam = isHovering.GetComponent<onHover>().cam.transform.forward;
        if (isHolding)//Se está segurando um objeto faça isso:
        {
            objetoColisao.transform.position = pivotMao.transform.position;
            rotAll = isHovering.GetComponent<onHover>().rotAll;
            objetoColisao.transform.rotation = rotAll.transform.rotation;
            objetoVirado = false;
            //Virando o objeto
            if (Input.GetKey(KeyCode.Q))
            {
                objetoColisao.transform.Rotate(0, 0, 80f);
                objetoVirado = true;
            }
            //

            //Solta Objeto
            if (Input.GetKeyDown(KeyCode.E) && !isHoveringInteragivel){
                if (!GetComponent<pickUp>().objetoColisao.GetComponent<isPaper>())
                {
                    isHolding = false;
                    objetoColisao.GetComponent<Rigidbody>().useGravity = true;
                    objetoColisao.GetComponent<Rigidbody>().freezeRotation = false;
                }
                else if (GetComponent<pickUp>().objetoColisao.GetComponent<isPaper>() && !GetComponent<onHover>().isHoveringInteragivel)
                {
                    isHolding = false;
                    objetoColisao.GetComponent<Rigidbody>().useGravity = true;
                    objetoColisao.GetComponent<Rigidbody>().freezeRotation = false;
                }
            }

            //

            //Joga Objeto
            if (Input.GetKeyDown(KeyCode.G))
            {
                isHolding = false;
                objetoColisao.GetComponent<Rigidbody>().useGravity = true;
                objetoColisao.GetComponent<Rigidbody>().freezeRotation = false;
                objetoColisao.GetComponent<Rigidbody>().AddForce(cam * 10, ForceMode.Impulse);
            }
            //
        }
        else //Se não está segurando um objeto, faça isso:
        {
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                objetoColisao = isHovering.GetComponent<onHover>().objetoColisao;
                //Pega o objeto
                if (isHoveringPickable)
                {
                    isHolding = true;
                    objetoColisao.GetComponent<Rigidbody>().useGravity = false;
                    objetoColisao.GetComponent<Rigidbody>().freezeRotation = true;
                    objetoColisao.transform.rotation = Quaternion.identity;
                    objetoColisao.transform.rotation = pivotMao.transform.rotation;
                }
                //
            }
        }     
        
    }
}
