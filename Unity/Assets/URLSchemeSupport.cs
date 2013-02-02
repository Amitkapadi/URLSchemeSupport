using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public static class URLSchemeSupport {
	
	[DllImport ("__Internal")]
	private static extern bool _isURLSchemeSupported(string urlScheme);
	
	public static bool isURLSchemeSupported(string urlScheme) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			Debug.Log("Found!");
			return _isURLSchemeSupported(urlScheme);
		} else
			return false;
	}
	
}
