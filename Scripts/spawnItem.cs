using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnItem : MonoBehaviour
{
    public GameObject Erlenmeyer;
    public GameObject spawnErlenmeyer;
    public GameObject filtro;
    public GameObject spawnFiltro;
    public GameObject objetoInteragivel;
    private GameObject objetoSpawnado;
    private void Update()
    {
        if (GetComponent<onHover>().isHoveringInteragivel)
        {
            objetoInteragivel = GetComponent<onHover>().objetoInteragivel;
            if (Input.GetKeyDown(KeyCode.E) && objetoInteragivel.name == "BotaoVermelho")
            {
                Instantiate(Erlenmeyer, spawnErlenmeyer.transform.position, Quaternion.identity);
            }
            if (Input.GetKeyDown(KeyCode.E) && objetoInteragivel.name == "pepars")
            {
                //Posso querer checar isso aqui dnv, tá meio questionável e parece um pouquinho bugado
                spawnFiltro = GetComponent<pickUp>().pivotMao;
                
                objetoSpawnado = Instantiate(filtro, spawnFiltro.transform.position, Quaternion.identity);
                GetComponent<pickUp>().isHolding = true;
                GetComponent<pickUp>().objetoColisao = objetoSpawnado;
            }
        }
        
    }

}
