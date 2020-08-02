using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class ListTobbacos : MonoBehaviour
    {
        public List<Tobbaco> Tobbaco;

        private void Start()
        {
            for (int i = 0; i < Tobbaco.Count; i++)
            {
                Tobbaco[i] = GetComponent<Tobbaco>();
            }

            RealizationTobbaco();
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void RealizationTobbaco()
        {
            Tobbaco[0].AddTobbaco("DS", "1", "2", "3");
            Tobbaco[0].Remove("3");
            Tobbaco[0].Show();

            Tobbaco[1].AddTobbaco("MT", "1", "2", "3");
            Tobbaco[1].Remove("2");
            Tobbaco[1].Show();

            
        }
    }
}
