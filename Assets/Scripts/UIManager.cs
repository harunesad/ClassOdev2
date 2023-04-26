using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace ClassOdev2.UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] TMP_InputField text;
        [SerializeField] TextMeshProUGUI errorText;
        private void Awake()
        {
            
        }
        public void TextChanged()
        {
            Debug.Log(text.text);
        }
        public void TextChange()
        {
            if (text.text.Length < 8)
            {
                errorText.gameObject.SetActive(true);
            }
            else
            {
                errorText.gameObject.SetActive(false);
            }
        }
    }//class
}
