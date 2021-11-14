using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomStageManager : MonoBehaviour
{
    public GameObject InventoryWindow;
    public GameObject CraftWindow;
    public GameObject HangerWindow;
    public GameObject BedWindow;
    public GameObject DoorWindow;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnClicked(GameObject window)
    {
        if (!InventoryWindow.activeSelf && !CraftWindow.activeSelf && !HangerWindow.activeSelf && !BedWindow.activeSelf && !DoorWindow.activeSelf)
        {
            window.SetActive(true);
        }
    }
}
