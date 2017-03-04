// Shader created with Shader Forge v1.32 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.32;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:2,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:True,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:34462,y:32192,varname:node_3138,prsc:2|emission-9908-OUT,custl-8214-OUT,olwid-2076-OUT,olcol-7080-RGB;n:type:ShaderForge.SFN_FragmentPosition,id:9088,x:30512,y:32046,varname:node_9088,prsc:2;n:type:ShaderForge.SFN_Distance,id:4342,x:30801,y:31973,varname:node_4342,prsc:2|A-9088-XYZ,B-1715-XYZ;n:type:ShaderForge.SFN_Divide,id:850,x:31162,y:31968,varname:node_850,prsc:2|A-4342-OUT,B-1787-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1787,x:30801,y:32129,ptovrint:False,ptlb:Dist,ptin:_Dist,varname:node_7184,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_Lerp,id:2348,x:32375,y:31805,varname:node_2348,prsc:2|A-4824-OUT,B-2153-RGB,T-8399-OUT;n:type:ShaderForge.SFN_Posterize,id:8399,x:31416,y:31968,varname:node_8399,prsc:2|IN-850-OUT,STPS-332-OUT;n:type:ShaderForge.SFN_ValueProperty,id:332,x:31162,y:32118,ptovrint:False,ptlb:Posterize,ptin:_Posterize,varname:node_9161,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:3;n:type:ShaderForge.SFN_ViewPosition,id:1715,x:30512,y:31909,varname:node_1715,prsc:2;n:type:ShaderForge.SFN_Color,id:1614,x:31416,y:32170,ptovrint:False,ptlb:ColorFade_Top,ptin:_ColorFade_Top,varname:_Color_Near_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:1,c3:0.1724138,c4:1;n:type:ShaderForge.SFN_Normalize,id:1831,x:30735,y:32327,varname:node_1831,prsc:2|IN-9088-XYZ;n:type:ShaderForge.SFN_ComponentMask,id:9507,x:30995,y:32333,varname:node_9507,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-1831-OUT;n:type:ShaderForge.SFN_Color,id:7278,x:31416,y:32380,ptovrint:False,ptlb:ColorFade_Bot,ptin:_ColorFade_Bot,varname:node_7278,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.8344827,c3:1,c4:1;n:type:ShaderForge.SFN_Lerp,id:3325,x:31712,y:32259,varname:node_3325,prsc:2|A-7278-RGB,B-1614-RGB,T-9507-OUT;n:type:ShaderForge.SFN_Tex2d,id:4676,x:31377,y:31754,ptovrint:False,ptlb:Text,ptin:_Text,varname:node_4676,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_SwitchProperty,id:4824,x:31972,y:31457,ptovrint:False,ptlb:Texture_On,ptin:_Texture_On,varname:node_4824,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-3351-RGB,B-386-OUT;n:type:ShaderForge.SFN_Color,id:3351,x:31693,y:31300,ptovrint:False,ptlb:Color_Obj,ptin:_Color_Obj,varname:node_3351,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Color,id:7080,x:33487,y:33388,ptovrint:False,ptlb:Outline_Color,ptin:_Outline_Color,varname:node_7080,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Slider,id:2076,x:33330,y:33296,ptovrint:False,ptlb:Outline,ptin:_Outline,varname:node_2076,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.01402139,max:1;n:type:ShaderForge.SFN_NormalVector,id:2560,x:31777,y:32755,prsc:2,pt:True;n:type:ShaderForge.SFN_LightVector,id:6076,x:31777,y:32930,varname:node_6076,prsc:2;n:type:ShaderForge.SFN_ViewReflectionVector,id:4846,x:31777,y:33099,varname:node_4846,prsc:2;n:type:ShaderForge.SFN_Dot,id:2738,x:32114,y:32838,varname:node_2738,prsc:2,dt:0|A-2560-OUT,B-6076-OUT;n:type:ShaderForge.SFN_Dot,id:4394,x:32122,y:33013,varname:node_4394,prsc:2,dt:1|A-6076-OUT,B-4846-OUT;n:type:ShaderForge.SFN_Slider,id:6268,x:31829,y:33312,ptovrint:False,ptlb:Glossiness,ptin:_Glossiness,varname:node_6268,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:2.743527,max:12;n:type:ShaderForge.SFN_Power,id:9934,x:32378,y:33049,varname:node_9934,prsc:2|VAL-4394-OUT,EXP-6268-OUT;n:type:ShaderForge.SFN_Multiply,id:2811,x:33288,y:32335,varname:node_2811,prsc:2|A-5811-OUT,B-9934-OUT;n:type:ShaderForge.SFN_Clamp01,id:9908,x:32602,y:31805,varname:node_9908,prsc:2|IN-2348-OUT;n:type:ShaderForge.SFN_Multiply,id:5811,x:33104,y:32106,varname:node_5811,prsc:2|A-9908-OUT,B-8664-OUT;n:type:ShaderForge.SFN_Add,id:3646,x:33488,y:32197,varname:node_3646,prsc:2|A-5811-OUT,B-2811-OUT;n:type:ShaderForge.SFN_LightColor,id:1776,x:33460,y:32362,varname:node_1776,prsc:2;n:type:ShaderForge.SFN_LightAttenuation,id:7510,x:33473,y:32540,varname:node_7510,prsc:2;n:type:ShaderForge.SFN_Multiply,id:5758,x:33740,y:32302,varname:node_5758,prsc:2|A-3646-OUT,B-1776-RGB,C-7510-OUT;n:type:ShaderForge.SFN_Multiply,id:386,x:31662,y:31516,varname:node_386,prsc:2|A-8532-RGB,B-4676-RGB;n:type:ShaderForge.SFN_LightColor,id:8532,x:31377,y:31577,varname:node_8532,prsc:2;n:type:ShaderForge.SFN_LightAttenuation,id:2386,x:30960,y:31362,varname:node_2386,prsc:2;n:type:ShaderForge.SFN_Lerp,id:8664,x:32500,y:32791,varname:node_8664,prsc:2|A-6617-RGB,B-1162-RGB,T-2738-OUT;n:type:ShaderForge.SFN_Color,id:1162,x:32235,y:32629,ptovrint:False,ptlb:Lioght_Color,ptin:_Lioght_Color,varname:node_1162,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Color,id:6617,x:32245,y:32395,ptovrint:False,ptlb:Shadow_Color,ptin:_Shadow_Color,varname:node_6617,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Color,id:2153,x:31978,y:32086,ptovrint:False,ptlb:Fade,ptin:_Fade,varname:node_2153,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Lerp,id:8214,x:34072,y:32467,varname:node_8214,prsc:2|A-5758-OUT,B-2153-RGB,T-8399-OUT;proporder:1614-7278-1787-332-4676-4824-3351-2076-7080-6268-1162-6617-2153;pass:END;sub:END;*/

Shader "Shader Forge/fogobj" {
    Properties {
        _ColorFade_Top ("ColorFade_Top", Color) = (0,1,0.1724138,1)
        _ColorFade_Bot ("ColorFade_Bot", Color) = (0,0.8344827,1,1)
        _Dist ("Dist", Float ) = 10
        _Posterize ("Posterize", Float ) = 3
        _Text ("Text", 2D) = "white" {}
        [MaterialToggle] _Texture_On ("Texture_On", Float ) = 0.5
        _Color_Obj ("Color_Obj", Color) = (0.5,0.5,0.5,1)
        _Outline ("Outline", Range(0, 1)) = 0.01402139
        _Outline_Color ("Outline_Color", Color) = (0.5,0.5,0.5,1)
        _Glossiness ("Glossiness", Range(1, 12)) = 2.743527
        _Lioght_Color ("Lioght_Color", Color) = (1,1,1,1)
        _Shadow_Color ("Shadow_Color", Color) = (0,0,0,1)
        _Fade ("Fade", Color) = (0.5,0.5,0.5,1)
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
            uniform float4 _Outline_Color;
            uniform float _Outline;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = mul(UNITY_MATRIX_MVP, float4(v.vertex.xyz + v.vertexColor*_Outline,1) );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                return fixed4(_Outline_Color.rgb,0);
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
            #include "Lighting.cginc"
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
                float3 lightColor = _LightColor0.rgb;
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
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
////// Emissive:
                float4 _Text_var = tex2D(_Text,TRANSFORM_TEX(i.uv0, _Text));
                float node_8399 = floor((distance(i.posWorld.rgb,_WorldSpaceCameraPos)/_Dist) * _Posterize) / (_Posterize - 1);
                float3 node_9908 = saturate(lerp(lerp( _Color_Obj.rgb, (_LightColor0.rgb*_Text_var.rgb), _Texture_On ),_Fade.rgb,node_8399));
                float3 emissive = node_9908;
                float3 node_5811 = (node_9908*lerp(_Shadow_Color.rgb,_Lioght_Color.rgb,dot(normalDirection,lightDirection)));
                float3 finalColor = emissive + lerp(((node_5811+(node_5811*pow(max(0,dot(lightDirection,viewReflectDirection)),_Glossiness)))*_LightColor0.rgb*attenuation),_Fade.rgb,node_8399);
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
            #include "Lighting.cginc"
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
                float3 lightColor = _LightColor0.rgb;
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
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float4 _Text_var = tex2D(_Text,TRANSFORM_TEX(i.uv0, _Text));
                float node_8399 = floor((distance(i.posWorld.rgb,_WorldSpaceCameraPos)/_Dist) * _Posterize) / (_Posterize - 1);
                float3 node_9908 = saturate(lerp(lerp( _Color_Obj.rgb, (_LightColor0.rgb*_Text_var.rgb), _Texture_On ),_Fade.rgb,node_8399));
                float3 node_5811 = (node_9908*lerp(_Shadow_Color.rgb,_Lioght_Color.rgb,dot(normalDirection,lightDirection)));
                float3 finalColor = lerp(((node_5811+(node_5811*pow(max(0,dot(lightDirection,viewReflectDirection)),_Glossiness)))*_LightColor0.rgb*attenuation),_Fade.rgb,node_8399);
                return fixed4(finalColor * 1,0);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
