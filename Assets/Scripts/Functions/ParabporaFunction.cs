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
		public class ParaboraFunction:IFunction
		{

            

		private float A;

		private float B;

		private float C;

		    private bool IsNegative;

		public ParaboraFunction ()
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

		    public override void DrawGraph (float time)
		{

		}

		    public override void BeginDraw(GameManager gameManager)
		    {
		        var gameObject = FunctionPrefabContainer.instance.ParaboraGameObject;
                var controller = gameObject.GetComponent<ParaboraFunctionController>();
                controller.A = A;
                controller.C = C;
                controller.B = B;
		        controller.IsNegative = IsNegative;
		        gameManager.BasicGraphTarget.ChangeGameObject(gameObject);

		    }

		    private float calcFunc(float x)
		    {
		        return A*x*x + B*x + C;
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
				return "LinearFunction";
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
		        gameManager.BasicFormulaTarget.text =IsNegative? string.Format("y<{0}x^2+{1}x+{2}",A,B,C):string.Format("y>{0}x^2+{1}x+{2}",A,B,C);
		    }

		    #endregion


		}
}

