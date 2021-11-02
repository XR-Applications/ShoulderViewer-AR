using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ImmersiveShoulderControl : MonoBehaviour
{

    [SerializeField] Transform targetRef;

    [SerializeField] Transform wholeComplexRef;

    //rotate speed multiplier
    [SerializeField] float rotateSpeed = 5f;

    private int adduct, abduct, flex, extend, intRotate, extRotate = 0;
    private int turnLeft, turnRight = 0;

    bool shoulderIsLaunched = false;
    bool searchIconShowing = true;

    private void Awake()
    {
            shoulderIsLaunched = true;
            wholeComplexRef.gameObject.SetActive(true);
    }
    private void Update()
    {
        RotateUpperArm();
        RotateWholeComplex();
    }

    private void RotateWholeComplex()
    {
        if (turnLeft == 1)
        {
            wholeComplexRef.Rotate(0f, rotateSpeed * Time.deltaTime * 1, 0f, Space.World);
        }
        if (turnRight == 1)
        {
            wholeComplexRef.Rotate(0f, rotateSpeed * Time.deltaTime * -1, 0f, Space.World);
        }
    }

    public void TurnComplexLeft()
    {
        turnLeft = 1;
    }
    public void TurnComplexRight()
    {
        turnRight = 1;
    }
    private void RotateUpperArm()
    {
        if (adduct == 1)
        {
            //rotate along z axis positively
            targetRef.Rotate(0f, 0f, rotateSpeed * Time.deltaTime * -1, Space.Self);
        }
        if (abduct == 1)
        {
            //rotate along z axis negatively
            targetRef.Rotate(0f, 0f, rotateSpeed * Time.deltaTime * 1, Space.Self);
        }
        if (flex == 1)
        {
            //rotate along x axis positively
            targetRef.Rotate(rotateSpeed * Time.deltaTime * 1, 0f, 0f, Space.Self);
        }
        if (extend == 1)
        {
            //rotate along x axis negatively
            targetRef.Rotate(rotateSpeed * Time.deltaTime * -1, 0f, 0f, Space.Self);
        }
        if (intRotate == 1)
        {
            //rotate along y axis positively
            targetRef.Rotate(0f, rotateSpeed * Time.deltaTime * 1, 0f, Space.World);
        }
        if (extRotate == 1)
        {
            //rotate along y axis negatively
            targetRef.Rotate(0f, rotateSpeed * Time.deltaTime * -1, 0f, Space.World);
        }
    }

    //called on Button Pointer Down
    public void Adduct()
    {
        adduct = 1;
    }
    public void Abduct()
    {
        abduct = 1;
    }
    public void Flex()
    {
        flex = 1;
    }
    public void Extend()
    {
        extend = 1;
    }
    public void InternalRotate()
    {
        intRotate = 1;
    }
    public void ExternalRotate()
    {
        extRotate = 1;
    }

    //called when Pointer Up is called on any button
    public void LetUp()
    {
        turnRight = 0;
        turnLeft = 0;
        adduct = 0;
        abduct = 0;
        flex = 0;
        extRotate = 0;
        intRotate = 0;
        extend = 0;
    }
 
}


