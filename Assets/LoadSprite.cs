using UnityEngine;
using System.Collections;

public class LoadSprite : MonoBehaviour {

	public string assetName;
	
	void Start () 
	{
		var item = Resources.Load<TextureAsset>(assetName);
		GetComponent<SpriteRenderer>().sprite = item.sprite;
	}
}
