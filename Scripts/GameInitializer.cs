using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Initializes the game
/// </summary>
public class GameInitializer : MonoBehaviour 
{
    public bool gm = false;
    /// <summary>
    /// Awake is called before Start
    /// </summary>
	void Awake()
    {
        // initialize screen utils
        ScreenUtils.Initialize();
    }
}
