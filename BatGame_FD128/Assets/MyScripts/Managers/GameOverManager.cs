using UnityEngine;

namespace CompleteProject
{
	public class GameOverManager : MonoBehaviour
	{
		public float restartDelay = 5f;
		
		Animator anim;                          // Reference to the animator component.
		float restartTimer;
		
		void Awake ()
		{
			// Set up the reference.
			anim = GetComponent <Animator> ();
		}
		
		
		void Update ()
		{
			// If the player has run out of health...
			if(ScoreManager.currentHealth <= 0)
			{
				// ... tell the animator the game is over.
				anim.SetTrigger ("GameOver");
				restartTimer += Time.deltaTime;

				if (restartTimer >= restartDelay)
				{
					Application.LoadLevel (Application.loadedLevel);
				}
			}

			if(ScoreManager.score >= 3)
			{
				// ... tell the animator the game is over.
				anim.SetTrigger ("YouWin");
				restartTimer += Time.deltaTime;
				
				if (restartTimer >= restartDelay)
				{
					Application.LoadLevel (Application.loadedLevel);
				}
			}
		}
	}
}