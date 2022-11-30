using UnityEngine;
namespace FightingGame
{
    public static class Utilities
    {
        public static readonly int hashedSpeedIndex = Animator.StringToHash("Speed");
        public static readonly int hashedJumpIndex = Animator.StringToHash("Jump");
        public static readonly int hashedGroundedIndex = Animator.StringToHash("Grounded");
        public static readonly int hashedY_velocityIndex = Animator.StringToHash("Y_velocity");
        public static readonly int hashedNearGroundIndex = Animator.StringToHash("NearGround");
        public static readonly int hashedAttackIndex = Animator.StringToHash("Attack");
        public static readonly string enemyTag = "Enemy";
        public static readonly string playerTag = "Player";
        public static readonly float DistanceToMove = 20;
        public static readonly float DistanceToAttack = .7f;
    }
   public enum TargetToDamage
    {
        Player,
        Enemy
    }
}