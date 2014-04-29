using UnityEngine;
using System.Collections;
using Chartboost;

public class GuiEnabler : MonoBehaviour {
	[SerializeField] GameObject uiRoot;

#if UNITY_IPHONE || UNITY_ANDROID
	// Update is called once per frame
	void Update () {
		if (uiRoot != null) uiRoot.SetActive(!CBBinding.isImpressionVisible());
	}
#endif
}
