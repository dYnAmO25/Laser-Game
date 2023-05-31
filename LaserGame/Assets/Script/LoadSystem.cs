using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class LoadSystem
{
    public static Level LoadLevel(string sPath)
    {
        if (File.Exists(sPath))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(sPath, FileMode.Open);

            Level data = formatter.Deserialize(stream) as Level;
            stream.Close();

            return data;
        }
        else
        {
            Debug.Log("Data not found in " + sPath);
            return null;
        }
    }
}
