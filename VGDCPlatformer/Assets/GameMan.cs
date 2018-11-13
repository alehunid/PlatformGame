using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameMan : MonoBehaviour {

    public Tilemap DarkMap;
    public Tilemap BlurredMap;
    public Tilemap BackgroundMap;

    public Tile DarkTile;
    public Tile BlurredTile;

	// Use this for initialization
	void Start () {
        DarkMap.origin = BlurredMap.origin = BackgroundMap.origin;
        DarkMap.size = BlurredMap.size = BackgroundMap.size;

        foreach (Vector3Int p in DarkMap.cellBounds.allPositionsWithin) {
            DarkMap.SetTile(p, DarkTile);
        }

        foreach (Vector3Int p in BlurredMap.cellBounds.allPositionsWithin) {
            BlurredMap.SetTile(p, BlurredTile);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
