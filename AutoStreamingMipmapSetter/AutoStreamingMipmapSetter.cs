using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AutoStreamingMipmapSetter : AssetPostprocessor
{
    void OnPreprocessTexture()
    {
        TextureImporter Ti = assetImporter as TextureImporter;

        if (!Ti.mipmapEnabled || Ti.streamingMipmaps)
        {
            return;
        }

        Ti.streamingMipmaps = true;
    }
}
