using UnityEngine;
using System.Collections;

public class selecao : MonoBehaviour {

	public GameObject selecao1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (ray, out hit)) 
		{
			if (hit.collider.tag == "selecao") {
				selecao1.GetComponent<olhar>().mouseEmCima = true;
			}else
				selecao1.GetComponent<olhar>().mouseEmCima = false;

			selecao1.GetComponent<olhar>().pontoMouse = hit.point;
		}else
		{
			selecao1.GetComponent<olhar>().mouseEmCima = false;
		}
	}
}
