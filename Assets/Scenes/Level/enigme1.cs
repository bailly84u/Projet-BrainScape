using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enigme1 : MonoBehaviour
{
	public GameObject lien1;
    public GameObject ile1;
    public GameObject ile2;
    public GameObject ile3;
    public GameObject ile4;
    public GameObject ile5;
    public GameObject ile6;
    public GameObject ile7;
    public GameObject reset;
	

	public bool[] etat_iles;
	public int etat_clic = 0;
	
    // Start is called before the first frame update
    void Start()
    {
         etat_iles = new bool[] { false,false,false,false,false,false,false,false,false,false};
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Retourne Vrai si les attaches sont correctement mises, activer via un bouton ? 
	public bool verifier_etat()
    {
        return true;
        //Si l'ile 1 a une attache (chercher le script) avec les bonnes iles et que elles, puis si ile 2 ....
        //Retourne Vrai
    }
	
	public void cliquerBoutonNonActif(int numero)
	{
		
		if (etat_clic<2)
		{
			
		   etat_iles[numero] = !etat_iles[numero];
		   
		   etat_clic +=1;
		}
		else
		{
			fairelien();
			etat_clic=0;
		}

    }	
	
	private void fairelien()
	{
		lien1.SetActive(true);
    }	
}
