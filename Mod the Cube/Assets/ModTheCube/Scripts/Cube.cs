using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    float timeLeft;
    Color targetColor;

    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 2f;
        
        Material material = Renderer.material;
        
        material.color = new Color(Random.value, Random.value , Random.value, Random.value);
    }
    
    void Update()
    {
        if (timeLeft <= Time.deltaTime)
        {
            // transition complete
            // assign the target color
            Renderer.material.color = targetColor;
            
            // start a new transition
            targetColor = new Color(Random.value, Random.value, Random.value);
            timeLeft = 1.0f;
        }
        else
        {
            // transition in progress
            // calculate interpolated color
            Renderer.material.color = Color.Lerp(Renderer.material.color, targetColor, Time.deltaTime / timeLeft);

            // update the timer
            timeLeft -= Time.deltaTime;
        }
        transform.Rotate(20.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
