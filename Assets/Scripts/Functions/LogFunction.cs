using System;
using Functions.PrefabController;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

namespace AssemblyCSharp
{
    public class LogFunction : IFunction
    {

        private float A;

        private float B;

        private float C;

        private bool IsNegative;

        public LogFunction()
        {
        }
        #region implemented abstract members of IFunction

        public override void Refresh()
        {
            A = Random.Range(0.5f, 5.0f);
            B = Random.Range(0.5f, 5.0f);
            C = Random.Range(0f, 0.5f);

            IsNegative = false;
        }

        public override void DrawGraph(float time)
        {

        }

        public override void BeginDraw(GameManager gameManager)
        {
            var gameObject = FunctionPrefabContainer.instance.LogGameObject;
            var controller = gameObject.GetComponent<LogFunctionController>();
            controller.A = A;
			controller.B = B;
			controller.C = C;
            controller.IsNegative = IsNegative;
            gameManager.BasicGraphTarget.ChangeGameObject(gameObject);

        }

        private float calcFunc(float x)
        {
            if (x > 0)
            {
                return (float)(Math.Log(x * A + B) + C);
            }
            else
            {
                return (float)-100;
            }
        }

        public override bool IsHit(Vector2 player)
        {
            if (IsNegative)
            {
                return calcFunc(player.x) > player.y;
}	
            else
            {
                return calcFunc(player.x) < player.y;
            }
        }

        public override string functionName
        {
            get
            {
                return "LogFunction";
            }
        }

        public override int functionLevel
        {
            get
            {
                return 1;
            }
        }

        public override float waitingTimeInSecound
        {
            get { return 3; }
        }

        public override void DrawFormula(GameManager gameManager)
        {
            gameManager.BasicFormulaTarget.text = IsNegative ? string.Format("y<log({0}x+{1})+{2}", A, B, C) : string.Format("y>log({0}x+{1})+{2}", A, B, C);
        }

        #endregion


    }
}