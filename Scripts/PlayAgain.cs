﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayAgain : MonoBehaviour
{
	public string LevelToLoad;

	public void loadLevel()
	{
		//Load the level from LevelToLoad
		Application.LoadLevel(LevelToLoad);
	}
}