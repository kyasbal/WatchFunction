using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Functions.PrefabController
{
    class CosFunctionController:FunctionControllerBase
    {
        public float A;

        public float B;

        public float C;

        public float D;
        protected override void OnUpdateFunction()
        {
            renderer.material.SetFloat("_A", this.A);
            renderer.material.SetFloat("_B", this.B);
            renderer.material.SetFloat("_C", this.C);
            renderer.material.SetFloat("_D", this.D);
        }
    }
}
