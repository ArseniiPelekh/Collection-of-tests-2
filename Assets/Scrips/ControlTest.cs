using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ControlTest : MonoBehaviour {

    public string bdName;
    private string textName = "Exeption";

    void Start () {

        var ds = new DataService(bdName + ".db");
        //ds.CreateDB();

        var people = ds.GetPersons();
        ToConsole(people);
    }

    private void ToConsole(IEnumerable<Test> people)
    {
        foreach (var person in people)
        {
            list.Add(person);
        }
    }

    private List<Test> list = new List<Test>();

    public string GetText(int nam)
    {
        return list[nam].Ask;
    }

    public int GetVidpovid(int nam)
    {
        return list[nam].Answer;
    }

    public int GetLenghList
    {
        get { return list.Count; }
    }

    public string GetExeption()
    {
        return textName;
    }
}
