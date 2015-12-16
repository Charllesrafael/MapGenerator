using UnityEngine;
using System.Collections;

public class olhar : MonoBehaviour {

	public bool mouseEmCima = false;
	public Vector3 pontoMouse = Vector3.zero;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//aff = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		//aff = new Vector3 (aff.x / Camera.main.WorldToScreenPoint(Input.mousePosition), aff.y, aff.x / Camera.main.WorldToScreenPoint(Input.mousePosition));
		if(!mouseEmCima) 
		{

			if (pontoMouse.x > this.transform.position.x+this.transform.localScale.x/2) {
				this.transform.position = new Vector3(this.transform.position.x+this.transform.localScale.x,this.transform.position.y,this.transform.position.z);
			}else if (pontoMouse.x+this.transform.localScale.x < this.transform.position.x+this.transform.localScale.x/2)
			{
				this.transform.position = new Vector3(this.transform.position.x-this.transform.localScale.x,this.transform.position.y,this.transform.position.z);

			}

			if (pontoMouse.z >this.transform.position.z+this.transform.localScale.x/2) {
				this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z+this.transform.localScale.z);
			}else if (pontoMouse.z+this.transform.localScale.x < this.transform.position.z+this.transform.localScale.x/2)
			{
				this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z-this.transform.localScale.z);

			}

		}

		this.transform.LookAt (new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z));


	}
}
