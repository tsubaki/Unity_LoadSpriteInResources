#使い方

###オブジェクトを作る

1.  特定の**Sprite**を選択する。
2.  **Assets/CreateSpriteObject** を選択

特定のフォルダ以下のSpriteを選択したい場合、  
projectブラウザの検索バーに「t:sprite」と入力し、  
Searchの隣のタブを設定し検索範囲をAssets以下から特定のフォルダに変更。



###呼び出す

1.  以下のようにスプライトを呼び出す。

```
var sprite = Resources.Load<TextureAsset>(assetName).sprite = item.sprite;
```

この方法で呼び出すと、SpritePackerとして同一テクスチャにAtlas化されている全てのスプライトが呼ばれてしまう事と同義。

###ヒント

Resourcesは、指定以下のパックをそのまま保持し、特定のアセットを取得する機能。
そのため、Resources以下に置いたSpriteはSpritePackerによってパックされない。

ResourcesからAtlas化したテクスチャを呼びたい場合、素直にTexturePackerでパックした方が良い。

その他：http://tsubakit1.hateblo.jp/entry/20131222/1387654182