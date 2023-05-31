using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveUI : MonoBehaviour
{
    [SerializeField] int iPlanes;
    [SerializeField] float fSpeed;

    [SerializeField] Button lButton;
    [SerializeField] Button rButton;

    private RectTransform rt;

    private int iCurrentPlane = 1;

    void Start()
    {
        rt = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (iCurrentPlane)
        {
            case 0:
                MovePlane(1920);
                lButton.gameObject.SetActive(false);
                break;
            case 1:
                MovePlane(0);
                lButton.gameObject.SetActive(true);
                rButton.gameObject.SetActive(true);
                break;
            case 2:
                MovePlane(-1920);
                rButton.gameObject.SetActive(false);
                break;
        }
    }

    public void AddNumber()
    {
        if (iCurrentPlane < iPlanes - 1)
        {
            iCurrentPlane++;
        }
    }

    public void RemoveNumber()
    {
        if (iCurrentPlane > 0)
        {
            iCurrentPlane--;
        }
    }

    private void MovePlane(float f)
    {
        float ff = Mathf.Lerp(rt.anchoredPosition.x, f, fSpeed);

        rt.anchoredPosition = new Vector3(ff, 0, 0);
    }
}
