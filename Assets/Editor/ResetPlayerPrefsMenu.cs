﻿using UnityEngine;
using System.Collections;
using UnityEditor;

public class ResetPlayerPrefsMenu : MonoBehaviour 
{
	[MenuItem ("Stinky/Reset")]
	public static void ResetFile ()
	{
		PlayerPrefs.DeleteAll();
		print ("Player Prefs has been deleted");
	}
}
