using UnityEngine;
using System.Collections;

public class ResultGUI : ButtonGUI_Base {

	protected override void SetButtonActive() {
		actButton[0] = false;
		actButton[1] = true;
		actButton[2] = true;
		actShareButton = true;
	}

	protected override void DoMove(int i) {
		switch (i) {
			case 1:	//タイトルへ
				break;

			case 2:	//もう一度
				break;

			default:
				throw new System.NotImplementedException();
		}
	}
}