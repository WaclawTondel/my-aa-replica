using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
	public static int PinsLeft;

	public Text Text;

	void Start ()
	{
		PinsLeft = 3;
	}

	void Update ()
	{
		Text.text = PinsLeft.ToString();
	}
}
