using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip SimpleAttackSound, JumpAttackSound, DashClothHonrizontalSound, DashClothVerticalSound, DashMoveHonrizontalSound, DashMoveVerticalSound, JumpSound, EnemyDeathSound, AzaèsDeathSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        SimpleAttackSound = Resources.Load<AudioClip>("SimpleAttack");
        JumpAttackSound = Resources.Load<AudioClip>("JumpAttack");
        JumpSound = Resources.Load<AudioClip>("Jump");
        DashClothHonrizontalSound = Resources.Load<AudioClip>("DashClothHonrizontal");
        DashClothVerticalSound = Resources.Load<AudioClip>("DashClothVertical");
        DashMoveHonrizontalSound = Resources.Load<AudioClip>("DashMoveHonrizontal");
        DashMoveVerticalSound = Resources.Load<AudioClip>("DashMoveVertical");
        EnemyDeathSound = Resources.Load<AudioClip>("EnemyDeath");
        AzaèsDeathSound = Resources.Load<AudioClip>("AzaèsDeath");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "SimpleAttack":
                audioSrc.PlayOneShot(SimpleAttackSound);
                break;
            case "JumpAttack":
                audioSrc.PlayOneShot(JumpAttackSound);
                break;
            case "Jump":
                audioSrc.PlayOneShot(JumpSound);
                break;
            case "DashClothHonrizontal":
                audioSrc.PlayOneShot(DashClothHonrizontalSound);
                break;
            case "DashClothVertical":
                audioSrc.PlayOneShot(DashClothVerticalSound);
                break;
            case "DashMoveHonrizontal":
                audioSrc.PlayOneShot(DashMoveHonrizontalSound);
                break;
            case "DashMoveVertical":
                audioSrc.PlayOneShot(DashMoveVerticalSound);
                break;
            case "EnemyDeath":
                audioSrc.PlayOneShot(EnemyDeathSound);
                break;
            case "AzaèsDeath":
                audioSrc.PlayOneShot(AzaèsDeathSound);
                break;
        }
    }
}
