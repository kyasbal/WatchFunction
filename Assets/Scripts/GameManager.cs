using UnityEngine;
using System.Collections;
using AssemblyCSharp;
using System;

public class GameManager : MonoBehaviour
{
		public GameStatus _CurrentStatus;

		GameStatus CurrentStatus {
				get {
						return this._CurrentStatus;
				}
				set {
					var lastStatus=this._CurrentStatus;
					this._CurrentStatus = value;
			StatusChanged(this,new GameStatusChangedEventArgs(lastStatus,value));
				}
		}

	public event EventHandler<GameStatusChangedEventArgs> StatusChanged=delegate{};

		// Use this for initialization
		void Start ()
		{
				CurrentStatus = GameStatus.GameStarting;
		}

		void Update ()
		{
				switch (CurrentStatus) {
				case GameStatus.GameStarting:
						break;
				case GameStatus.GameFinishing:
						break;
				case GameStatus.Waiting:
						break;
				case GameStatus.Showing:
						break;
				case GameStatus.Dismissing:
						break;
				default:
						throw new System.ArgumentOutOfRangeException ();
				}
		}

		public class GameStatusChangedEventArgs:EventArgs
		{
				public GameStatus BeforeStatus;
				public GameStatus AfterStatus;

				public GameStatusChangedEventArgs (GameStatus before, GameStatus after)
				{
						this.AfterStatus = after;
						this.BeforeStatus = before;
				}

		}
}
