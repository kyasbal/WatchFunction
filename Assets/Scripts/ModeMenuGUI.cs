using UnityEngine;
using System.Collections;

public class ModeMenuGUI : ButtonGUI_Base {

	protected override void SetButtonActive() {
		actButton[0] = true;
		actButton[1] = true;
		actButton[2] = true;
		actShareButton = false;
	}

	protected override void DoMove(int i) {
		switch (i) {
			case 0://エンドレスへ
				break;

			case 1:	//PvPへ
				break;

			case 2:	//タイトルへ
				break;

			default:
				throw new System.NotImplementedException();
		}
	}
}