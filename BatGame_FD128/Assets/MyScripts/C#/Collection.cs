using UnityEngine;

namespace CompleteProject
{
public class Collection : MonoBehaviour 
{
	public int scoreValue = 1;



	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			
			//Destroy(other.gameObject);
			//CollectionAndScore.Score += 1;
			// Increase the score by the enemy's score value.
			ScoreManager.score += scoreValue;
            Destroy(gameObject);
            }
	}

}
}
