using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conteudoObjInterno : MonoBehaviour
{
    public GameObject ObjetoInterno;
    public GameObject placeHolder;
    void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<isContainer>())
        {
            ObjetoInterno = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        ObjetoInterno = placeHolder;
        //Debug.Log(ObjetoInterno.gameObject.name);
    }
}
