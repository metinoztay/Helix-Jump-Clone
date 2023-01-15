using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    public List<GameObject> pieces;
    public void PrepareSimple(int nonActivePiecesAmount)
    {
        int index = Random.Range(0,pieces.Count);

        for (int i = 0; i < nonActivePiecesAmount; i++)
        {
            var item = pieces[index];
            item.SetActive(false);
            index++;
            if (index >= pieces.Count)
            {
                index=0;
            }
        }

    }
}