using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enigme1 : MonoBehaviour
{
	//les iles
	public GameObject[] iles;

    public GameObject reset;
	
	//Les liens 
	public GameObject[] premierslien;
	public GameObject[] deuxiemelien;
	
	public GameObject commode_open;
	

	private bool[] etat_iles;
	private int etat_clic = 0;
	private int savnumero1;
	
	
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
	public void verifier_etat()
    {
		if((premierslien[0].activeSelf & !deuxiemelien[0].activeSelf ) & (premierslien[1].activeSelf & deuxiemelien[1].activeSelf )& (premierslien[2].activeSelf & !deuxiemelien[2].activeSelf )& (premierslien[3].activeSelf & !deuxiemelien[3].activeSelf )& (premierslien[4].activeSelf & deuxiemelien[4].activeSelf )& (!premierslien[5].activeSelf & !deuxiemelien[5].activeSelf )& (premierslien[6].activeSelf & deuxiemelien[6].activeSelf )& (premierslien[7].activeSelf & !deuxiemelien[7].activeSelf ))
		{
			//return true;
			commode_open.SetActive(true);
		}
		//return false;
			
        //Si l'ile 1 a une attache (chercher le script) avec les bonnes iles et que elles, puis si ile 2 ....
        //Retourne Vrai
    }
	
	public void cliquerBoutonNonActif(int numero)
	{
		
		if (etat_clic<1)
		{
		   iles[numero-1].GetComponent<Renderer>().material.SetColor("_Color", Color.red);
		   print(etat_clic);
		   etat_iles[numero] = !etat_iles[numero];
		   savnumero1=numero;
		   etat_clic +=1;
		}
		else
		{
			iles[savnumero1-1].GetComponent<Renderer>().material.SetColor("_Color", Color.grey);
			iles[numero-1].GetComponent<Renderer>().material.SetColor("_Color", Color.grey);
			fairelien(savnumero1,numero);
			etat_clic=0;
		}

    }	
	
	private void fairelien(int numile1, int numile2)
	{
		//if (numile1==1 & numile2==2)
		//{
		//	if(!premierslien[0].activeSelf)
		//		premierslien[0].SetActive(true);
		//	else
		//		deuxiemelien[0].SetActive(true);
		//}	
		int placelien=100;
		if (numile1==1 & numile2==2 | numile1==2 & numile2==1)
			placelien=0;
		if (numile1==2 & numile2==3 | numile1==3 & numile2==2)
			placelien=1;
		if (numile1==4 & numile2==5 | numile1==5 & numile2==4)
			placelien=2;
		if (numile1==5 & numile2==6 | numile1==6 & numile2==5)
			placelien=3;
		if (numile1==1 & numile2==4 | numile1==4 & numile2==1)
			placelien=4;
		if (numile1==2 & numile2==5 | numile1==5 & numile2==2)
			placelien=5;
		if (numile1==3 & numile2==6 | numile1==6 & numile2==3)
			placelien=6;
		if (numile1==4 & numile2==7 | numile1==7 & numile2==4)
			placelien=7;
		if(placelien != 100)
		{
			if(!premierslien[placelien].activeSelf)
				premierslien[placelien].SetActive(true);
			else
				deuxiemelien[placelien].SetActive(true);
		}
		
    }	
	
	public void resetLiens()
	{
        for(int i=0; i<8;i++)
		{
			premierslien[i].SetActive(false);
			deuxiemelien[i].SetActive(false);
		}
    }
}
