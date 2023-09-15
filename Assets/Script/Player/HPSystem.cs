using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPSystem : MonoBehaviour
{
    public GameObject Thing;

    public GameObject[] damageThings;
    public int[] damageCounts;

    public Slider hpBar;
    public int maxHp;
    public int hp;
    private void Awake()
    {
        hp = maxHp;
        hpBar.value = hp / maxHp;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == null && collision.gameObject.tag == "Untagged") return;

        for (int i = 0; i < damageThings.Length; i++)
        {
            if (collision.gameObject.tag == damageThings[i].tag)
            {
                if (collision.gameObject.name == damageThings[i].name + "(Clone)")
                {
                    Destroy(collision.gameObject);
                }
                StartCoroutine(Damage(damageCounts[i]));
            }
        }
    }

    IEnumerator Damage(int d)
    {
        hp -= d;
        hp = Mathf.Clamp(hp, 0, maxHp);
        hpBar.value = hp / maxHp;

        Thing.GetComponent<SpriteRenderer>().color = new Color(1, 144 / 255f, 144 / 255f, 1);
        yield return new WaitForSeconds(0.15f);
        Thing.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);

        if (hp <= 0)
        {
            yield return new WaitForSeconds(0.05f);
            Destroy(Thing.gameObject);
        }
    }
}
