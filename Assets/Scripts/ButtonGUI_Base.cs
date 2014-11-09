using UnityEngine;
using System.Collections;

public abstract class ButtonGUI_Base : MonoBehaviour {

	Rect[] buttonPosition = new Rect[3];
	Rect[] shareButtonPosition = new Rect[3];

	public Texture2D[] texture = new Texture2D[3];

	protected bool actShareButton = false;
	protected bool[] actButton = new bool[3];

	/// <summary>ボタンが押された時の処理</summary>
	protected abstract void DoMove(int i);

	/// <summary>ボタンの有無の設定(0～3,シェアボタン)</summary>
	protected abstract void SetButtonActive();

	void Awake() { SetButtonActive(); }

	//GUI本体
	void OnGUI() {
		for (int i = 0; i < 3; i++) {
			if (actButton[i]) {
				buttonPosition[i] = guiScaler.GetRect(new Rect(80, 80 + 200 * i, 480, 160));
				if (GUI.Button(buttonPosition[i], texture[i],GUIStyle.none)) {
					DoMove(i);
				}
			}
		}

		if (actShareButton) {
			for (int i = 0; i < 3; i++) {
				shareButtonPosition[i] = guiScaler.GetRect(new Rect(80 + 180 * i, 680, 120, 120));
				if (GUI.Button(shareButtonPosition[i], texture[i+3])) {
					switch (i) {
						case 0://twitter
							break;

						case 1://facebook
							break;

						case 2://google+
							break;
					}
				}
			}
		}
	}

	/// <summary>画面によるGUIの伸縮をする</summary>
	public class GuiScaler {

		float _scale;
		Vector2 _offset;

		/// <param name="fixWidth">画面の幅</param>
		/// <param name="fixHeight">画面の高さ</param>
		/// <param name="isPortrait">横画面かどうか</param>
		public GuiScaler(int fixWidth = 640, int fixHeight = 960, bool isPortrait = false) {
			Calc(fixWidth, fixHeight, isPortrait);
		}

		/// <summary>補正値の計算</summary>
		void Calc(int w, int h, bool portrait) {

			float width = portrait ? h : w;
			float height = portrait ? w : h;

			float target_aspect = width / height;
			float window_aspect = (float)Screen.width / (float)Screen.height;
			float scale = window_aspect / target_aspect;

			Rect _rect = new Rect(0.0f, 0.0f, 1.0f, 1.0f);
			if (1.0f > scale) {
				_rect.x = 0;
				_rect.width = 1.0f;
				_rect.y = (1.0f - scale) / 2.0f;
				_rect.height = scale;

				_scale = (float)Screen.width / width;
			}
			else {
				scale = 1.0f / scale;
				_rect.x = (1.0f - scale) / 2.0f;
				_rect.width = scale;
				_rect.y = 0.0f;
				_rect.height = 1.0f;

				_scale = (float)Screen.height / height;
			}

			_offset.x = _rect.x * Screen.width;
			_offset.y = _rect.y * Screen.height;

		}

		/// <summary>本来想定するピクセル位置</summary>
		/// <returns>補正されたRect</returns>
		public Rect GetRect(float x, float y, float width, float height) {
			Rect rect
				= new Rect
					(
						_offset.x + (x * _scale),
						_offset.y + (y * _scale),
						width * _scale,
						height * _scale
					);

			return rect;

		}

		/// <summary>本来想定するピクセル位置</summary>
		/// <returns>補正されたRect</returns>
		public Rect GetRect(Rect rect) {
			return GetRect(rect.x, rect.y, rect.width, rect.height);
		}


		/// <summary>本来想定するピクセル位置</summary>
		/// <returns>半分に補正されたRect</returns>
		public Rect GetRectHalf(float x, float y, float width, float height) {
			Rect rect
				= new Rect
					(
						(_offset.x + (x * _scale)) / 2,
						(_offset.y + (y * _scale)) / 2,
						(width * _scale) / 2,
						(height * _scale) / 2
					);

			return rect;

		}

		/// <summary>本来想定するピクセル位置</summary>
		/// <returns>半分に補正されたRect</returns>
		public Rect GetRectHalf(Rect rect) {
			return GetRectHalf(rect.x, rect.y, rect.width, rect.height);
		}
	}
	GuiScaler guiScaler = new GuiScaler();
}
