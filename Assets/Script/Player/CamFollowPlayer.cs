using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
        public GameObject[] player;

    public Transform leftBound;
    public Transform rightBound;
    public Transform bottomBound;
    public Transform topBound;

    void Update()
    {
        // Average position of the players
        Vector3 newPos = new Vector3(0, 0, -10);
        foreach (GameObject p in player)
        {
            newPos += p.transform.position;
        }
        newPos /= player.Length;

        // Use GameObject positions as limits
        newPos.x = Mathf.Clamp(newPos.x, leftBound.position.x, rightBound.position.x);
        newPos.y = Mathf.Clamp(newPos.y, bottomBound.position.y, topBound.position.y);

        transform.position = newPos;
    }
}