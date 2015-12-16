using UnityEngine;
using System.Collections;

public class geradormap : MonoBehaviour {

	public Texture2D textura;
	public GameObject[] objetos;
	public Color[] cor;

	private Color corRecebida;
	private Color corRecebidaANTERIOR;
	private int numero;


	private Vector4[] cor2;


	//escala de gerador
	//public float escalax;
	//public float escalay;
	public float Layer = 0;

	// Use this for initialization
	void Start () {

	}

	void GerarMap()
	{
		cor2 = new Vector4[cor.Length];
		for (int i = 0; i < cor.Length; i++) 
		{
			cor2[i] = cor[i];
		}
		Debug.Log(cor2[0]);
		Debug.Log(cor2[1]);
		if (!textura) {
			Debug.Log("sem textura");
		}else
		{
			Debug.Log("a"+textura.width);
			Debug.Log("b"+textura.height);
//			corRecebida = textura.GetPixel(0,0);




			

			for (int i = 0; i < textura.width; i++) 
			{
				for (int a = 0; a < textura.height; a++) 
				{
					corRecebida = textura.GetPixel(i,a);
					//Debug.Log(corRecebida );
					if (corRecebida !=corRecebidaANTERIOR) 
					{

						Debug.Log("cor recebida: "+corRecebida);
						for (int t = 0; t < cor.Length; t++) 
						{
							if ((corRecebida.r == cor[t].r) && (corRecebida.g == cor[t].g) && (corRecebida.b == cor[t].b)) 
							{
								Debug.Log("criado: "+t);
								Instantiate(objetos[t], new Vector3(this.transform.position.x+objetos[t].transform.localScale.x*i,Layer ,this.transform.position.z+ objetos[t].transform.localScale.z*a), Quaternion.identity);
								numero = t;
							}
						}

						corRecebidaANTERIOR = corRecebida;
					}else
					{
						Instantiate(objetos[numero], new Vector3(this.transform.position.x+objetos[numero].transform.localScale.x*i,Layer ,this.transform.position.z+ objetos[numero].transform.localScale.z*a), Quaternion.identity);

					}
					
				}
			}
			
		}


	}

	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown(KeyCode.G)) 
		{
			GerarMap();
		}

	}
}
