Shader "Custom/LinearFunction" {
	Properties {
		_A("_A",Float)=-1.0
		_B("_B",Float)=1.0
		_O("_O",Float)=1.0
		_MainTex("Dummy",2D)="white"{}
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf Lambert alpha

		float _A;
		float _B;
		
		struct Input {
			float2 uv_MainTex;
		};
		float2 adjustBasis(float2 before)
		{
			return float2(before.x-0.5,before.y-0.5);
		}
		float4 calcColor(float2 coordinate)
		{
			float dist=abs(coordinate.y-_A*coordinate.x-_B);
			float lamda=0.02;
			float4 result=float4(0.0,1.0,1.0,1.0);
			result.rgb*=max(0.0,-1.0/lamda*dist+1.0);
			return result;
		}

		void surf (Input IN, inout SurfaceOutput o) {
			o.Emission=calcColor(adjustBasis(IN.uv_MainTex));
			o.Alpha=1.0;
		}
	
		ENDCG
	} 
	FallBack "Diffuse"
}
