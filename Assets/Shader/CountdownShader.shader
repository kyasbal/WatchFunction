Shader "Custom/CountdownShader" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_Index("_Index",Float)=0.0
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

		struct Input {
			float2 uv_MainTex;
		};

		void surf (Input IN, inout SurfaceOutput o) {
		float2 trueUv=IN.uv_MainTex;
		trueUv.x/=9;
		trueUv.x+=_Index/9;
			half4 c = tex2D (_MainTex, trueUv);
			o.Albedo = c.rgb*float3(1.0,0,0);
			o.Alpha = c.a;
		}
		ENDCG
	} 
	FallBack "Diffuse"
}
