using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {
    public List<Variant> will = new List<Variant>();
    public List<DonePerfab> ins = new List<DonePerfab>();
    public float LastDistance, FirstDistance;
    public int start,gens;
    // Use this for initialization
    void Start () {
		for (int i=0; 1<start; i++)
        {
            int rand = Random.Range(0, will.Count);
            GameObject temp = (GameObject)Instantiate(will[rand].model, new Vector3(0, 0, gens * 8), will[rand].model.transform.rotation);
            DonePerfab dp = new DonePerfab();
            dp.instantnated = temp;
            ins.Add(dp);
            gens++;
        }
    }
    public bool died;
	// Update is called once per frame
	void Update () {
		if (died)
        {

        } else
        {
            FirstDistance = Vector3.Distance(transform.position,ins[ins.Count - 1].instantnated.transform.position);
            LastDistance = Vector3.Distance(transform.position,ins[0].instantnated.transform.position);
        }
	}
}
[System.Serializable]
public class Variant
{
    public GameObject model;
}

[System.Serializable]
public class DonePerfab
{
    public GameObject instantnated;
    public List<GameObject> Money = new List<GameObject>();
}