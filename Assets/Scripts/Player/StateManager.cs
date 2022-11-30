using UnityEngine;
namespace FightingGame.Player
{
    public class StateManager : MonoBehaviour
    {
        [HideInInspector] public Animator animator;
        [HideInInspector] public Rigidbody rb;
        [HideInInspector] public ExternalInfluences externalInfluences;
        public BaseState[] states;
        public int defaultStateIndex;

        public BaseState current;
        [SerializeField] private string currentstatename;
        [HideInInspector] public bool canDamage = false;

        private void Start()
        {
            states = GetComponents<BaseState>();
            animator = GetComponent<Animator>();
            rb = GetComponent<Rigidbody>();
            externalInfluences = GetComponent<ExternalInfluences>();
            GameManager.instance.player = this;

            ActivateDefaultState();
        }

        private void Update()
        {
            currentstatename = current.ToString();
            InputHandler.instance.ReadInput();
        }

        private void FixedUpdate()
        {
            current.UpdateState();
        }
        public void Test_Press()
        {

        }
        public void SwitchState(BaseState newstate)
        {

            if (newstate == null)
            {

                print("Fuck you " + newstate.ToString());
                return;
            }
            print("new state " + newstate.ToString() + " " + newstate.CanSwitch());
            if (!newstate.CanSwitch() && current != null)
                return;
            current = newstate;
            current.Enter();
        }

        public void ActivateDefaultState() => SwitchState(states[defaultStateIndex]);
    }
}