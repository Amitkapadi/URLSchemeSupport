using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
	
	
	private bool _showBack = false;
	
	// Use this for initialization
	void Start () {

		
		if (URLSchemeSupport.isURLSchemeSupported("twitter://")) {
			_showBack = true;
			
		}
		
		
	}
	

	
	void OnGUI() {
		
		
		if (_showBack) {
			if (GUI.Button(new Rect(10, 10, 100, 50), "Back")) {
				Application.OpenURL("twitter://");
			}
			
		} else {
			GUI.Label(new Rect(10, 10, 100, 50), "Not Installed");
		}
		
	}
	
	
}
