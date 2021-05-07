using UnityEngine;
public class ModelController : MonoBehaviour
{
    [SerializeField] private Animator infantryAnim;
    private static readonly int IsAttack = Animator.StringToHash("isAttack");
    private static readonly int IsIdle = Animator.StringToHash("isIdle");
    private static readonly int IsRun = Animator.StringToHash("isRun");

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)) infantryAnim.SetTrigger(IsAttack);//按A时放攻击动画
        else if(Input.GetKeyDown(KeyCode.I)) infantryAnim.SetTrigger(IsIdle);//按I时放站立动画
        else if(Input.GetKeyDown(KeyCode.R)) infantryAnim.SetTrigger(IsRun);//按R时放奔跑动画
        
    }
}