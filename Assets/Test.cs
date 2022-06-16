using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Test : MonoBehaviour
{
    public string text;
    [SerializeField] private TMP_Text tmpText;

    // Start is called before the first frame update
    void Start()
    {
      if (tmpText)
          tmpText.text = text;
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
