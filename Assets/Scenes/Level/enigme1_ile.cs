using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enigme1_ile : MonoBehaviour
{
    [Tooltip("Nombre maximum de liaisons qu'on peut faire")]
    public int nombre_attaches_max;
    //Nombre de liaisons effectuées
    private int nombre_attaches;
    //Liste des iles ou cet objet est attache
    private List<GameObject> iles_attachees;

   

    // Start is called before the first frame update
    void Start()
    {
        nombre_attaches = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Ajout d'une ile
    void ajouterAttache(GameObject ile)
    {
        if(nombre_attaches <= nombre_attaches_max)
        {
            iles_attachees.Add(ile);
            nombre_attaches += 1;
        }
    }
    //Retrait d'une ile
    void retraitAttache(GameObject ile)
    {

        iles_attachees.Remove(ile);
    }
    //Reset
    void reset()
    {
        iles_attachees.Clear();
        nombre_attaches = 0;
    }
}
