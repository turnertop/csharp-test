public Rigidbody ball_Rigidbody;

void Start()
{
ball_Rigidbody.AddForce(-transform.forward * 2500f);
}


void OnCollisionEnter(Collision collision)
{
	if(collision.gameObject.name == "Cylinder") {
			print("gg get fucked");

	}

}

}
