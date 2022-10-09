using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Test : MonoBehaviour {
    public Button button;
    public TMP_Text textMain;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("시작!");
        button.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnClick() {
        textMain.text = "Click!";
    }
}
