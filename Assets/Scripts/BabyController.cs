using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class BabyController : MonoBehaviour {

    
    private float babyPositionX;
    private float babyPositionY;
    private float currentPower;
    private bool isShooting;

    private GameObject babyClone;
    private GameObject BabyClone
    {
        get
        {
            return babyClone;
        }
    }

    public GameObject baby;

    [HideInInspector] public Rigidbody2D rb;


    public float powerChargeSpeed;
    public Slider powerBar;


    void Init()
    {

        powerBar = GetComponent<Slider>();
        baby = GetComponent<GameObject>();
        rb = GetComponent<Rigidbody2D>();


    }
    
    void Trajectory()
    {

    }

    void PrepareShoot()
    {
        if (Input.GetKey("mouse 0") == true && currentPower <= powerBar.maxValue)
        {
            currentPower += Time.deltaTime * powerChargeSpeed;
            powerBar.value = currentPower;
            Debug.Log("current power is now: " + currentPower);
            isShooting = false;
        }

        if (Input.GetKey("mouse 0") == false)
        {
            currentPower = 0;
            powerBar.value = currentPower;
            isShooting = true;
        }
    }

    void Shoot()
    {
        if (isShooting == true)
        {
            babyClone = Instantiate(baby, transform.position, Quaternion.identity)as GameObject;
            
        }
    }

    void Update()
    {
        PrepareShoot();

        Trajectory();
    }

}
