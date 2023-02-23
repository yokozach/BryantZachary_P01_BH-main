using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
public class BulletSpawner : MonoBehaviour
{
    public bool _elapsed;
    public float _maxTimeBetweenShot = 3f;
   

    private void Start()
    {
        var boss = gameObject.GetComponent<Boss_Stats>();
       
    }
    private void Update()
    {
        if (_elapsed) FireRound();
    }

    private void FireRound()
    {
        _elapsed = false;
       // objectPool.SpawnBullet(boss.ShotProjection);
      // StartCoroutine(RoundTimer);
    }
   //public IEnumerator RoundTimer()
   // {
       // yield return new WaitForSeconds(RandomClampedNumber(0, 4));
        //_elapsed = true;
    //}
}

