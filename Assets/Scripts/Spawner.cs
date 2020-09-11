using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enem;
    public GameObject enem2;
    public GameObject enem3;
    public GameObject Ammo;
    public GameObject upgrade;
    public GameObject upgrade2;
    public GameObject DamageUpgrade;
    public GameObject LifeUpgrade;
    public GameObject weapon1;
    public GameObject weapon2;
    public GameObject weapon3;
    public GameObject weapon4;
    public GameObject hpmore;
    public GameObject XPpoint;

    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;

    public int WallsAmount;
    public int bossRarity;
    public float range;
    public float amount;
    public int Ammoamount;
    public int upgradeamount;
    public int upgrade2amount;
    public int weapon1amount;
    public int weapon2amount;
    public int weapon3amount;
    public int weapon4amount;
    public int lifeUpgradeAmount;
    public int DamageUpgradeAmount;
    public int hpmorecount;

    public int[] thinkAmount;
    public GameObject[] think;

    public Transform player;
    Vector2 playerPos;


    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Kakat", 0, amount);
    }

    int random;
    void Kakat()
    {
        amount -= 0.001f;
        int random;
        i++;
        random = Random.Range(0, 230);
        if (random >= 0 && random <= 37)
        {
            Instantiate(enem, playerPos += Random.insideUnitCircle * range, Quaternion.identity);
        }
        else if (random >= 51 && random <= 65)
        {
            Instantiate(enem2, playerPos += Random.insideUnitCircle * range, Quaternion.identity);
        }
        else if (random >= 66 && random <= 75)
        {
            e++;
            Instantiate(Ammo, playerPos += Random.insideUnitCircle * range, Quaternion.identity);
        }
        else if (random >= 76 && random <= 80)
        {
            r++;
            Instantiate(upgrade, playerPos += Random.insideUnitCircle * range, Quaternion.identity);
        }
        else if (random >= 81 && random <= 85)
        {
            y++;
            Instantiate(upgrade2, playerPos += Random.insideUnitCircle * range, Quaternion.identity);
        }
        else if (random >= 86 && random <= 88)
        {
            s++;
            Instantiate(weapon1, playerPos += Random.insideUnitCircle * range, Quaternion.identity);
        }
        else if (random >= 89 && random <= 93)
        {
            t++;
            Instantiate(weapon2, playerPos += Random.insideUnitCircle * range, Quaternion.identity);
        }
        else if (random >= 94 && random <= 97)
        {
            f++;
            Instantiate(weapon3, playerPos += Random.insideUnitCircle * range, Quaternion.identity);
        }
        else if (random >= 98 && random <= 104)
        {
            z++;
            Instantiate(DamageUpgrade, playerPos += Random.insideUnitCircle * range, Quaternion.identity);
        }
        else if (random >= 105 && random <= 108)
        {
            j++;
            Instantiate(hpmore, playerPos += Random.insideUnitCircle * range, Quaternion.identity);
        }
        else if (random >= 109 && random <= 125)
        {
            a++;
            Instantiate(LifeUpgrade, playerPos += Random.insideUnitCircle * range, Quaternion.identity);
        }
        else if (random >= 126 && random <= 130)
        {
            ie++;
            Instantiate(think[0], playerPos += Random.insideUnitCircle * range, Quaternion.identity);
        }
        else if (random >= 131 && random <= 133)
        {
            ie++;
            Instantiate(wall1, playerPos += Random.insideUnitCircle * range, Quaternion.identity);
        }
        else if (random >= 134 && random <= 136)
        {
            ie++;
            Instantiate(wall2, playerPos += Random.insideUnitCircle * range, Quaternion.identity);
        }
        else if (random >= 137 && random <= 139)
        {
            ie++;
            Instantiate(wall3, playerPos += Random.insideUnitCircle * range, Quaternion.Euler(0,0, Random.Range(0, 359)));
        }
        else if (random >= 140 && random <= 230)
        {
            ie++;
            Instantiate(XPpoint, playerPos += Random.insideUnitCircle * range, Quaternion.Euler(0, 0, Random.Range(0, 359)));
        }

    }
    // Update is called once per frame
    void Update()
    {

        playerPos = new Vector2(player.position.x, player.position.y);
       









    }

    int ie;
    int i;
    int e;
    int r;
    int y;
    int m;
    int g;
    int s;
    int t;
    int z;
    int f;
    int j;
    int l;
    int a;

    int[] LA;

    bool dawuka1;
    bool dawuka2;
    bool dawuka3;







}
