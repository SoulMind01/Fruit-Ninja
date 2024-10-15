using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    bool isCutting = false;
    public GameObject bladeTrailPrefab;
    GameObject currentBladeTrail;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCutting();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopCutting();
        }

        if (isCutting)
        {
            UpdateBladePosition();
        }
    }

    void UpdateBladePosition()
    {
        if (currentBladeTrail != null)
        {
            Vector2 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentBladeTrail.transform.position = newPosition;
        }

    }

    void StartCutting()
    {
        isCutting = true;
        bladeTrailPrefab.SetActive(true);
        currentBladeTrail = Instantiate(bladeTrailPrefab, transform);
    }

    void StopCutting()
    {
        isCutting = false;
        bladeTrailPrefab.SetActive(false);
        Destroy(currentBladeTrail);
    }


}
