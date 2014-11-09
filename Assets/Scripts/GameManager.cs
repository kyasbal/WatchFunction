using UnityEngine;
using System.Collections;
using AssemblyCSharp;
using System;

public class GameManager : MonoBehaviour
{
    public GameStatus _CurrentStatus;
	public GUIText BasicFormulaTarget;
    public GraphAreaManager BasicGraphTarget;
    public IFunction CurrentFunction;
    public float nextInMillis;
    

		public GameStatus CurrentStatus {
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
		    BasicGraphTarget = GameObject.Find("GraphContent").GetComponent<GraphAreaManager>();
                StatusChanged += GameManager_StatusChanged;
		}

        void GameManager_StatusChanged(object sender, GameManager.GameStatusChangedEventArgs e)
        {
            if (e.AfterStatus == GameStatus.Waiting)
            {
                CurrentFunction=new LinearFunction(1,0.2f); //TODOランダム取得
                nextInMillis = Time.time + CurrentFunction.waitingTimeInSecound;
            }else if (e.AfterStatus == GameStatus.Showing)
            {
                CurrentFunction.BeginDraw(this);
                nextInMillis = 2+Time.time;
            }
        }

		void Update ()
		{
				switch (CurrentStatus) {
				case GameStatus.GameStarting:
                        //タップしたら次に移るようにする
				        CurrentStatus = GameStatus.Waiting;
				        return;
						break;
				case GameStatus.GameFinishing:
						break;
				case GameStatus.Waiting:
                        CurrentFunction.DrawFormula(this);
				        if (Time.time > this.nextInMillis) CurrentStatus = GameStatus.Showing;
						break;
				case GameStatus.Showing:
                        if (Time.time > this.nextInMillis) CurrentStatus = GameStatus.Dismissing;
                        CurrentFunction.DrawFormula(this);
                        CurrentFunction.DrawGraph(nextInMillis-Time.time);
						break;
				case GameStatus.Dismissing:
				        CurrentStatus = GameStatus.Waiting;
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
