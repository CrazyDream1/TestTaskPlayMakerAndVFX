using HutongGames.PlayMaker;
using UnityEngine;

namespace Core
{
    [RequireComponent(typeof(PlayMakerFSM))]
    public class ButtonClickHandler : MonoBehaviour
    {
        private PlayMakerFSM _fsm;

        private void Awake()
        {
            _fsm = GetComponent<PlayMakerFSM>();
        }

        public void OnButtonClick()
        {
            _fsm.SendEvent("ButtonClickedEvent");
        }
    }
}