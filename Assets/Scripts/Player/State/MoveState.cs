using UnityEngine;
namespace FightingGame.Player
{
    public class MoveState : BaseState
    {
        [SerializeField] private IdleState idleState;
        private float rs;

        public override bool CanSwitch()
        {
            return Manager.externalInfluences.IsGrounded;
        }

        public override void Enter() { }

        public override void UpdateState()
        {
            //if (stateManager.animator.GetFloat(Utilities.hashedSpeedIndex) <= 1.2f)
            Manager.animator.SetFloat(Utilities.hashedSpeedIndex, InputHandler.instance.dir.magnitude);//,.1f,Time.deltaTime);
            if (InputHandler.instance.dir.magnitude < .1f)
            {
                Manager.rb.velocity = Vector3.zero;
                Manager.ActivateDefaultState();
            }
            Vector3 normalizedDir = InputHandler.instance.dir.normalized;
            float angle = (Mathf.Atan2(normalizedDir.x, normalizedDir.z)) * Mathf.Rad2Deg + Camera.main.transform.rotation.eulerAngles.y;
            angle = Mathf.SmoothDampAngle(transform.rotation.eulerAngles.y, angle, ref rs, .15f);
            transform.rotation = Quaternion.Euler(0, angle, 0);
            Manager.rb.velocity = (Mathf.Clamp01(InputHandler.instance.dir.sqrMagnitude)  * transform.forward) * 4;
        }
    }

}