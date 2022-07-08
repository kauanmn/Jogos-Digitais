using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Menu : MonoBehaviour
{
    public Button btn;
    public Text titleText;

    void Start () {
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick() {
        SceneManager.LoadScene("Game");
    }

    void Update() {
        if(Time.timeSinceLevelLoad <= 0.25f)
            titleText.text = "L";
        else if(Time.timeSinceLevelLoad <= 0.50f)
            titleText.text = "LA";
        else if(Time.timeSinceLevelLoad <= 0.75f)
            titleText.text = "LAB";
        else if(Time.timeSinceLevelLoad <= 1.0f)
            titleText.text = "LAB 1";
        
        if(Time.timeSinceLevelLoad > 1.25f)
            btn.gameObject.SetActive(true);
    }
}
