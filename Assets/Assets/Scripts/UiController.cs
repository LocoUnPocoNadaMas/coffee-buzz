using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class UiController : MonoBehaviour
    {
        [SerializeField] private ScrollView scrollView;
        private Button _btnBuildMode;
        private Button _btnLiveMode;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _btnBuildMode = GameObject.Find("BtnBuild").GetComponent<Button>();
            _btnLiveMode = GameObject.Find("BtnLive").GetComponent<Button>();
            Debug.Assert(_btnBuildMode != null, "btnBuildMode is null");
            Debug.Assert(_btnLiveMode != null, "btnLiveMode is null");
            _btnLiveMode.gameObject.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnBuild()
        {
            scrollView.gameObject.SetActive(true);
            _btnBuildMode.gameObject.SetActive(false);
            _btnLiveMode.gameObject.SetActive(true);
        }

        private void OnLive()
        {
            scrollView.gameObject.SetActive(false);
            _btnLiveMode.gameObject.SetActive(false);
            _btnBuildMode.gameObject.SetActive(true);
        }
    }
}
