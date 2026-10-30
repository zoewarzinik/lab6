using UnityEngine;

public class PinMovement : MonoBehaviour
{
    public float movementSpeed = 10;
    private int flipCount = 2500;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movementThisFrame = movementSpeed * Time.deltaTime;
        if (flipCount <= 1500)
        {
            transform.Translate(movementThisFrame, 0f, 0f);
            flipCount++;
        }
        else if (flipCount <= 3000)
        {
            transform.Translate(-movementThisFrame, 0f, 0f);
            flipCount++;
            if (flipCount == 3000)
            {
                flipCount = 0;
            }
        }
    }   
}
