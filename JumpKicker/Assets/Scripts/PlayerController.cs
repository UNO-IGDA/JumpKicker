using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	/*The 3-dimensional vector that will represent the current direction
	 * that the character is currently moving in. Though it has three dimensions (x,y, & z);
	 * we'll only be directly manipulating two of them ( x & y ) in our game logic. 
	 * 
	 * Note that this vector is not meant do represent distance of travel, only direction.
	*/
	public Vector3 directionVector = Vector3.zero;

	/* Represents the amount of distance that character will travel in a single
	 * "step" of the game's update cycle, effectively defining how fast it moves.
	 */
	public float speed = 10f;


	// Use this for initialization
	void Awake () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Read and Store the three dimensional vector that will 
		directionVector = GetDirectionVector();

		//Move character in the direction specified by inputVector
		MoveCharacter(directionVector);
	}

	Vector3 GetDirectionVector()
	{
		float horizontalInput = Input.GetAxisRaw ("Horizontal");

		return new Vector3 (horizontalInput, 0f, 0f);
	}

	//Moves the player character in the direction of the 
	void MoveCharacter( Vector3 moveVector )
	{
		gameObject.transform.Translate (moveVector * speed * Time.deltaTime);
	}
}