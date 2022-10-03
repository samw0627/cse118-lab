/* This code is adapted from Youtube tutorial from 
"How To Create A Whiteboard In Unity VR by Justin P Barnette
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whiteboard : MonoBehaviour
{
    public Texture2D texture;
    public Vector2 textureSize = new Vector2(2048,2048);
    
    // Start is called before the first frame update
    void Start()
    {
        var r = GetComponent<Renderer>();
        texture = new Texture2D((int)textureSize.x,(int)textureSize.y);
        r.material.mainTexture = texture;
    }

}
