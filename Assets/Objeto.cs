using UnityEngine;
using System.Collections;

public class Objeto : MonoBehaviour {



	private bool frente;
	private bool tras;
	
	private bool direita;
	private bool esquerda;

	private bool frenteA;
	private bool trasA;
	
	private bool direitaA;
	private bool esquerdaA;


	public GameObject[] objeto;



	/// <summary>
	/// objeto quando for
	/// 0-e o lado superior esquerdo
	/// 1-e o lado superior do meio
	/// 2-e o lado superior direito
	/// 
	/// 3-e o lado medio esquerdo
	/// 4-e o lado medio do meio
	/// 5-e o lado medio direito
	/// 
	/// 6-e o lado inferior esquerdo
	/// 7-e o lado inferior do meio
	/// 8-e o lado inferior direito
	/// 
	/// 9-e o bloco unico quando so existe 1 do tipo
	/// </summary>

	void Start () {



	}




	public void modificar()
	{
		RaycastHit hit;
		if (Physics.Raycast (transform.position, this.transform.forward, out hit)) 
		{
			print ("frente tem object!");
			frente = true;
			hit.collider.gameObject.GetComponent<Objeto>().tras = true;

		}
		if (Physics.Raycast (transform.position, -this.transform.forward, out hit)) 
		{
			print ("atras tem object!");
			tras = true;
			hit.collider.gameObject.GetComponent<Objeto>().frente = true;

		} 
		if (Physics.Raycast (transform.position, this.transform.right, out hit)) 
		{
			print ("a dierita tem object!");
			direita = true;
			hit.collider.gameObject.GetComponent<Objeto>().esquerda = true;

		}
		if (Physics.Raycast (transform.position, -this.transform.right, out hit)) 
		{
			print ("Ta esquerda tem object!");
			esquerda = true;
			hit.collider.gameObject.GetComponent<Objeto>().direita = true;

		}


		frenteA = frente;
		trasA = tras;
		direitaA = direita;
		esquerdaA = esquerda;


		if (esquerda && !direita && !frente && !tras)
		{
			if (this.gameObject != objeto[0].gameObject)
			{
				Instantiate(objeto[0].gameObject,this.transform.position,this.transform.rotation);
				Destroy(this.gameObject);
			}


		}else if (!esquerda && direita && !frente && !tras)
		{
			if (this.gameObject != objeto[1].gameObject)
			{
				Instantiate(objeto[1].gameObject,this.transform.position,this.transform.rotation);
				Destroy(this.gameObject);
			}


		}else if (!esquerda && !direita && frente && !tras)
		{
			if (this.gameObject != objeto[2].gameObject)
			{
			Instantiate(objeto[2].gameObject,this.transform.position,this.transform.rotation);
			Destroy(this.gameObject);
			}


		}else if (!esquerda && !direita && !frente && tras)
		{
			if (this.gameObject != objeto[3].gameObject)
			{
				Instantiate(objeto[3].gameObject,this.transform.position,this.transform.rotation);
				Destroy(this.gameObject);
			}


		}else if (esquerda && direita && !frente && !tras)
		{
			if (this.gameObject != objeto[4].gameObject)
			{
				Instantiate(objeto[4].gameObject,this.transform.position,this.transform.rotation);
				Destroy(this.gameObject);
			}


		}else if (!esquerda && !direita && frente && tras)
		{
			if (this.gameObject != objeto[5].gameObject)
			{
				Instantiate(objeto[5].gameObject,this.transform.position,this.transform.rotation);
				Destroy(this.gameObject);
			}
		}else if (!esquerda && direita && frente && !tras)
		{
			if (this.gameObject != objeto[6].gameObject)
			{
				Instantiate(objeto[6].gameObject,this.transform.position,this.transform.rotation);
				Destroy(this.gameObject);
			}

		}else if (!esquerda && direita && !frente && tras)
		{
			if (this.gameObject != objeto[7].gameObject)
			{
				Instantiate(objeto[7].gameObject,this.transform.position,this.transform.rotation);
				Destroy(this.gameObject);
			}
		}else if (esquerda && !direita && frente && !tras)
		{
			if (this.gameObject != objeto[8].gameObject)
			{
				Instantiate(objeto[7].gameObject,this.transform.position,this.transform.rotation);
				Destroy(this.gameObject);
			}
		}else if (esquerda && !direita && !frente && tras)
		{
			if (this.gameObject != objeto[9].gameObject)
			{
				Instantiate(objeto[7].gameObject,this.transform.position,this.transform.rotation);
				Destroy(this.gameObject);
			}
		}
	}


	void Update(){
		if (direita != direitaA || esquerda != esquerdaA || frente != frenteA || tras != trasA) 
		{
			modificar();
		}



	}



}
