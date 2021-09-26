using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Clone : MonoBehaviour
{
    public Transform pre;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1);

        
        Transform sec = Instantiate(pre, pre.position, pre.rotation);
        sec.localEulerAngles = Vector3.up * 180;
        sec.GetComponentInChildren<Tilemap>().RefreshAllTiles();

        Transform third = Instantiate(pre, pre.position, pre.rotation);

        sec.localEulerAngles = Vector3.right * 180;

        Transform four = Instantiate(pre, pre.position, pre.rotation);

        sec.localEulerAngles = new Vector3(180, 180, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
