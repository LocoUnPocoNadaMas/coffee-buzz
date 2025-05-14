#if UNITY_EDITOR
using System.IO;
using UnityEngine;

namespace Assets.Scripts
{
    public class CaptureObjects : MonoBehaviour
    {
        public Camera captureCamera; // Cámara que captura los objetos
        public RenderTexture renderTexture; // RenderTexture asignada a la cámara
        public string savePath = "Capturas/";


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }
        }

        // Update is called once per frame
        void Update()
        {
        }

        public void CaptureImage(string fileName)
        {
            RenderTexture.active = renderTexture;
            Texture2D texture = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.RGB24, false);
            texture.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
            texture.Apply();

            byte[] bytes = texture.EncodeToPNG();
            File.WriteAllBytes(savePath + fileName + ".png", bytes);

            RenderTexture.active = null;
            Debug.Log("Imagen guardada en: " + savePath + fileName + ".png");
        }
    }
}
#endif