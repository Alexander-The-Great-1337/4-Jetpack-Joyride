using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 30;
    // Update is called once per frame
    void Update() => transform.Translate(moveSpeed * Time.deltaTime * Vector3.left);
}
