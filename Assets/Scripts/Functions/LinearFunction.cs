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
using UnityEngine;


namespace AssemblyCSharp
{
		public class LinearFunction:IFunction
		{
		int A {
			get;
			set;
		}

		int B {
			get;
			set;
		}

		public LinearFunction (int a,int b)
		{
			this.A = a;
			this.B = b;
		}
		#region IFunction implementation

		private float func(float x)
		{
			return A * x + B;
		}

		public void DrawGraph ()
		{

		}

		public bool IsHit (UnityEngine.Vector2 player)
		{
			return player.y == func (player.x);
		}

		public string functionName {
			get {
				throw new NotImplementedException ();
			}
		}

		#endregion

		}
}

