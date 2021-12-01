using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elemento : MonoBehaviour
{
    public Elemento()
    {

    }
    public Elemento(string nome_Cientifico, string nome_Comercial, int polaridade, bool solvente, int estadoF, int temperatura1, int temperatura2, bool soluvel, bool precisa_Misturar, bool precisa_Calor, bool precisa_Elemento, string dependencia = null, Texture textura_Associada = null)
    {
        this.nome_Cientifico = nome_Cientifico;
        this.nome_Comercial = nome_Comercial;
        this.polaridade = polaridade;
        this.solvente = solvente;
        this.estadoF = estadoF;
        this.temperatura1 = temperatura1;
        this.temperatura2 = temperatura2;
        this.soluvel = soluvel;
        this.precisa_Misturar = precisa_Misturar;
        this.precisa_Calor = precisa_Calor;
        this.precisa_Elemento = precisa_Elemento;
        this.dependencia = dependencia;
    }
    // Grafico //
    string nome_Cientifico;
    string nome_Comercial;
    Texture textura_Associada;
    //

    // Atributos //
    int polaridade; // 1 - Polar // 2 - Apolar // 3 - Misto
    bool solvente;

    int estadoF; // 1 - Físico // 2 - Líquido // 3 - Gás //
    int temperatura1; //Temperatura de fusão
    int temperatura2; //Temperatura de ebulição

    bool soluvel;
    bool precisa_Misturar;
    bool precisa_Calor;

    bool precisa_Elemento;
    string dependencia;

    //
    #region Get_Set

    //Nome_Cientifico
    public void setNome_Cientifico(string nome)
    {
        this.nome_Cientifico = nome;
    }
    public string getNome_Cientifico()
    {
        return this.nome_Cientifico;
    }
    //Nome_Comercial
    public void setNome_Comercial(string nome)
    {
        this.nome_Comercial = nome;
    }
    public string getNome_Comercial()
    {
        return this.nome_Comercial;
    }
    //Textura Associada
    public void setTextura(Texture textura)
    {
        this.textura_Associada = textura;
    }
    public Texture getTextura()
    {
        return this.textura_Associada;
    }
    //Polaridade
    public void setPolaridade(int polaridade)
    {
        this.polaridade = polaridade;
    }
    public int getPolaridade()
    {
        return this.polaridade;
    }
    //Solvente
    public void setSolvente(bool solvente)
    {
        this.solvente = solvente;
    }
    public bool getSolvente()
    {
        return this.solvente;
    }
    //Estado Fisico
    public void setEstadoF(int estado)
    {
        this.estadoF = estado;
    }
    public int getEstadoF()
    {
        return this.estadoF;
    }
    //Temperatura 1(Fusão)
    public void setTemperatura1(int temp)
    {
        this.temperatura1 = temp;
    }
    public int getTemperatura1()
    {
        return this.temperatura1;
    }
    //Temperatura 2(Ebulição)
    public void setTemperatura2(int temp)
    {
        this.temperatura2 = temp;
    }
    public int getTemperatura2()
    {
        return this.temperatura2;
    }
    //Soluvel
    public void setSoluvel(bool soluvel)
    {
        this.soluvel = soluvel;
    }
    public bool getSoluvel()
    {
        return this.soluvel;
    }
    //Precisa Misturar
    public void setPrecisa_Misturar(bool precisa)
    {
        this.precisa_Misturar = precisa;
    }
    public bool getPrecisa_Misturar()
    {
        return this.precisa_Misturar;
    }
    //Precisa Calor
    public void setPrecisa_Calor(bool precisa)
    {
        this.precisa_Calor = precisa;
    }
    public bool getPrecisa_Calor()
    {
        return this.precisa_Calor;
    }
    //Precisa Elemento
    public void setPrecisa_Elemento(bool precisa)
    {
        this.precisa_Elemento = precisa;
    }
    public bool getPrecisa_Elemento()
    {
        return this.precisa_Elemento;
    }
    //Dependencia de Elemento
    public void setDependencia(string elemento)
    {
        this.dependencia = elemento;
    }
    public string getDependencia()
    {
        return this.dependencia;
    }
    //
    #endregion
}
