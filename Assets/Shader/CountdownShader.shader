Shader "Custom/CountdownShader" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_IsVisible("_IsVisible",Float)=1.0
		_Index("_Index",Float)=0.0
		_BaseColor("_BaseColor",Color)=(1.0,1.0,1.0,1.0)
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		Blend One SrcAlpha
		ZWrite Off
		
		CGPROGRAM
		#pragma surface surf Lambert alpha

		sampler2D _MainTex;
		float _Index;
		float _IsVisible;
		float4 _BaseColor;
		struct Input {
			float2 uv_MainTex;
		};

		void surf (Input IN, inout SurfaceOutput o) {
		if(_IsVisible<0.5)
		{
			o.Alpha=0;
			return;
		}
		float2 trueUv=IN.uv_MainTex;
		trueUv.x/=9;
		trueUv.x+=_Index/9;
			half4 c = tex2D (_MainTex, trueUv);
			o.Emission=_BaseColor.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	} 
	FallBack "Diffuse"
}
