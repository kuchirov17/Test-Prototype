using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class GameManager : MonoBehaviour
{
	public static GameManager gm;
	public MainMenu mm;

	private void Awake()
	{
		if (!gm)
		{
			gm = this;
			DontDestroyOnLoad(this);
		}
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.R))
		{			
			RestartScene();			
		}
	}

	public void RestartScene()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void GameOver()
	{
		Time.timeScale = 0;
		mm.GameOver();
	}

}