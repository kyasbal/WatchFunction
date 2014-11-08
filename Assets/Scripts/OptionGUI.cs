using UnityEngine;
using System.Collections;

public class OptionGUI : ButtonGUI_Base {

	protected override void SetButtonActive() {
		actButton[0] = true;
		actButton[1] = true;
		actButton[2] = true;
		actShareButton = false;
	}

	protected override void DoMove(int i) {
		switch (i) {
			case 0:	//へ
				break;

			case 1:	//へ
				break;

			case 2:	//へ
				break;

			default:
				throw new System.NotImplementedException();
		}
	}
}
