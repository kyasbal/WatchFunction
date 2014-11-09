//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34014
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using Functions.PrefabController;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;


namespace AssemblyCSharp
{
		public class TanFunction:IFunction
		{

            

		private float A;

		private float B;

		private float C;

		    private bool IsNegative;

		public TanFunction ()
				{
				}
		#region implemented abstract members of IFunction

		    public override void Refresh()
		    {
                A = Random.Range(-9, 9);
				A = A != 0 ? A : 1;
                B = Random.Range(0, 9)*(A > 0 ? -1 : 1);
				C = Random.Range(0, 5)*(A > 0 ? -1 : 1);
				IsNegative = Random.Range (0, (A > 0 ? 3 : 1)) != 0 ? true : false;
		    }

		    public override void DrawGraph (float time)
		{

		}

		    public override void BeginDraw(GameManager gameManager)
		    {
		        var gameObject = FunctionPrefabContainer.instance.TanGameObject;
                var controller = gameObject.GetComponent<TanFunctionController>();
                controller.A = A;
                controller.C = C;
                controller.B = B;
		        controller.IsNegative = IsNegative;
		        gameManager.BasicGraphTarget.ChangeGameObject(gameObject);

		    }

		    private float calcFunc(float x)
		    {
                if (Double.IsNaN(Math.Tan(A * x + B)))
                {
                    return 10.0f;
                }
                else
                {
    		        return (float)(Math.Tan(A*x + B) + C);
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

		public override string functionName {
			get {
				return "TanFunction";
			}
		}

		public override int functionLevel {
			get {
				return 1;
			}
		}

		    public override float waitingTimeInSecound
		    {
		        get { return 3; }
		    }

		    public override void DrawFormula(GameManager gameManager)
		    {
		        gameManager.BasicFormulaTarget.text =IsNegative? string.Format("y<tan({0}x+{1})+{2}",A,B,C):string.Format("y>tan({0}x+{1})+{2}",A,B,C);
		    }

		    #endregion


		}
}

