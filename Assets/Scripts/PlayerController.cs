using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	/*The 3-dimensional vector that will represent the current direction
	 * that the character is currently moving in. Though it has three dimensions (x,y, & z);
	 * we'll only be directly manipulating two of them ( x & y ) in our game logic. 
	 * 
	 * Note that this vector is not meant do represent distance of travel, only direction.
	 * The x coordinate of the vector represents the horizontal direction:
	 * 		- negative value = left
	 * 		- positive value = right
	 * Similarly, for the y coordinate:
	 * 		- negative = down
	 * 		- positive = up
	*/
	public Vector3 directionVector = Vector3.zero; // Initialize it to zero

	/* Represents the amount of distance that character will travel in a single
	 * "step" of the game's update cycle, effectively defining how fast it moves.
	 */
	public float speed = 10f;


	// Use this for initialization
	void Awake () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		directionVector = GetDirectionInput();

		//Move character in the direction specified by inputVector
		MoveCharacter(directionVector);
	}

	/* Read the state of the Horizontal & Vertical input axis and 
		return a vector representing the inputed direction. 
	 */
	Vector3 GetDirectionInput()
	{
		
		float horizontalInput = Input.GetAxisRaw ("Horizontal");

		return new Vector3 (horizontalInput, 0f, 0f);
	}

	/* Moves the player character in the direction specified by the x and y coordinates
	 *  of moveVector
	 */
	void MoveCharacter( Vector3 moveVector )
	{
		gameObject.transform.Translate (moveVector * speed * Time.deltaTime);
	}
}