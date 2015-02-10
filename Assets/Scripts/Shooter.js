#pragma strict

var bullet : Rigidbody; //creates the projectile
var power : float = 1500; //this is the stregnth of the projectile
var moveSpeed : float = 5; //this is how fast the projectile moves

function Update () {

	var h : float = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; //will control the x axis [<-- --> or a d ]for movement
	var v : float = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed; //will control the y axis [^ v or w s] for movement

	transform.Translate(h,v,0);

	if(Input.GetButtonUp("Fire1")){ //if left click is pressed, fire

		var instance: Rigidbody = Instantiate(bullet, transform.position, transform.rotation); //will create the projectile
		var fwd: Vector3 = transform.TransformDirection(Vector3.forward); //this will make the bullet shoot forward
	
		instance.AddForce(fwd * power); //will give the bullet the ability to go forward
	}	

}