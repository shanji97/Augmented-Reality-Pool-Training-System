using UnityEngine;

public class MenuFunctions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void QuitApplication()
    {
        if (Application.isEditor)
            Debug.Log("Cannot quit inside the Unity Editor");
        else
           Application.Quit();

    }

}
