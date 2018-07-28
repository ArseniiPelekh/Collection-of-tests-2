using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;

public class ControlGame : MonoBehaviour {

    public GameObject colBlock;
    public Vector3[] positions;
    //private GameObject block;
    private GameObject[] blocks = new GameObject[4];
    private int _namberAnsver = 1;
    private int resultNamber = 0;
    private int _countTest = 0;

    private GameObject dbTest;

    public GameObject menuGame, menuLose, minPng, middlePng, maxPng;

    //private int count;
    public Text score, result, text;

    public TextAsset textAsset; 

    [HideInInspector]
    public bool next, lose;

    public void SetResultNamber()
    {
        resultNamber++;
    }

    void Start()
    {
        dbTest = GameObject.Find("Canvas");

        /////////////////////////////////////////////////////
        score.text = dbTest.GetComponent<ControlTest>().GetExeption();
        
        _namberAnsver = dbTest.GetComponent<ControlTest>().GetVidpovid(_countTest) +1;

        next = false;
        lose = false;

        score.text = dbTest.GetComponent<ControlTest>().GetText(_countTest);

        for (int i = 0; i < positions.Length; i++)
        {
            NewMethod(i);
            blocks[i].GetComponent<NameButton>().GetNameButton = i + 1;
        }
    }

    /// ///////////////////////////////////////////////////

    private void NewMethod(int i)
    {
        blocks[i] = Instantiate(colBlock, positions[i], Quaternion.identity) as GameObject;
    }

    void Update()
    {
        if (lose)
            playerLose();
        if (next && !lose)
        {
            nextColors();
        }
    }

    void nextColors()
    {
        _countTest++;
        if (_countTest < dbTest.GetComponent<ControlTest>().GetLenghList)
        {
            _namberAnsver = dbTest.GetComponent<ControlTest>().GetVidpovid(_countTest) +1;
            score.text = dbTest.GetComponent<ControlTest>().GetText(_countTest);

            next = false;
            lose = false;
        }
        else
        {
            playerLose();
            resultNamber++;
        }
    }

    public int GetNamAnsve()
    {
        return _namberAnsver;
    }

    void playerLose()
    {
        for (int i = 0; i < blocks.Length; i++)
            blocks[i].SetActive(false);
        menuGame.SetActive(false);
        menuLose.SetActive(true);
        result.text = resultNamber.ToString() + "/" + dbTest.GetComponent<ControlTest>().GetLenghList;
        if (resultNamber < 5)
        {
            text.text = "Плохой результат, нужно стараться ещё!";
            minPng.SetActive(true);
        }
        else if (resultNamber < 9 && dbTest.GetComponent<ControlTest>().GetLenghList > 8)
        {
            text.text = "Очень даже не плохо, ещё чуть-чуть!";
            middlePng.SetActive(true);
        }
        else
        {
            text.text = "Отличный результат!!!";
            maxPng.SetActive(true);
        }
        next = false;
    }
}