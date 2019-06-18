using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Adrenak.GPUVideoPlayer;


public class VideoTextureAssign : MonoBehaviour
{
    public GPUVideoPlayer _player=null;
    public Material _material = null;
    public Texture2D _texture = null;


    // Start is called before the first frame update
    void Start()
    {
        _player = GetComponent<GPUVideoPlayer>();
        _material = GetComponent<Renderer>().material;
        Texture2D tmpTex = _player.MediaTexture;
    }

    // Update is called once per frame
    void Update()
    {
        if (_texture == null)
        {
            Texture2D tmpTex = _player.MediaTexture;
            if (tmpTex != null)
            {
                _texture = tmpTex;
                _material.SetTexture("_MainTex",_texture);
            }
        }
    }
}
