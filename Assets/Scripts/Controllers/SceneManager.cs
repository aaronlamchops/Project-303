using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour {

	public void LoadScene(string scene)
	{
		Application.LoadLevel (scene);
	}

}
