using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class SaveHandler : MonoBehaviour
{
    public Animator transition;
    public float Ttime;






    public string filenum;
    public string plrlvl;
    public string world;
    public string level;
    public string CP;
    public string SceneIndex;

    public List<string> data;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            filenum = PlayerPrefs.GetString("file");
            data = new List<string> { filenum, plrlvl, world, level, CP, SceneIndex };
            string datastr = string.Join(" ", data.ToArray());
            Save(datastr);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadLevel();
        }
    }



    public void Save(string datastr)
    {
        if(datastr.Substring(0, 1) == "1")
        {
            File.WriteAllText(Application.dataPath + "/save1.txt", datastr);
        }
        else if (datastr.Substring(0, 1) == "2")
        {
            File.WriteAllText(Application.dataPath + "/save2.txt", datastr);
        }
        else if (datastr.Substring(0, 1) == "3")
        {
            File.WriteAllText(Application.dataPath + "/save3.txt", datastr);
        }
        else
        {
            File.WriteAllText(Application.dataPath + "/savefail.txt", "failed to save, heres the data: " + datastr);
        }
        
        
    }
    public void Load1()
    {
        string savedata = File.ReadAllText(Application.dataPath + "/save1.txt");
        filenum = "1";
        PlayerPrefs.SetString("file", filenum);
        plrlvl = savedata.Substring(2, 1);
        world = savedata.Substring(4, 2);
        level = savedata.Substring(7, 1);
        CP = savedata.Substring(9, 1);
        SceneIndex = savedata.Substring(11, 3);

    }
    public void Load2()
    {
        string savedata = File.ReadAllText(Application.dataPath + "/save2.txt");
        filenum = "2";
        PlayerPrefs.SetString("file", filenum);
        plrlvl = savedata.Substring(2, 1);
        world = savedata.Substring(4, 2);
        level = savedata.Substring(7, 1);
        CP = savedata.Substring(9, 1);
        SceneIndex = savedata.Substring(11, 3);

    }
    public void Load3()
    {
        string savedata = File.ReadAllText(Application.dataPath + "/save3.txt");
        filenum = "3";
        PlayerPrefs.SetString("file", filenum);
        plrlvl = savedata.Substring(2, 1);
        world = savedata.Substring(4, 2);
        level = savedata.Substring(7, 1);
        CP = savedata.Substring(9, 1);
        SceneIndex = savedata.Substring(11, 3);

    }


    public void LoadLevel()
    {
        
        int SceneNum = int.Parse(SceneIndex);
        StartCoroutine(LoadLevel(SceneNum));

    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(Ttime);

        SceneManager.LoadScene(levelIndex);

    }







    public void New1()
    {
        //setvalues
        filenum = "1";
        PlayerPrefs.SetString("file", filenum);
        plrlvl = "0";
        world = "01";
        level = "1";
        CP = "0";
        SceneIndex = "001";

        //convert+save
        data = new List<string> { filenum, plrlvl, world, level, CP, SceneIndex };
        string datastr = string.Join(" ", data.ToArray());
        Save(datastr);
    }

    public void New2()
    {
        //setvalues
        filenum = "2";
        PlayerPrefs.SetString("file", filenum);
        plrlvl = "0";
        world = "01";
        level = "1";
        CP = "0";
        SceneIndex = "001";

        //convert+save
        data = new List<string> { filenum, plrlvl, world, level, CP, SceneIndex };
        string datastr = string.Join(" ", data.ToArray());
        Save(datastr);
    }
    public void New3()
    {
        //setvalues
        filenum = "3";
        PlayerPrefs.SetString("file", filenum);
        plrlvl = "0";
        world = "01";
        level = "1";
        CP = "0";
        SceneIndex = "001";

        //convert+save
        data = new List<string> { filenum, plrlvl, world, level, CP, SceneIndex };
        string datastr = string.Join(" ", data.ToArray());
        Save(datastr);
    }
}
