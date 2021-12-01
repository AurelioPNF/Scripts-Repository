using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ElementosBase : MonoBehaviour
{
    public Elemento Agua = new Elemento("H2O", "�gua", 1, true, 2, 0, 100, true, false, false, false);

    public Elemento Areia = new Elemento("SiO2", "Areia", 1, false, 1, 1710, 2230, false, false, false, false);

    public Elemento Acucar = new Elemento("C12H22O11", "A��car", 1, false, 1, 186, 99999, true, true, false, false);

    public Elemento Alcool = new Elemento("C2H5OH", "�lcool", 3, true, 2, -114, 78, true, false, false, false);

    public Elemento Lecitina = new Elemento("C11H22NO8P", "Lecitina", 3, false, 1, -99999, 99999, true, true, false, false);

    public Elemento Oleo = new Elemento("CH3(CH2)7CH=CH(CH2)7COOH", "�leo de Palma", 2, false, 2, 13, 210, true, false, false, true, "C11H22NO8P");

    public void Start()
    {
        Agua = new Elemento("H2O", "�gua", 1, true, 2, 0, 100, true, false, false, false);
        Areia = new Elemento("SiO2", "Areia", 1, false, 1, 1710, 2230, false, false, false, false);
        Acucar = new Elemento("C12H22O11", "A��car", 1, false, 1, 186, 99999, true, true, false, false);
        Alcool = new Elemento("C2H5OH", "�lcool", 3, true, 2, -114, 78, true, false, false, false);
        Lecitina = new Elemento("C11H22NO8P", "Lecitina", 3, false, 1, -99999, 99999, true, true, false, false);
        Oleo = new Elemento("CH3(CH2)7CH=CH(CH2)7COOH", "�leo de Palma", 2, false, 2, 13, 210, true, false, false, true, "C11H22NO8P");
    }
    
}
