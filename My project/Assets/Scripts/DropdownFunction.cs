using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownFunction : MonoBehaviour
{
    public GameObject Glass;
    public GameObject RockFull;
    public GameObject Plate;
    public GameObject Oak;
    public GameObject Concrete;
    public GameObject Empty;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // switch statement didn't work :(
    public void DropdownFunctioning(int value){
        if(value == 0){
            RockFull.SetActive(false);
            Glass.SetActive(false);
            Plate.SetActive(false);
            Oak.SetActive(false);
            Concrete.SetActive(false);
            Empty.SetActive(true);
        }

        if(value == 1){
            RockFull.SetActive(false);
            Glass.SetActive(false);
            Plate.SetActive(false);
            Oak.SetActive(false);
            Concrete.SetActive(true);
            Empty.SetActive(false);
        }

        if(value == 2){
            RockFull.SetActive(true);
            Glass.SetActive(false);
            Plate.SetActive(false);
            Oak.SetActive(false);
            Concrete.SetActive(false);
            Empty.SetActive(false);
        }

        if(value == 3){
            RockFull.SetActive(false);
            Glass.SetActive(true);
            Plate.SetActive(false);
            Oak.SetActive(false);
            Concrete.SetActive(false);
            Empty.SetActive(false);
        }

        if(value == 4){
            RockFull.SetActive(false);
            Glass.SetActive(false);
            Plate.SetActive(true);
            Oak.SetActive(false);
            Concrete.SetActive(false);
            Empty.SetActive(false);
        }

        if(value == 5){
            RockFull.SetActive(false);
            Glass.SetActive(false);
            Plate.SetActive(false);
            Oak.SetActive(true);
            Concrete.SetActive(false);
            Empty.SetActive(false);
        }
    }
}
