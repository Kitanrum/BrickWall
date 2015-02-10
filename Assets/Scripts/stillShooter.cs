using UnityEngine;
using System.Collections;

public class stillShooter : MonoBehaviour {

	public Rigidbody bullet; //what makes the projectile
	public float power = 1500f; //floats are decimals
	public float moveSpeed = 30f; //and must end with f
	public static float vRot;

	// Update is called once per frame
	void Update () {
			
		RotateX();

		Fire();

	}

	void Fire(){

			if(Input.GetButtonUp("Fire1")){ //if left click is pressed, fire a projectile

				Rigidbody instance = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody; //will create the projectile
				Vector3 fwd = transform.TransformDirection(Vector3.forward); //this will make the bullet shoot forward

				instance.AddForce(fwd * power); //will give the bullet the ability to go forward
			}

	}



	void RotateX (){

		//float h = Input.GetAxis("Horizontal") * moveSpeed;
		vRot = transform.localRotation.x;
		float v = 6 * moveSpeed * Time.deltaTime;
		Debug.Log(vRot);

			transform.Rotate(v,0,0);

		/*if(vRot >= 330f){
			transform.Rotate(-v,0,0);
		}*/

		if(vRot >= -0.45f){
			
				transform.Rotate(v,0,0);
			}

		if(vRot >= 0.45f) {
			transform.Rotate(-1,0,0);
		}


	}
}
