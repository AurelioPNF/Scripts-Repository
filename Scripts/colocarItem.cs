using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colocarItem : MonoBehaviour
{
    public GameObject localDestino;
    // Update is called once per frame
    void Update()
    {
        
        localDestino = GetComponent<onHover>().objetoInteragivel;
        if (GetComponent<pickUp>().isHolding)
        {
            if (GetComponent<onHover>().isHoveringInteragivel)
            {
                if (Input.GetKeyDown(KeyCode.B) && GetComponent<pickUp>().isHolding == true)
                {
                    //Condição para colocar no suporte de filtro
                    if (GetComponent<pickUp>().objetoColisao.GetComponent<isPaper>() && GetComponent<onHover>().objetoInteragivel.name == "colocarFiltro")
                    {
                        GetComponent<pickUp>().objetoColisao.transform.position = localDestino.transform.position;
                        GetComponent<pickUp>().isHolding = false;
                    }
                    //
                    //Condição para recipiente no lugar de recipiente
                    else if (GetComponent<pickUp>().objetoColisao.GetComponent<isContainer>() && GetComponent<onHover>().objetoInteragivel.name == "colocarRecipiente")
                    {
                        GetComponent<pickUp>().objetoColisao.transform.position = localDestino.transform.position;
                        GetComponent<pickUp>().isHolding = false;
                    }
                    //
                }
            }
        }
    }
}
