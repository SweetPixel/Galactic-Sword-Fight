using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

	public Sprite handle;
	public Sprite handleWithGlow;
	public Sprite sword;
	public Sprite swordWithGlow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Click(string Name)
	{
		if (Name == "Handle") {
			if(GameObject.FindGameObjectWithTag("Handle").GetComponent<Image>().sprite == handle)
			{
				GameObject.FindGameObjectWithTag("Handle").GetComponent<Image>().sprite = handleWithGlow;
				GameObject.FindGameObjectWithTag("Sword").GetComponent<Image>().sprite = swordWithGlow;
			}
			else{
				GameObject.FindGameObjectWithTag("Handle").GetComponent<Image>().sprite = handle;
				GameObject.FindGameObjectWithTag("Sword").GetComponent<Image>().sprite = sword;
			}
		}
	}

}
