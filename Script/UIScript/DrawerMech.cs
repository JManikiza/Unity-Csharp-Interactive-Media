using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerMech : MonoBehaviour
{
    private bool open;
    private bool coroutineAllowed;
    private Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        open = false;
        coroutineAllowed = true;
        initialPosition = transform.position;
    }

    private void OnMouseDown()
    {
        Invoke("RunCoroutine", 0f);
    }

    private void RunCoroutine()
    {
        StartCoroutine("OpenDrawer");
    }

    private IEnumerator OpenDrawer()
    {
        coroutineAllowed = false;
        if (!open)
        {
            for (float i = 0f; i <= 1f; i += 0.1f)
            {
                transform.localPosition = new Vector3(transform.localPosition.x - 1f,
                    transform.localPosition.y,
                    transform.localPosition.z);
                yield return new WaitForSeconds(0f);
            }
            open = true;
        }
        else
        {
            for (float i = 1f; i >= 0f; i -= 0.1f)
            {
                transform.localPosition = new Vector3(transform.localPosition.x + 1f,
                    transform.localPosition.y,
                    transform.localPosition.z);
                yield return new WaitForSeconds(0f);
            }
            transform.position = initialPosition;
            open = false;
        }
        coroutineAllowed = true;
    }
}
