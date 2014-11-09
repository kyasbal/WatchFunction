using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Functions.PrefabController
{
    class SinFunctionController:FunctionControllerBase
    {
        public float A;

        public float B;

        public float C;
        protected override void OnUpdateFunction()
        {
            renderer.material.SetFloat("_A", this.A);
            renderer.material.SetFloat("_B", this.B);
            renderer.material.SetFloat("_C", this.C);
        }
    }
}
