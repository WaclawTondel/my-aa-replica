using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	private bool gameHasEnded = false;

	public Circle circle;
	public Spawner spawner;

	public Animator animator;
	public void EndGame()
	{
		if (!gameHasEnded)
		{
			gameHasEnded = true;
			spawner.enabled = false;
			circle.enabled = false;

			animator.SetTrigger("EndGame");
		}
	}

	public void RestartLevel ()
	{
		Circle.pins = new List<Pin>();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
