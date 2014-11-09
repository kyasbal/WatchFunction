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
			A = Random.Range(1, 5)*(Random.Range (0,1)*2-1);
            B = Random.Range(0, 9);
			C = Random.Range(0, 5)*(Random.Range (0,1)*2-1);

			IsNegative = Random.Range (0, (A > 0 ? 3 : 1)) != 0 ? true : false;
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
			if (x * A + B > 0)
            {
                return (float)(Math.Log(x * A + B) + C);
            }
            else
            {
                return IsNegative ? -0.0f : 0.0f;
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
			
			gameManager.BasicFormulaTarget.text = string.Format("y");
			gameManager.BasicFormulaTarget.text += IsNegative ? string.Format ("<") : string.Format (">");
			gameManager.BasicFormulaTarget.text += string.Format("log(");
			if (A != 1) 
			{
				if(A != -1)
				{
					gameManager.BasicFormulaTarget.text += string.Format ("{0}", A);
				}
				else
				{
					gameManager.BasicFormulaTarget.text += string.Format ("-");
				}
			}
			gameManager.BasicFormulaTarget.text += string.Format ("x");
			if (B > 0)
			{
				gameManager.BasicFormulaTarget.text += string.Format ("+{0})", B);
			}
			else if (B < 0) 
			{
				gameManager.BasicFormulaTarget.text += string.Format ("{0})", B);
			}
			else
			{
				gameManager.BasicFormulaTarget.text += string.Format (")");
			}
			
			if (C > 0) 
			{
				gameManager.BasicFormulaTarget.text += string.Format ("+{0}", C);
			} 
			else if (C < 0) 
			{
				gameManager.BasicFormulaTarget.text += string.Format ("{0}", C);
			} 

            //gameManager.BasicFormulaTarget.text = IsNegative ? string.Format("y<log({0}x+{1})+{2}", A, B, C) : string.Format("y>log({0}x+{1})+{2}", A, B, C);
        }

        #endregion


    }
}