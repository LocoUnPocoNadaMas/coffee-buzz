using System.Collections;
using Assets.Scripts.Model;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ScrollView : MonoBehaviour
    {
        [SerializeField] private GameObject btnPrefab;
        [SerializeField] private RectTransform content;
        [SerializeField] private ItemsDatabaseSo database;
        
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            content = GameObject.Find("Content").GetComponent<RectTransform>();

            foreach (var item in database.Items)
            {
                TextMeshProUGUI txtName = btnPrefab.transform.Find("TxtNameItem").GetComponent<TextMeshProUGUI>();
                txtName.text = item.Name;
                Image imgPreview = btnPrefab.transform.Find("ImgPreviewItem").GetComponent<Image>();
                GameObject btnInstance = Instantiate(btnPrefab, content);
            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
