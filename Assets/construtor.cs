using UnityEngine;
using System.Collections;

public class construtor : MonoBehaviour {

	public float layer;

	private GameObject preview;
	private RaycastHit objetoatual;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) 
			{//objetoatual.collider != null && 
				

				if (objetoatual.normal != hit.normal || objetoatual.collider.gameObject != hit.collider.gameObject){
					//objetoatual.collider.gameObject.GetComponent<MeshRenderer> ().material.color = Color.white;
					objetoatual = hit;
					Destroy(preview.gameObject);
					preview = (GameObject)Instantiate (hit.collider.gameObject, hit.collider.gameObject.transform.position + hit.normal, hit.collider.gameObject.transform.localRotation);
				preview.GetComponent<MeshRenderer> ().material.color= new Color(Color.blue.r,Color.blue.g,Color.blue.b,0.5f);
					preview.GetComponent<Collider> ().enabled = false;
					preview.collider.gameObject.GetComponent<MeshRenderer> ().material.color = Color.blue;
				}	

				if (hit.collider.gameObject != objetoatual.collider.gameObject) {
					objetoatual.collider.gameObject.GetComponent<MeshRenderer> ().material.color = Color.white;

				}
				
				if(preview == null)
					preview = (GameObject)Instantiate (hit.collider.gameObject, hit.collider.gameObject.transform.position + hit.normal, hit.collider.gameObject.transform.localRotation);
					preview.GetComponent<MeshRenderer> ().material.color= new Color(Color.blue.r,Color.blue.g,Color.blue.b,0.5f);
					preview.GetComponent<Collider> ().enabled = false;
				if (Input.GetMouseButtonDown (0)) 
				{
					
				objetoatual.collider.gameObject.GetComponent<MeshRenderer> ().material.color = Color.white;
					//Vector3 reflectVec = Vector3.Reflect(incomingVec, hit.normal);
					//Debug.DrawLine(gunObj.position, hit.point, Color.red);
					Debug.DrawRay (objetoatual.point, objetoatual.normal, Color.green);
					Debug.Log (objetoatual.distance);
//					hit.collider.gameObject.GetComponent<MeshRenderer> ().material.color = Color.blue;
					preview.GetComponent<MeshRenderer> ().material.color= Color.white;///.r,Color.white.g,Color.white.bnew Color(hit.collider.gameObject.GetComponent<MeshRenderer> ().material.color.r,hit.collider.gameObject.GetComponent<MeshRenderer> ().material.color.g,hit.collider.gameObject.GetComponent<MeshRenderer> ().material.color.b,1f);
					preview.GetComponent<Collider> ().enabled = true;
					preview = null;
				}
			} else if (preview != null) 
			{
				objetoatual.collider.gameObject.GetComponent<MeshRenderer> ().material.color = Color.white;
				Destroy(preview.gameObject);
				
			}
			


	}

//	void OnMouseEnter()
//	{
//		RaycastHit hit;
//		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//		if (Physics.Raycast(ray, out hit)) {
//			hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
//			
//		}
//	}
//
//	void OnMouseExit()
//	{
//		RaycastHit hit;
//		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//		if (Physics.Raycast(ray, out hit)) {
//			hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
//			
//		}
//	}
}
