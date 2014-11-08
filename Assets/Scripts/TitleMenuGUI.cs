using UnityEngine;
using System.Collections;

public class TitleMenuGUI : ButtonGUI_Base {

	protected override void DoMove(int i) {
		switch (i) {
			case 0:	//ゲームモード選択へ
				break;

			case 1:	//オプションへ
				break;

			case 2:	//
				break;

			default:
				throw new System.NotImplementedException();
		}
	}

	protected override void SetButtonActive() {
		actButton[0] = true;
		actButton[1] = true;
		actButton[2] = true;
		actShareButton = true;
	}
}