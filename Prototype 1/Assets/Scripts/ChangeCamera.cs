using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("c")) 
        {
            if (cam.activeSelf)
            {
                Debug.Log(cam.activeSelf);
                cam.SetActive(false);
            }
            else
            {
                Debug.Log(cam.activeSelf);
                cam.SetActive(true);
            }
        }
    }
}
