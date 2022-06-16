using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ManagerMainScenes : MonoBehaviour
{
    public TMP_Text displayKidsName;
    public Image displayImage;

    private SoRuntimeData runtimeData;

    void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("Kinderaddierer");

        displayKidsName.text = runtimeData.nameKid;
        SetUserImage(runtimeData.selectedImg);
    }

    void SetUserImage(string imageName)
    {
        displayImage.sprite = Resources.Load<Sprite>(imageName) as Sprite;
    }

    //Aufruf in Inspector OnClick bei Button, generisch über Parameter
    public void SwitchScene(int x)
    {
        SceneManager.LoadScene(x);
    }

}
