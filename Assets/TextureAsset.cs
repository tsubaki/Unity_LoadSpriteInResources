using UnityEngine;
using System.Collections;
using System.IO;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class TextureAsset : ScriptableObject 
{
	public Sprite sprite;
	
	void OnDestroy()
	{
		Resources.UnloadAsset(sprite);
	}
	
#if UNITY_EDITOR	
	
	
	[MenuItem("Assets/CreateSpriteObject")]
	static void CreateSpriteObject()
	{
		var spriteType = typeof(Sprite);
		var textureType = typeof(Texture);
		
		foreach( var item in Selection.objects )
		{
			if( item.GetType()  !=  spriteType)
			{
				continue;
			}
			
			
			var assetPath = AssetDatabase.GetAssetPath(item);
			var parentDirectry = Path.GetDirectoryName(assetPath) + "/Resources";
			
			Directory.CreateDirectory(parentDirectry);
			var path = string.Format("{0}/{1}.asset", parentDirectry, item.name);
			CreateSprite(path, (Sprite)item);
		}
		
	}
		static void CreateSprite(string path, Sprite sprite)
		{
			TextureAsset obj = ScriptableObject.CreateInstance<TextureAsset>();
			obj.sprite = sprite;
			AssetDatabase.CreateAsset (obj, path);
		}
	
#endif	
}
