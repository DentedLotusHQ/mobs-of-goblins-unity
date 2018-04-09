using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Tilemaps;

public class ObstacleTile : Tile {

#if UNITY_EDITOR
// The following is a helper that adds a menu item to create a RoadTile Asset
    [MenuItem("Assets/Create/Tiles/Obstacle")]
    public static void CreateObstacleTile()
    {
        string path = EditorUtility.SaveFilePanelInProject("Save Obstacle Tile", "New Obstacle Tile", "Asset", "Save Obstacle Tile", "Assets");
        if (path == "")
            return;
    AssetDatabase.CreateAsset(ScriptableObject.CreateInstance<ObstacleTile>(), path);
    }
#endif
}

