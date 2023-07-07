using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    public MeshRenderer PLS;
    [SerializeField]
    private GameObject[] objectPopup;
    [SerializeField]
    private GameObject[] objectHide;
    private void OnTriggerEnter(Collider collider) {
      if (collider.gameObject.CompareTag("player")) {
        Debug.Log("hit");
        // toggle show objectPopup
        foreach (GameObject obj in objectPopup)
        {
          obj.SetActive(true);
        }
        foreach (GameObject obj in objectHide)
        {
          obj.SetActive(false);
        }
      } 
      PLS.enabled = false;
    }	
    private void OnTriggerExit(Collider collider) {
      if (collider.gameObject.CompareTag("player")) {
        Debug.Log("left");
        // toggle show objectPopup
        foreach (GameObject obj in objectPopup)
        {
          obj.SetActive(false);
        }
        foreach (GameObject obj in objectHide)
        {
          obj.SetActive(true);
        }
      } 
      PLS.enabled = true;
    }	
    // Start is called before the first frame update
    void Start()
    {
      foreach (GameObject obj in objectPopup)
      {
        obj.SetActive(false);
      }
      PLS = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
