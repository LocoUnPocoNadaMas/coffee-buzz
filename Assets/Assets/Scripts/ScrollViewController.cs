using Assets.Scripts.Model;
using UnityEngine;
using UnityEngine.Serialization;

namespace Assets.Scripts
{
    public class ScrollView : MonoBehaviour
    {
        [SerializeField] private GameObject btnPrefab;
        [SerializeField] private RectTransform content;
        private DataItem _dataItem;
        
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            content = GameObject.Find("Content").GetComponent<RectTransform>();
            for (int i = 0; i < 10; i++)
            {
                
                GameObject newButton = Instantiate(btnPrefab, content);
            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
