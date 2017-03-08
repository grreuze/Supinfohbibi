// Shader created with Shader Forge v1.32 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.32;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:True,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:34349,y:32227,varname:node_3138,prsc:2|emission-19-OUT,custl-2995-OUT,olwid-8514-OUT,olcol-3590-RGB;n:type:ShaderForge.SFN_FragmentPosition,id:9088,x:31604,y:31953,varname:node_9088,prsc:2;n:type:ShaderForge.SFN_Distance,id:4342,x:31803,y:31998,varname:node_4342,prsc:2|A-9088-XYZ,B-1715-XYZ;n:type:ShaderForge.SFN_Divide,id:850,x:31965,y:31998,varname:node_850,prsc:2|A-4342-OUT,B-1787-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1787,x:31803,y:32140,ptovrint:False,ptlb:Dist,ptin:_Dist,varname:node_7184,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_Lerp,id:2348,x:32556,y:31823,varname:node_2348,prsc:2|A-4824-OUT,B-2153-RGB,T-8399-OUT;n:type:ShaderForge.SFN_Posterize,id:8399,x:32151,y:31998,varname:node_8399,prsc:2|IN-850-OUT,STPS-332-OUT;n:type:ShaderForge.SFN_ValueProperty,id:332,x:31965,y:32129,ptovrint:False,ptlb:Posterize,ptin:_Posterize,varname:node_9161,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:3;n:type:ShaderForge.SFN_ViewPosition,id:1715,x:31604,y:32082,varname:node_1715,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:4676,x:31950,y:31735,ptovrint:False,ptlb:Text,ptin:_Text,varname:node_4676,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_SwitchProperty,id:4824,x:32200,y:31700,ptovrint:False,ptlb:Texture_On,ptin:_Texture_On,varname:node_4824,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-3351-RGB,B-4676-RGB;n:type:ShaderForge.SFN_Color,id:3351,x:31950,y:31554,ptovrint:False,ptlb:Color_Obj,ptin:_Color_Obj,varname:node_3351,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_NormalVector,id:2560,x:31926,y:32647,prsc:2,pt:False;n:type:ShaderForge.SFN_LightVector,id:6076,x:31814,y:32825,varname:node_6076,prsc:2;n:type:ShaderForge.SFN_ViewReflectionVector,id:4846,x:31926,y:32991,varname:node_4846,prsc:2;n:type:ShaderForge.SFN_Dot,id:2738,x:32144,y:32719,varname:node_2738,prsc:2,dt:1|A-2560-OUT,B-6076-OUT;n:type:ShaderForge.SFN_Dot,id:4394,x:32144,y:32889,varname:node_4394,prsc:2,dt:1|A-6076-OUT,B-4846-OUT;n:type:ShaderForge.SFN_Slider,id:6268,x:32066,y:33058,ptovrint:False,ptlb:Glossiness,ptin:_Glossiness,varname:node_6268,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:11.4656,max:12;n:type:ShaderForge.SFN_Power,id:9934,x:32423,y:32891,varname:node_9934,prsc:2|VAL-4394-OUT,EXP-6268-OUT;n:type:ShaderForge.SFN_Lerp,id:8664,x:32423,y:32715,varname:node_8664,prsc:2|A-6617-RGB,B-1162-RGB,T-2738-OUT;n:type:ShaderForge.SFN_Color,id:1162,x:32151,y:32551,ptovrint:False,ptlb:Lioght_Color,ptin:_Lioght_Color,varname:node_1162,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Color,id:6617,x:32151,y:32386,ptovrint:False,ptlb:Shadow_Color,ptin:_Shadow_Color,varname:node_6617,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Color,id:2153,x:32151,y:32207,ptovrint:False,ptlb:Fade,ptin:_Fade,varname:node_2153,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Fresnel,id:2898,x:33179,y:32659,varname:node_2898,prsc:2|NRM-2560-OUT,EXP-9036-OUT;n:type:ShaderForge.SFN_Add,id:411,x:33582,y:32541,varname:node_411,prsc:2|A-7716-OUT,B-5560-OUT;n:type:ShaderForge.SFN_Slider,id:9036,x:32731,y:32717,ptovrint:False,ptlb:Fresnel,ptin:_Fresnel,varname:node_9036,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:3.104911,max:10;n:type:ShaderForge.SFN_Vector1,id:3748,x:33160,y:32578,varname:node_3748,prsc:2,v1:0;n:type:ShaderForge.SFN_Multiply,id:19,x:33004,y:31913,varname:node_19,prsc:2|A-2348-OUT,B-8664-OUT;n:type:ShaderForge.SFN_Multiply,id:7716,x:32888,y:32820,varname:node_7716,prsc:2|A-8664-OUT,B-9934-OUT;n:type:ShaderForge.SFN_AmbientLight,id:6557,x:33561,y:32717,varname:node_6557,prsc:2;n:type:ShaderForge.SFN_SwitchProperty,id:5560,x:33356,y:32637,ptovrint:False,ptlb:FresnelOn,ptin:_FresnelOn,varname:node_5560,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-3748-OUT,B-2898-OUT;n:type:ShaderForge.SFN_Multiply,id:2995,x:33794,y:32568,varname:node_2995,prsc:2|A-411-OUT,B-6557-RGB;n:type:ShaderForge.SFN_ValueProperty,id:8514,x:33817,y:32773,ptovrint:False,ptlb:OutlineWidth,ptin:_OutlineWidth,varname:node_8514,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Color,id:3590,x:33817,y:32871,ptovrint:False,ptlb:OutlineColor,ptin:_OutlineColor,varname:node_3590,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;proporder:4824-4676-3351-1162-6617-2153-1787-332-6268-5560-9036-8514-3590;pass:END;sub:END;*/

Shader "FishnTricks/fogFish" {
    Properties {
        [MaterialToggle] _Texture_On ("Texture_On", Float ) = 0.5
        _Text ("Text", 2D) = "white" {}
        _Color_Obj ("Color_Obj", Color) = (0.5,0.5,0.5,1)
        _Lioght_Color ("Lioght_Color", Color) = (1,1,1,1)
        _Shadow_Color ("Shadow_Color", Color) = (0,0,0,1)
        _Fade ("Fade", Color) = (0.5,0.5,0.5,1)
        _Dist ("Dist", Float ) = 10
        _Posterize ("Posterize", Float ) = 3
        _Glossiness ("Glossiness", Range(1, 12)) = 11.4656
        [MaterialToggle] _FresnelOn ("FresnelOn", Float ) = 0
        _Fresnel ("Fresnel", Range(0, 10)) = 3.104911
        _OutlineWidth ("OutlineWidth", Float ) = 0.1
        _OutlineColor ("OutlineColor", Color) = (1,1,1,1)
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "Outline"
            Tags {
            }
            Cull Front
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 
            #pragma target 2.0
            uniform float _OutlineWidth;
            uniform float4 _OutlineColor;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = mul(UNITY_MATRIX_MVP, float4(v.vertex.xyz + v.normal*_OutlineWidth,1) );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                return fixed4(_OutlineColor.rgb,0);
            }
            ENDCG
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 
            #pragma target 2.0
            uniform float _Dist;
            uniform float _Posterize;
            uniform sampler2D _Text; uniform float4 _Text_ST;
            uniform fixed _Texture_On;
            uniform float4 _Color_Obj;
            uniform float _Glossiness;
            uniform float4 _Lioght_Color;
            uniform float4 _Shadow_Color;
            uniform float4 _Fade;
            uniform float _Fresnel;
            uniform fixed _FresnelOn;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
////// Lighting:
////// Emissive:
                float4 _Text_var = tex2D(_Text,TRANSFORM_TEX(i.uv0, _Text));
                float3 node_8664 = lerp(_Shadow_Color.rgb,_Lioght_Color.rgb,max(0,dot(i.normalDir,lightDirection)));
                float3 emissive = (lerp(lerp( _Color_Obj.rgb, _Text_var.rgb, _Texture_On ),_Fade.rgb,floor((distance(i.posWorld.rgb,_WorldSpaceCameraPos)/_Dist) * _Posterize) / (_Posterize - 1))*node_8664);
                float3 finalColor = emissive + (((node_8664*pow(max(0,dot(lightDirection,viewReflectDirection)),_Glossiness))+lerp( 0.0, pow(1.0-max(0,dot(i.normalDir, viewDirection)),_Fresnel), _FresnelOn ))*UNITY_LIGHTMODEL_AMBIENT.rgb);
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 
            #pragma target 2.0
            uniform float _Dist;
            uniform float _Posterize;
            uniform sampler2D _Text; uniform float4 _Text_ST;
            uniform fixed _Texture_On;
            uniform float4 _Color_Obj;
            uniform float _Glossiness;
            uniform float4 _Lioght_Color;
            uniform float4 _Shadow_Color;
            uniform float4 _Fade;
            uniform float _Fresnel;
            uniform fixed _FresnelOn;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
////// Lighting:
                float3 node_8664 = lerp(_Shadow_Color.rgb,_Lioght_Color.rgb,max(0,dot(i.normalDir,lightDirection)));
                float3 finalColor = (((node_8664*pow(max(0,dot(lightDirection,viewReflectDirection)),_Glossiness))+lerp( 0.0, pow(1.0-max(0,dot(i.normalDir, viewDirection)),_Fresnel), _FresnelOn ))*UNITY_LIGHTMODEL_AMBIENT.rgb);
                return fixed4(finalColor * 1,0);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
