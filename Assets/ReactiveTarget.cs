using System.Collections;
using System.Collections.Generic;
using TPS3D;
using UnityEngine;

public class ReactiveTarget : BaseObjectScene
{
    public void ReactToHit()
    {
        Ai behavior = GetComponent<Ai>();

        if (behavior != null)
            behavior.SetAlive(false);

        StartCoroutine(ChangeColor());
        StartCoroutine(Die());
    }
    private IEnumerator Die()
    {
        this.transform.Rotate(-75, 0, 0);

        yield return new WaitForSeconds(2f);
        Destroy(this.gameObject);
    }
    private IEnumerator ChangeColor()
    {
        Color = Color.red;
        yield return new WaitForSeconds(1.5f);
    }
}
