using UnityEngine;
using System.Collections;

public class TitleMenuGUI : ButtonGUI_Base {

	protected override void DoMove(int i) {
		switch (i) {
			case 0:	//
				break;

			case 1:	//Normalモードへ
                Application.LoadLevel("GamePlay");
				break;

			case 2:	//Impossibleモードへ
                Application.LoadLevel("GamePlay");
				break;

			default:
				throw new System.NotImplementedException();
		}
	}

	protected override void SetButtonActive() {
		actButton[0] = false;
		actButton[1] = true;
		actButton[2] = true;
		actShareButton = true;
	}
}