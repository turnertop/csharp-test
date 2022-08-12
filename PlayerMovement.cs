public class PlayerMovement : MonoBehaviour
{
		public Rigidbody my_Rigidbody;

		void Start()
		{


		}


		void FixedUpdate()
		{
		if (Input.GetKey("left") || Input.GetKey("right"))
			{
				Vector3 my_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"), 0)


			}

		}

}
