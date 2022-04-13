using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    public bool EnableSelectCharacter;
    public enum Player { Frog, MaskDude, PinkMan, VirtualGuy }
    public Player playerselected;

    public Animator animator;
    public SpriteRenderer spriterenderer;

    public RuntimeAnimatorController[] PlayersController;
    public Sprite[] PlayerRenderer;
    void Start()
    {
        if (EnableSelectCharacter)
        {
            ChangePlayerInMenu();
        }
        else
        {
            switch (playerselected)
            {
                case Player.Frog:
                    spriterenderer.sprite = PlayerRenderer[0];
                    animator.runtimeAnimatorController = PlayersController[0];
                    break;
                case Player.VirtualGuy:
                    spriterenderer.sprite = PlayerRenderer[3];
                    animator.runtimeAnimatorController = PlayersController[3];
                    break;
                case Player.PinkMan:
                    spriterenderer.sprite = PlayerRenderer[2];
                    animator.runtimeAnimatorController = PlayersController[2];
                    break;
                case Player.MaskDude:
                    spriterenderer.sprite = PlayerRenderer[1];
                    animator.runtimeAnimatorController = PlayersController[1];
                    break;
                default:
                    break;
            }
        }
    }

    public void ChangePlayerInMenu()
    {
        switch (PlayerPrefs.GetString("PlayerSelected"))
        {
            case "Frog":
                spriterenderer.sprite = PlayerRenderer[0];
                animator.runtimeAnimatorController = PlayersController[0];
                break;
            case "VirtualGuy":
                spriterenderer.sprite = PlayerRenderer[3];
                animator.runtimeAnimatorController = PlayersController[3];
                break;
            case "PinkMan":
                spriterenderer.sprite = PlayerRenderer[2];
                animator.runtimeAnimatorController = PlayersController[2];
                break;
            case "MaskDude":
                spriterenderer.sprite = PlayerRenderer[1];
                animator.runtimeAnimatorController = PlayersController[1];
                break;
            default:
                break;
        }
    }
}