using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    public GameObject[] player;
    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(0, 0, -10);
        foreach (GameObject p in player)
        {
            newPos += p.transform.position;
        }
        newPos /= player.Length;
        transform.position = newPos;
    }
}
