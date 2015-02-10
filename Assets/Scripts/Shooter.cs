using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public Rigidbody bullet; //what makes the projectile
	public float power = 1500f; //floats are decimals
	public float moveSpeed = 2f; //and must end with f

	// Update is called once per frame
	void Update () {

		float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; //will control the x axis [<-- --> or a d] for movement
		float v = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed; //will control the y axis [^ v or w s] for movement

		transform.Translate(h,v,0);

		if(Input.GetButtonUp("Fire1")){ //if left click is pressed, fire a projectile

			Rigidbody instance = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody; //will create the projectile
			Vector3 fwd = transform.TransformDirection(Vector3.forward); //this will make the bullet shoot forward

			instance.AddForce(fwd * power); //will give the bullet the ability to go forward
		}
	}
}
